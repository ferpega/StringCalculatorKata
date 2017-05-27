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
                var number = GetNumberFromString(numberString);

                negativeNumbers = ConcatenateNegativeNumber(negativeNumbers, number);               

                result += AddNewNumberOnlyIfLessThanOrEqualTo1000(number);
            }

            if (string.IsNullOrEmpty(negativeNumbers))
            {
                return result;
            }

            throw new Exception($"Non supported negative numbers: {negativeNumbers}");
        }

        private int GetNumberFromString(string numberString)
        {
            return string.IsNullOrEmpty(numberString)
                ? 0
                : Convert.ToInt32(numberString);
        }

        private string ConcatenateNegativeNumber(string negativeNumbers, int number)
        {
            var result = negativeNumbers;

            if (number < 0)
            {
                result += string.IsNullOrEmpty(negativeNumbers)
                    ? string.Empty
                    : ", ";
                result += $"{number}";
            }
            return result;
        }

        private int AddNewNumberOnlyIfLessThanOrEqualTo1000(int number)
        {
            return number > 1000
                      ? 0
                      : number;
        }
    }
}