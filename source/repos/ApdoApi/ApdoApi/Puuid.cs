using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ApdoApi
{
    public class Response
    {
        [JsonPropertyName("puuid")]
        public string Puuid { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
