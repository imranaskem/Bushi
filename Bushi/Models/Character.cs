using Bushi.Enums;
using Bushi.Models.Common;
using Bushi.JsonDtos;
using System.Collections.Generic;
using System;

namespace Bushi.Models
{
    public class Character
    {
        public bool Unique { get; }
        public CardType Type { get; }
        public Clan Clan { get; }
        public int Cost { get; }
        public int DeckLimit { get; }
        public int Glory { get; }
        public int InfluenceCost { get; }
        public int Military { get; }
        public int Political { get; }
        public List<string> Traits { get; }
        public PackInfo PackInfo { get; }
        public Side Side { get; }
        public string CardText { get; }
        public string Name { get; }
        public string Id { get; }

        public Character(Card cardFromJson)
        {
            this.Clan = (Clan)Enum.Parse(typeof(Clan), cardFromJson.Clan);
            this.Side = (Side)Enum.Parse(typeof(Side), cardFromJson.Side);
            this.Type = (CardType)Enum.Parse(typeof(CardType), cardFromJson.Type);
            this.Cost = cardFromJson.Cost;
            this.DeckLimit = cardFromJson.DeckLimit;
            this.Glory = (int)cardFromJson.Glory;
            this.InfluenceCost = cardFromJson.InfluenceCost;
            this.Military = (int)cardFromJson.Military;
            this.Political = (int)cardFromJson.Political;
            this.CardText = cardFromJson.TextCanonical;
            this.Traits = new List<string>();
            this.Traits.AddRange(cardFromJson.Traits);
            this.Unique = cardFromJson.Unicity;
            this.PackInfo = new PackInfo(cardFromJson.PackCards);
            this.Name = cardFromJson.Name;
            this.Id = cardFromJson.Id;
        }
    }
}
