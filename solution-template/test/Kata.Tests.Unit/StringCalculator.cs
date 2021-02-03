using System;
using System.Linq;

namespace Kata.Test.Unit
{
    internal class StringCalculator
    {
        const char DEFAULT_DELIMITER = ',';        

        internal int Add(string command)
        {
            if (command == string.Empty) return 0;

            var delimiter = DEFAULT_DELIMITER;
            string numbers = "";
            if (OverridesDefaultDelimiter(command))
            {
                delimiter = command[2];
                numbers = command.Substring(4);
            }
            else
            {
                numbers = command;
            }

            var commaSepparatedNumbers = EndOfLineToDelimiter(numbers, delimiter);
            string[] operands = commaSepparatedNumbers.Split(delimiter);

            int result = 0;
            foreach (var number in operands)
            {
                result += Int32.Parse(number);
            }

            return result;
        }

        private bool OverridesDefaultDelimiter(string numbers)
        {
            return numbers.StartsWith("//");
        }

        private string EndOfLineToDelimiter(string numbers, char delimiter)
        {
            return numbers.Replace('\n', delimiter);
        }
    }
}