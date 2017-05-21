using System;
using System.Linq;

namespace StringCalculatorKata.Library
{
    public class StringCalculator
    {
        public int Add(string numbersToAdd)
        {
            numbersToAdd = RemoveNewLine(numbersToAdd);
            var numbers = numbersToAdd.Split(',');
            var result = 0;
            foreach (var number in numbers)
            {
                result += string.IsNullOrEmpty(number)
                    ? 0
                    : Convert.ToInt32(number);
            }
            return result;
        }

        private string RemoveNewLine(string numbersToAdd)
        {
            var result = numbersToAdd.Replace("\n", ",");
            return result;
        }
    }
}