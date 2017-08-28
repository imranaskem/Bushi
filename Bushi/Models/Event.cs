using Bushi.Enums;
using Bushi.Models.Common;
using Bushi.JsonDtos;
using System.Collections.Generic;
using System;

namespace Bushi.Models
{
    public class Event
    {
        public bool Unique { get; }
        public CardType Type { get; }
        public Clan Clan { get; }
        public int Cost { get; }
        public int DeckLimit { get; }
        public int InfluenceCost { get; }
        public List<string> Traits { get; }
        public PackInfo PackInfo { get; }
        public Side Side { get; }
        public string CardText { get; }
        public string Name { get; }
        public string Id { get; }

        public Event(Card card)
        {
            this.Clan = (Clan)Enum.Parse(typeof(Clan), card.Clan);
            this.Side = (Side)Enum.Parse(typeof(Side), card.Side);
            this.Type = (CardType)Enum.Parse(typeof(CardType), card.Type);
            this.Cost = card.Cost;
            this.DeckLimit = card.DeckLimit;
            this.InfluenceCost = card.InfluenceCost;
            this.CardText = card.TextCanonical;
            this.Traits = new List<string>();
            this.Traits.AddRange(card.Traits);
            this.Unique = card.Unicity;
            this.PackInfo = new PackInfo(card.PackCards);
            this.Name = card.Name;
            this.Id = card.Id;
        }
    }
}
