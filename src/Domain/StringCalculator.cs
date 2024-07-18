using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public static class StringCalculator
    {
        public static int Add(string numbers)
        {
            var num = numbers;
            if (string.IsNullOrWhiteSpace(numbers))
            {
                return 0;
            }
            if(numbers.StartsWith("//"))
            {
               
               ///...
            }
            num = num.Replace('\n',',');
            return num.Split(',').Select(n => int.Parse(n)).Sum();
        }
    }
}
