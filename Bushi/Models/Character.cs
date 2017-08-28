using Bushi.Enums;
using Bushi.Extensions;
using Bushi.Models.Common;
using Bushi.JsonDtos;
using System.Collections.Generic;
using System;
using Bushi.Interfaces;

namespace Bushi.Models
{
    public class Character :IClan
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

        public Character(Card card)
        {
            this.Clan = card.Clan.ConvertToEnum<Clan>();
            this.Type = card.Type.ConvertToEnum<CardType>();
            this.Side = card.Side.ConvertToEnum<Side>();
            this.Cost = card.Cost;
            this.DeckLimit = card.DeckLimit;
            this.Glory = (int)card.Glory;
            this.InfluenceCost = card.InfluenceCost;

            if (card.Military == null)
            {
                this.Military = 0;
            }
            else
            {
                this.Military = (int)card.Military;
            }

            if (card.Political == null)
            {
                this.Political = 0;
            }
            else
            {
                this.Political = (int)card.Political;
            }

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
