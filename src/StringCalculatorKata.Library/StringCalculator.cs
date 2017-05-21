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

            var negativeNumbers = string.Empty;

            foreach (var numberString in inputStringManager.NumberStrings)
            {
                var number = string.IsNullOrEmpty(numberString)
                    ? 0
                    : Convert.ToInt32(numberString);

                if (number < 0)
                {
                    negativeNumbers += string.IsNullOrEmpty(negativeNumbers)
                        ? numberString
                        : $", {numberString}";
                }

                result += number;
            }

            if (string.IsNullOrEmpty(negativeNumbers))
            {
                return result;
            }

            throw new Exception($"negativos no soportados: {negativeNumbers}");
        }
    }
}