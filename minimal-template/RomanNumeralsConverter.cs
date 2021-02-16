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
        private const string ROMAN_HUNDRED = "C";

        public string FromArabic(int arabicNumber)
        {
            string romanNumeral = string.Empty;

            int tenths = arabicNumber / 10;

            if (tenths > 0)
            {
                romanNumeral = BuildLessThanTen(tenths, ROMAN_TEN, ROMAN_FIFTY, ROMAN_HUNDRED);
            }

            int units = arabicNumber - tenths * 10;
            if (units < 10)
            {
                romanNumeral += BuildLessThanTen(units, ROMAN_ONE, ROMAN_FIVE, ROMAN_TEN);
            }

            return romanNumeral;
        }

        private string BuildLessThanTen(int arabicNumber, string romanNumeral, string secondaryRomanNumeral, string thirdRomanNumeral)
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

            return $"{romanNumeral}{thirdRomanNumeral}";
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
