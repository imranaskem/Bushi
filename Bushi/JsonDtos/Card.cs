using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bushi.JsonDtos
{
    public class Card
    {
        [JsonProperty("clan")]
        public string Clan { get; set; }

        [JsonProperty("cost")]
        public int Cost { get; set; }

        [JsonProperty("deck_limit")]
        public int DeckLimit { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("influence_cost")]
        public int InfluenceCost { get; set; }

        [JsonProperty("military_bonus")]
        public string MilitaryBonus { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("name_canonical")]
        public string NameCanonical { get; set; }

        [JsonProperty("pack_cards")]
        public PackInformation[] PackCards { get; set; }

        [JsonProperty("political_bonus")]
        public string PoliticalBonus { get; set; }

        [JsonProperty("side")]
        public string Side { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("text_canonical")]
        public string TextCanonical { get; set; }

        [JsonProperty("traits")]
        public string[] Traits { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("unicity")]
        public bool Unicity { get; set; }

        [JsonProperty("glory")]
        public int? Glory { get; set; }

        [JsonProperty("military")]
        public int? Military { get; set; }

        [JsonProperty("political")]
        public int? Political { get; set; }

        [JsonProperty("element")]
        public string Element { get; set; }

        [JsonProperty("strength")]
        public int? Strength { get; set; }

        [JsonProperty("strength_bonus")]
        public string StrengthBonus { get; set; }

        [JsonProperty("fate")]
        public int? Fate { get; set; }

        [JsonProperty("honor")]
        public int? Honor { get; set; }

        [JsonProperty("influence_pool")]
        public int? InfluencePool { get; set; }
    }
}
