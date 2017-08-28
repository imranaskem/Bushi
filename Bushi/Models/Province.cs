using Bushi.Enums;
using Bushi.Models.Common;
using Bushi.JsonDtos;
using System.Collections.Generic;
using System;
using Bushi.Extensions;
using Bushi.Interfaces;

namespace Bushi.Models
{
    public class Province : IClan
    {
        public bool Unique { get; }
        public CardType Type { get; }
        public Clan Clan { get; }
        public int DeckLimit { get; }
        public int Strength { get; }
        public List<string> Traits { get; }
        public PackInfo PackInfo { get; }
        public string CardText { get; }
        public string Name { get; }
        public string Id { get; }

        public Province(Card card)
        {
            this.Clan = card.Clan.ConvertToEnum<Clan>();
            this.Type = card.Type.ConvertToEnum<CardType>();
            this.DeckLimit = card.DeckLimit;
            this.Strength = (int)card.Strength;
            this.Traits = new List<string>();
            this.Traits.AddRange(card.Traits);
            this.PackInfo = new PackInfo(card.PackCards);
            this.CardText = card.TextCanonical;
            this.Name = card.Name;
            this.Id = card.Id;
        }
    }
}
