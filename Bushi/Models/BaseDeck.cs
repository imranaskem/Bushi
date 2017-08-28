using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bushi.Models
{
    public class BaseDeck<T> : IEnumerable<T>
    {
        private List<T> Attachments { get; set; }

        public BaseDeck()
        {
            this.Attachments = new List<T>();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.Attachments.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.Attachments.GetEnumerator();
        }

        public void Add(T card)
        {
            this.Attachments.Add(card);
        }
    }
}
