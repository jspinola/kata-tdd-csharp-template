using System;

namespace Kata
{
    public class Kata
    {
        public string ToRoman(int number)
        {
            int thousands = number / 1000;
            int hundreds = (number - (thousands * 1000)) / 100;
            int tenths = (number - (thousands * 1000) - (hundreds * 100)) / 10;
            int units = number - (thousands * 1000) - (hundreds * 100) - (tenths * 10);

            return UpToNine(thousands, "M", "", "") + UpToNine(hundreds, "C", "D", "M") + UpToNine(tenths, "X", "L", "C") + UpToNine(units, "I", "V", "X");
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
            var romanString = string.Empty;
            while (times > 0)
            {
                romanString += romanNumeral;
                times--;
            }

            return romanString;
        }
    }
}
