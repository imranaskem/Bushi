using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bushi.Extensions
{
    public static class Extensions
    {        
        public static int ConvertBonusToInt(this string bonus)
        {
            if (bonus.Contains("X"))
            {
                return 0;
            }

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

        public static T ConvertToEnum<T>(this string input)
        {
            var newInput = input.Replace("-", String.Empty);

            var value = (T)Enum.Parse(typeof(T), newInput.ToString(), true);

            return value;
        }
    }
}
