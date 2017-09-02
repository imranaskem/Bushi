using Bushi.Enums;
using Bushi.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bushi.Models
{
    public class BaseDeck<T> : IEnumerable<T> where T: IBasicCard
    {
        private List<T> Cards { get; set; }

        public BaseDeck()
        {
            this.Cards = new List<T>();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.Cards.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.Cards.GetEnumerator();
        }

        public void Add(T card)
        {
            this.Cards.Add(card);
        }

        public BaseDeck<T> GetCardsByClan(Clan clan)
        {
            var newDeck = new BaseDeck<T>();

            var clanCards = this.Cards.Where(card => card.Clan == clan).ToList();

            if (clanCards == null)
            {
                return (BaseDeck<T>)Enumerable.Empty<T>();
            }

            newDeck.Cards = clanCards;

            return newDeck;
        }

        public BaseDeck<T> GetCardsBySide(Side side)
        {
            var newDeck = new BaseDeck<T>();

            var sideCards = this.Cards.Where(card => card.Side == side).ToList();

            if (sideCards == null)
            {
                return (BaseDeck<T>)Enumerable.Empty<T>();
            }

            newDeck.Cards = sideCards;

            return newDeck;
        }

        public BaseDeck<T> GetCardsByName(string name)
        {
            var searchResults = this.Cards.Where(card => card.Name.ToLower().Contains(name.ToLower()));

            if (searchResults == null)
            {
                return new BaseDeck<T>();
            }
            else
            {
                var results = new BaseDeck<T>
                {
                    Cards = (List<T>)searchResults
                };

                return results;

            }
        }
    }
}
