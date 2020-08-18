using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace ApdoApi
{
    public class DoritosClient
    {
        HttpClient client;
        string api_key;
        string region;
        public DoritosClient(string Api_Key, string Region)
        {
            api_key = Api_Key;
            region = Region;
        }

        public HttpClient GetClient()
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("X-Riot-Token", api_key);
            client.BaseAddress = new Uri($"https://{region}.api.riotgames.com");
            return client;
        }

    }
}
