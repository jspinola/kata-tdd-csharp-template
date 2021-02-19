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

            if (tenths > 4)
            {
                tenthsStr = "L";
                while (count < tenths - 5)
                {
                    tenthsStr += "X";
                    count++;
                }
            }

            while (count < tenths && tenths < 4)
            {
                tenthsStr += "X";
                count++;
            }

            if (number > 9)
            {
                return tenthsStr + UpToNine(number - 10 * tenths);
            }

            return UpToNine(number);
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
