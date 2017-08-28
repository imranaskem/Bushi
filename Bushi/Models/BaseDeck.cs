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
    public class BaseDeck<T> : IEnumerable<T> where T: IClan
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

            newDeck.Cards = clanCards;

            return newDeck;
        }
    }
}
