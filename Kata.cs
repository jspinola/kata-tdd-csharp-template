using System;

namespace Kata
{
    public class Kata
    {
        private static readonly string[] _romanNumbers = new[] { "I", "II", "III", "IV", "V" };

        public string ToRoman(int number)
        {
            int thousands = number / 1000;
            int hundreds = (number - (thousands * 1000)) / 100;
            int tenths = (number - (hundreds * 100)) / 10;
            int units = number - (thousands * 1000) - (hundreds * 100) - (tenths * 10);

            return UpToNine(hundreds, "C", "D", "M") + UpToNine(tenths, "X", "L", "C") + UpToNine(units);
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
