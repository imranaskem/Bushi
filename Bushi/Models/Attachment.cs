﻿using Bushi.Enums;
using Bushi.Models.Common;
using Bushi.JsonDtos;
using System.Collections.Generic;
using System;

namespace Bushi.Models
{
    public class Attachment
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

        public Attachment(Card cardFromJson)
        {
            this.Clan = (Clan)Enum.Parse(typeof(Clan), cardFromJson.Clan);
            this.Side = (Side)Enum.Parse(typeof(Side), cardFromJson.Side);
            this.Type = (CardType)Enum.Parse(typeof(CardType), cardFromJson.Type);
            this.Cost = cardFromJson.Cost;
            this.DeckLimit = cardFromJson.DeckLimit;
            this.InfluenceCost = cardFromJson.InfluenceCost;
            this.MilitaryBonus = this.ConvertBonusToInt(cardFromJson.MilitaryBonus);
            this.PoliticalBonus = this.ConvertBonusToInt(cardFromJson.PoliticalBonus);
            this.CardText = cardFromJson.TextCanonical;
            this.Traits = new List<string>();
            this.Traits.AddRange(cardFromJson.Traits);
            this.Unique = cardFromJson.Unicity;
            this.PackInfo = new PackInfo(cardFromJson.PackCards);
            this.Name = cardFromJson.Name;
            this.Id = cardFromJson.Id;
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
