using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bushi.JsonDtos
{
    public class PackInformation
    {
        [JsonProperty("illustrator")]
        public string Illustrator { get; set; }

        [JsonProperty("pack")]
        public Pack Pack { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }
}
