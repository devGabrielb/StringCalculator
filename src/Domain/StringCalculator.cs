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
            var separator = string.Empty;
            var negativeNumbers = new List<int>();
            var total = num.Split(',');

            foreach (var item in total)
            {
                if(int.Parse(item) < 0)
                {
                    negativeNumbers.Add(int.Parse(item));
                }
            }

            if (negativeNumbers.Count > 0)
            {
                num = string.Join(" ", negativeNumbers.ToArray());
                throw new Exception($"error: negatives not allowed: {num}");
            }

            if (string.IsNullOrWhiteSpace(numbers))
            {
                return 0;
            }
            if(numbers.StartsWith("//"))
            {
                num = numbers.Trim('/');
                separator = num.Substring(0, 1);
                num = num.Replace(separator, ",");
                num = num.Substring(2);
               
            }
            num = num.Replace('\n',',');
            return num.Split(',').Select(n => int.Parse(n)).Sum();
        }
    }
}
