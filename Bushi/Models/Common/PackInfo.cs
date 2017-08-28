using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bushi.Enums;
using Bushi.JsonDtos;

namespace Bushi.Models.Common
{
    public class PackInfo
    {
        public Set Set { get; set; }
        public string NumberInSet { get; set; }
        public int QuantityInSet { get; set; }
        public string Illustrator { get; set; }

        public PackInfo(PackInformation[] packInfo)
        {
            this.Set = (Set)Enum.Parse(typeof(Set), this.ConvertWordToPascalCase(packInfo[0].Pack.Id));
            this.NumberInSet = packInfo[0].Position;
            this.QuantityInSet = packInfo[0].Quantity;
            this.Illustrator = packInfo[0].Illustrator;
        }

        private string ConvertWordToPascalCase(string input)
        {
            string sentence = input.ToLower();

            return sentence[0].ToString().ToUpper() +
               sentence.Substring(1);
        }
    }
}
