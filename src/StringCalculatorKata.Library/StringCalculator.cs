using System;

namespace StringCalculatorKata.Library
{
    public class StringCalculator
    {

        public int Add(string numbersToAdd)
        {
            return string.IsNullOrEmpty(numbersToAdd)
                ? 0
                : 1;
        }
    }
}