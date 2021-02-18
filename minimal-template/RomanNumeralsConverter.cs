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
                var hundreds = numberString.Substring(numberString.Length - 3, 1);
                Console.WriteLine($"Hundreds: {hundreds}");
                if (!string.IsNullOrEmpty(hundreds))
                {
                    romanNumeral += BuildPart(Int32.Parse(hundreds), Units.Hundreds);
                }
            }

            if (numberString.Length - 2 >= 0)
            {
                var tenths = numberString.Substring(numberString.Length - 2, 1);
                Console.WriteLine($"tenths: {tenths}");
                if (!string.IsNullOrEmpty(tenths))
                {
                    romanNumeral += BuildPart(Int32.Parse(tenths), Units.Tenths);
                }
            }

            if (numberString.Length - 1 >= 0)
            {
                var units = numberString.Substring(numberString.Length - 1, 1);
                Console.WriteLine($"units: {units}");
                if (!string.IsNullOrEmpty(units))
                {
                    romanNumeral += BuildPart(Int32.Parse(units), Units.Unit);
                }
            }
            return romanNumeral;
        }

        private enum Units
        {
            Unit = 0,
            Tenths = 1,
            Hundreds = 2,
            Thousands = 3
        };

        private string[] GetRomanSymbols(Units unit)
        {
            switch (unit)
            {
                case Units.Unit:
                    return new [] { ROMAN_ONE, ROMAN_FIVE, ROMAN_TEN };
                    break;

                case Units.Tenths:
                    return new [] { ROMAN_TEN, ROMAN_FIFTY, ROMAN_HUNDRED };
                    break;
                
                case Units.Hundreds:
                    return new [] { ROMAN_HUNDRED, ROMAN_FIVE_HUNDRED, ROMAN_THOUSAND };
                    break;

                default:
                    return new string[];
                    break;
            }
        }

        private string BuildPart(int arabicNumber, Units unit)
        {
            var romanSymbols = GetRomanSymbols(unit);

            if (arabicNumber <= 3)
            {
                return BuildLessThanOrEqualToThree(arabicNumber, romanSymbols[0]);
            }

            if (arabicNumber == 4)
            {
                return $"{romanSymbols[0]}{romanSymbols[1]}";
            }

            if (arabicNumber == 5)
            {
                return romanSymbols[1];
            }

            if (arabicNumber < 9)
                return romanSymbols[1] + BuildLessThanOrEqualToThree(arabicNumber - 5, romanSymbols[0]);

            return $"{romanSymbols[0]}{romanSymbols[2]}";
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
