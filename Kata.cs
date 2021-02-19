using System;

namespace Kata
{
    public class Kata
    {
        private static readonly string[] _romanNumbers = new[] { "I", "II", "III", "IV", "V" };

        public string ToRoman(int number)
        {
            int tenths = number / 10;

            int count = 0;
            var tenthsStr = string.Empty;
            
            if (tenths == 4)
            {
                tenthsStr = "XL";
            }

            if (tenths == 9)
            {
                tenthsStr = "XC";
            }

            if (tenths > 4 && tenths < 9)
            {
                tenthsStr = "L";
                while (count < tenths - 5)
                {
                    tenthsStr += "X";
                    count++;
                }
            }

            if (tenths < 4)
            {
                tenthsStr += RepeatUpTo(tenths, "X");
            }

            if (number > 9)
            {
                return tenthsStr + UpToNine(number - 10 * tenths);
            }

            return UpToNine(number);
        }

        public string RepeatUpTo(int times, string romanNumeral)
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

        public string UpToNine(int number)
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
