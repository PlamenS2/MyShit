using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace ApdoApi
{
    class Program
    {
        private static readonly string SummonerName = "hide on bush";
        private static readonly string ApiKey = "RGAPI-14262e2d-6cd5-4581-94d0-6724815f994f";
        private static readonly string Region = "kr";

        private static readonly HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            await ProcessRepositories();
        }

        private static async Task ProcessRepositories()
        {
            DoritosClient dc = new DoritosClient(ApiKey, Region);
            var client = dc.GetClient();

            var streamTask = client.
                GetStreamAsync($"/lol/summoner/v4/summoners/by-name/{SummonerName}");

            var resp = await JsonSerializer.DeserializeAsync<Response>(await streamTask);

            var accTask = client.
                GetStreamAsync($"lol/summoner/v4/summoners/by-puuid/{resp.Puuid}");

            var account_response = await JsonSerializer.DeserializeAsync<GetByPuuIdResponse>(await accTask);

            var matchList = client.
                GetStreamAsync($"/lol/match/v4/matchlists/by-account/{account_response.EncryptedAccID}");

            var matchHistory = await JsonSerializer.DeserializeAsync<MatchHistoryResponse>(await matchList);



            Console.Write(matchHistory.ToString());
        }
    }
}
