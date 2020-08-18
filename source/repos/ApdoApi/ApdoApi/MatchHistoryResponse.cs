using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ApdoApi
{
    public class MatchHistoryResponse
    {
        public List<Match> matches { get; set; }
    }
}
