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

        public CardDeck(List<Card> cards)
        {
            this.Attachments = new BaseDeck<Attachment>();
        }
    }
}
