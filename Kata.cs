using System;

namespace Kata
{
    public class Kata
    {
        private static readonly string[] _romanNumbers = new[] { "I", "II", "III", "IV", "V" };

        public string ToRoman(int number)
        {
            int tenths = number / 10;

            return UpToNineTenths(tenths) + UpToNine(number - 10 * tenths);
        }

        private string UpToNineTenths(int tenths)
        {
            var tenthsStr = string.Empty;
            
            if (tenths == 4)
            {
                tenthsStr = "XL";
            }

            if (tenths == 9)
            {
                tenthsStr = "XC";
            }

            int repeat = 0;
            if (tenths > 4 && tenths < 9)
            {
                tenthsStr = "L";
                repeat = tenths - 5;
            }

            if (tenths < 4)
            {
                repeat = tenths;
            }

            tenthsStr += RepeatUpTo(repeat, "X");

            return tenthsStr;
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
