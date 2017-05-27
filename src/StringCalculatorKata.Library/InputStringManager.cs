using System;
using System.Collections;

namespace StringCalculatorKata.Library
{
    public class InputStringManager
    {
        private string _inputString;
        private string _cleanedInputString;

        public InputStringManager(string inputString)
        {
            _inputString = inputString;
            Parse();
        }

        public string Delimiter { get; private set; }
        public string[] NumberStrings { get; private set; }

        private void Parse()
        {
            var semiCleanedInputString = ClearSpecifiedDelimiter();

            Delimiter = GetDelimiter(semiCleanedInputString);
            _cleanedInputString = RemoveNewLine(semiCleanedInputString);
            NumberStrings = _cleanedInputString.Split(new string[] { Delimiter }, StringSplitOptions.None);
        }

        private string ClearSpecifiedDelimiter()
        {
            if (_inputString.IndexOf("//") == 0)
                return _inputString.Substring(_inputString.IndexOf("\n") + 1);
            else
                return _inputString;
        }
        private string GetDelimiter(string semiCleanedInputString)
        {
            if (semiCleanedInputString != _inputString)
                return _inputString.Substring(2, _inputString.IndexOf("\n") - 2);
            else
                return ",";
        }
        private string RemoveNewLine(string semiCleanedInputString)
        {
            return semiCleanedInputString.Replace("\n", Delimiter);
        }
    }
}