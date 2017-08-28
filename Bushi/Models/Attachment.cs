using Bushi.Enums;
using Bushi.Extensions;
using Bushi.Models.Common;
using Bushi.JsonDtos;
using System.Collections.Generic;
using System;
using Bushi.Interfaces;

namespace Bushi.Models
{
    public class Attachment : IClan
    {
        public bool Unique { get; }
        public CardType Type { get; }
        public Clan Clan { get; }
        public int Cost { get; }
        public int DeckLimit { get; }
        public int InfluenceCost { get; }
        public int MilitaryBonus { get; }
        public int PoliticalBonus { get; }
        public List<string> Traits { get; }
        public PackInfo PackInfo { get; }
        public Side Side { get; }
        public string CardText { get; }
        public string Name { get; }
        public string Id { get; }

        public Attachment(Card card)
        {
            this.Clan = card.Clan.ConvertToEnum<Clan>();
            this.Type = card.Type.ConvertToEnum<CardType>();
            this.Side = card.Side.ConvertToEnum<Side>();
            this.Cost = card.Cost;
            this.DeckLimit = card.DeckLimit;
            this.InfluenceCost = card.InfluenceCost;
            this.MilitaryBonus = card.MilitaryBonus.ConvertBonusToInt();
            this.PoliticalBonus = card.PoliticalBonus.ConvertBonusToInt();
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
