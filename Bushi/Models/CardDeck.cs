using Bushi.Enums;
using Bushi.JsonDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bushi.Models
{
    public class CardDeck
    {
        public BaseDeck<Attachment> Attachments { get; private set; }
        public BaseDeck<Character> Characters { get; private set; }
        public BaseDeck<Event> Events { get; private set; }
        public BaseDeck<Holding> Holdings { get; private set; }
        public BaseDeck<Province> Provinces { get; private set; }
        public BaseDeck<Role> Roles { get; private set; }
        public BaseDeck<Stronghold> Strongholds { get; private set; }

        public CardDeck()
        {
            this.Attachments = new BaseDeck<Attachment>();
            this.Characters = new BaseDeck<Character>();
            this.Events = new BaseDeck<Event>();
            this.Holdings = new BaseDeck<Holding>();
            this.Provinces = new BaseDeck<Province>();
            this.Roles = new BaseDeck<Role>();
            this.Strongholds = new BaseDeck<Stronghold>();
        }

        public CardDeck(IEnumerable<Card> cards)
        {
            this.Attachments = new BaseDeck<Attachment>();
            this.Characters = new BaseDeck<Character>();
            this.Events = new BaseDeck<Event>();
            this.Holdings = new BaseDeck<Holding>();
            this.Provinces = new BaseDeck<Province>();
            this.Roles = new BaseDeck<Role>();
            this.Strongholds = new BaseDeck<Stronghold>();

            this.ParseCards(cards);
        }

        public CardDeck GetAllCardsByClan(Clan clan)
        {
            var newCardDeck = new CardDeck();

            newCardDeck.Attachments = this.Attachments.GetCardsByClan(clan);
            newCardDeck.Characters = this.Characters.GetCardsByClan(clan);
            newCardDeck.Events = this.Events.GetCardsByClan(clan);
            newCardDeck.Holdings = this.Holdings.GetCardsByClan(clan);
            newCardDeck.Provinces = this.Provinces.GetCardsByClan(clan);
            newCardDeck.Roles = this.Roles.GetCardsByClan(clan);
            newCardDeck.Strongholds = this.Strongholds.GetCardsByClan(clan);

            return newCardDeck;
        }

        private void ParseCards(IEnumerable<Card> cards)
        {
            foreach (var card in cards)
            {
                switch (card.Type)
                {
                    case "attachment":
                        var newAttachment = new Attachment(card);
                        this.Attachments.Add(newAttachment);
                        break;
                    case "character":
                        var newChar = new Character(card);
                        this.Characters.Add(newChar);
                        break;
                    case "event":
                        var newEvent = new Event(card);
                        this.Events.Add(newEvent);
                        break;
                    case "holding":
                        var newHolding = new Holding(card);
                        this.Holdings.Add(newHolding);
                        break;
                    case "province":
                        var newProvince = new Province(card);
                        this.Provinces.Add(newProvince);
                        break;
                    case "role":
                        var newRole = new Role(card);
                        this.Roles.Add(newRole);
                        break;
                    case "stronghold":
                        var newStrong = new Stronghold(card);
                        this.Strongholds.Add(newStrong);
                        break;
                }
            }
        }
    }
}
