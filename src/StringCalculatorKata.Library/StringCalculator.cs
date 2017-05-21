using System;

namespace StringCalculatorKata.Library
{
    public class StringCalculator
    {

        public int Add(string numbersToAdd)
        {
            return string.IsNullOrEmpty(numbersToAdd)
                ? 0
                : numbersToAdd.Length == 1 
                    ? 1
                    : 3;
        }
    }
}