using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ApdoApi
{
    class GetByPuuIdResponse
    {
        [JsonPropertyName("accountId")]
        public string EncryptedAccID { get; set; }


    }
}
