using System;
using System.Linq;

namespace StringCalculatorKata.Library
{
    public class StringCalculator
    {
        public int Add(string numbersToAdd)
        {
            var inputStringManager = new InputStringManager(numbersToAdd);
            var result = 0;
            foreach (var number in inputStringManager.Numbers)
            {
                result += string.IsNullOrEmpty(number)
                    ? 0
                    : Convert.ToInt32(number);
            }
            return result;
        }
    }
}