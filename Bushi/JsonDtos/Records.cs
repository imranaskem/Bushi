using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Bushi.JsonDtos
{
    public class Records
    {
        [JsonProperty("records")]
        public Card[] Cards { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("last_updated")]
        public string LastUpdated { get; set; }
    }
}
