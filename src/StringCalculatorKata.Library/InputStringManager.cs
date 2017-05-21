using System;
using System.Collections;

namespace StringCalculatorKata.Library
{
    public class InputStringManager
    {
        public InputStringManager(string inputString)
        {
            InputString = inputString;
            Parse();
        }

        public string InputString { get; private set; }
        public string CleanedInputString { get; private set; }
        public string Delimiter { get; private set; }
        public string[] NumberStrings { get; private set; }

        private void Parse()
        {
            var semiCleanedInputString = ClearSpecifiedDelimiter();
            Delimiter = GetDelimiter(semiCleanedInputString);
            CleanedInputString = RemoveNewLine(semiCleanedInputString);
            NumberStrings = CleanedInputString.Split(new string[] { Delimiter }, StringSplitOptions.None);
        }
        private string ClearSpecifiedDelimiter()
        {
            var result = InputString;
            if (InputString.IndexOf("//") == 0)
            {
                result = InputString.Substring(InputString.IndexOf("\n") + 1);
            }
            return result;
        }

        private string GetDelimiter(string semiCleanedInputString)
        {
            var result = ",";
            if (semiCleanedInputString != InputString)
            {
                result = InputString.Substring(2, InputString.IndexOf("\n") - 2);
            }
            return result;
        }

        private string RemoveNewLine(string semiCleanedInputString)
        {
            var result = semiCleanedInputString.Replace("\n", Delimiter);
            return result;
        }
    }
}