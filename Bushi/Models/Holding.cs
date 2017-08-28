using Bushi.Enums;
using Bushi.Models.Common;
using Bushi.JsonDtos;
using System.Collections.Generic;
using System;
using Bushi.Extensions;
using Bushi.Interfaces;

namespace Bushi.Models
{
    public class Holding : IClan
    {
        public bool Unique { get; }
        public CardType Type { get; }
        public Clan Clan { get; }
        public int DeckLimit { get; }
        public int StrengthBonus { get; }
        public List<string> Traits { get; }
        public PackInfo PackInfo { get; }
        public Side Side { get; }
        public string CardText { get; }
        public string Name { get; }
        public string Id { get; }

        public Holding(Card card)
        {
            this.Clan = card.Clan.ConvertToEnum<Clan>();
            this.Type = card.Type.ConvertToEnum<CardType>();
            this.Side = card.Side.ConvertToEnum<Side>();
            this.DeckLimit = card.DeckLimit;
            this.StrengthBonus = card.StrengthBonus.ConvertBonusToInt();
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
