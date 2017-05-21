using System;
using System.Linq;

namespace StringCalculatorKata.Library
{
    public class StringCalculator
    {
        public int Add(string numbersToAdd)
        {
            var cleanedNumbersToAdd = ClearSpecifiedDelimiter(numbersToAdd);
            var delimiter = GetDelimiter(cleanedNumbersToAdd, numbersToAdd);
            cleanedNumbersToAdd = RemoveNewLine(cleanedNumbersToAdd, delimiter);
            var numbers = cleanedNumbersToAdd.Split(new string[] { delimiter }, StringSplitOptions.None);
            var result = 0;
            foreach (var number in numbers)
            {
                result += string.IsNullOrEmpty(number)
                    ? 0
                    : Convert.ToInt32(number);
            }
            return result;
        }

        private string GetDelimiter(string cleanedNumbersToAdd, string numbersToAdd)
        {
            var result = ",";
            if (cleanedNumbersToAdd != numbersToAdd)
            {
                result = numbersToAdd.Substring(2, numbersToAdd.IndexOf("\n") - 2);
            }
            return result;
        }

        private string ClearSpecifiedDelimiter(string numbersToAdd)
        {
            var result = numbersToAdd;
            if (numbersToAdd.IndexOf("//") == 0)
            {
                result = numbersToAdd.Substring(numbersToAdd.IndexOf("\n") + 1);
            }
            return result;
        }

        private string RemoveNewLine(string numbersToAdd, string newDelimiter)
        {
            var result = numbersToAdd.Replace("\n", newDelimiter);
            return result;
        }
    }
}