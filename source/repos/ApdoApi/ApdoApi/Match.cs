using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ApdoApi
{
    public class Match
    {
        [JsonPropertyName("role")]
        public string role { get; set; }


        [JsonPropertyName("champion")]
        public int champion { get; set; }

        [JsonPropertyName("lane")]
        public string lane { get; set; }
    }
}
