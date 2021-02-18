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
        private const string ROMAN_FIVE_HUNDRED = "D";
        private const string ROMAN_THOUSAND = "M";

        public string FromArabic(int arabicNumber)
        {
            string romanNumeral = string.Empty;
            Console.WriteLine($"arabicNumber: {arabicNumber}");

            string numberString = $"{arabicNumber}";

            if (numberString.Length - 3 >= 0)
            {
                var hundreds = numberString.Substring(numberString.Length - 3, 1);//arabicNumber / 100;
                Console.WriteLine($"Hundreds: {hundreds}");
                if (!string.IsNullOrEmpty(hundreds))
                {
                    romanNumeral += BuildLessThanTen(Int32.Parse(hundreds), ROMAN_HUNDRED, ROMAN_FIVE_HUNDRED, ROMAN_THOUSAND);
                }
            }

            if (numberString.Length - 2 >= 0)
            {
                var tenths = numberString.Substring(numberString.Length - 2, 1); // (arabicNumber - hundreds * 100) / 10;
                Console.WriteLine($"tenths: {tenths}");
                if (!string.IsNullOrEmpty(tenths))
                {
                    romanNumeral += BuildLessThanTen(Int32.Parse(tenths), ROMAN_TEN, ROMAN_FIFTY, ROMAN_HUNDRED);
                }
            }

            if (numberString.Length - 1 >= 0)
            {
                var units = numberString.Substring(numberString.Length - 1, 1); //arabicNumber - tenths * 10;
                Console.WriteLine($"units: {units}");
                if (!string.IsNullOrEmpty(units))
                {
                    romanNumeral += BuildLessThanTen(Int32.Parse(units), ROMAN_ONE, ROMAN_FIVE, ROMAN_TEN);
                }
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
