using System;

namespace Kata
{
    public class Kata
    {
        private static readonly string[] _romanNumbers = new[] { "I", "II", "III", "IV", "V" };

        public string ToRoman(int number)
        {
            int tenths = number / 10;

            return UpToNine(tenths, "X", "L", "C") + UpToNine(number - 10 * tenths);
        }

        private string UpToNine(int number, string units, string fives, string tens, string prefix = "")
        {
            if (number == 0)
            {
                return prefix;
            }

            if (number < 4)
            {
                return prefix + RepeatUpTo(number, units);
            }

            if (number == 4)
            {
                return units + fives;
            }

            return UpToNine(number - 5, units, tens, "", fives);
        }

        private string RepeatUpTo(int times, string romanNumeral)
        {
            int count = 0;
            var romanString = string.Empty;
            while (count < times)
            {
                romanString += romanNumeral;
                count++;
            }

            return romanString;
        }

        private string UpToNine(int number)
        {
            if (number == 0)
            {
                return string.Empty;
            }

            if (number < 6 )
            {
                return _romanNumbers[number - 1];
            }

            if (number == 9)
            {
                return "IX";
            }

            return UpToNine(number - 1) + UpToNine(1);
        }
    }
}
