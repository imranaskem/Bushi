using Bushi.Enums;
using Bushi.Models.Common;
using Bushi.JsonDtos;
using System.Collections.Generic;
using System;

namespace Bushi.Models
{
    public class Stronghold
    {
        public bool Unique { get; }
        public CardType Type { get; }
        public Clan Clan { get; }
        public int DeckLimit { get; }
        public int Honor { get; }
        public int Fate { get; }
        public int InfluencePool { get; }
        public int StrengthBonus { get; }
        public List<string> Traits { get; }
        public PackInfo PackInfo { get; }
        public Side Side { get; }
        public string CardText { get; }
        public string Name { get; }
        public string Id { get; }

        public Stronghold(Card card)
        {
            this.Clan = (Clan)Enum.Parse(typeof(Clan), card.Clan);
            this.Side = (Side)Enum.Parse(typeof(Side), card.Side);
            this.Type = (CardType)Enum.Parse(typeof(CardType), card.Type);
            this.DeckLimit = card.DeckLimit;
            this.Honor = (int)card.Honor;
            this.Fate = (int)card.Fate;
            this.InfluencePool = (int)card.InfluencePool;
            this.StrengthBonus = this.ConvertBonusToInt(card.StrengthBonus);
            this.CardText = card.TextCanonical;
            this.Traits = new List<string>();
            this.Traits.AddRange(card.Traits);
            this.Unique = card.Unicity;
            this.PackInfo = new PackInfo(card.PackCards);
            this.Name = card.Name;
            this.Id = card.Id;
        }

        private int ConvertBonusToInt(string bonus)
        {
            var split = bonus.ToCharArray();

            int bonusInt = 0;

            if (split[0] == '+')
            {
                var numString = split[1].ToString();
                bonusInt = int.Parse(numString);
            }
            else
            {
                var numString = split[1].ToString();
                bonusInt = int.Parse(numString);
                bonusInt = -bonusInt;
            }

            return bonusInt;
        }
    }
}
