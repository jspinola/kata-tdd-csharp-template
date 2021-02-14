using System.Text;
using System;

namespace Kata
{
    public class RomanNumeralsConverter
    {
        private const string ROMAN_ONE = "I";
        private const string ROMAN_FIVE = "V";
        private const string ROMAN_TEN = "X";
        private const string ROMAN_FIFTY = "L";

        public string FromArabic(int arabicNumber)
        {
            if (arabicNumber < 10)
                return BuildLessThanTen(arabicNumber, ROMAN_ONE, ROMAN_FIVE);

            int tenths = arabicNumber / 10;

            Console.WriteLine($"{tenths}");
            if (tenths > 0)
            {
                return BuildLessThanTen(tenths, ROMAN_TEN, ROMAN_FIFTY);
            }

            return ROMAN_TEN;
        }

        private string BuildLessThanTen(int arabicNumber, string romanNumeral, string secondaryRomanNumeral)
        {
            if (arabicNumber <= 3)
            {
                return BuildLessThanOrEqualToThree(arabicNumber, romanNumeral);
            }

            if (arabicNumber == 4)
            {
                return $"{romanNumeral}{secondaryRomanNumeral}";
            }

            if (arabicNumber == 5)
            {
                return secondaryRomanNumeral;
            }

            if (arabicNumber < 9)
                return secondaryRomanNumeral + BuildLessThanOrEqualToThree(arabicNumber - 5, romanNumeral);

            return $"{romanNumeral}X";
        }

        private string BuildLessThanOrEqualToThree(int arabicNumber, string romanNumeral)
        {
            StringBuilder sb = new StringBuilder();

            int counter = 0;
            while (counter < arabicNumber && counter < 3)
            {
                sb.Append(romanNumeral);
                counter++;
            }

            return sb.ToString();
        }
    }
}
