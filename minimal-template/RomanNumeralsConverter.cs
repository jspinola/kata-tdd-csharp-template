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
            if (arabicNumber > 3999)
            {
                return string.Empty;
            }
            
            string romanNumeral = string.Empty;

            string numberString = $"{arabicNumber}";

            romanNumeral += GetRomanPart(numberString, Units.Thousands);
            romanNumeral += GetRomanPart(numberString, Units.Hundreds);
            romanNumeral += GetRomanPart(numberString, Units.Tenths);
            romanNumeral += GetRomanPart(numberString, Units.Unit);
            return romanNumeral;
        }

        private string GetRomanPart(string arabicNumber, Units unit)
        {
            int position = 0;
            switch (unit)
            {
                case Units.Unit:
                    position = 1;
                    break;

                case Units.Tenths:
                    position = 2;
                    break;

                case Units.Hundreds:
                    position = 3;
                    break;

                case Units.Thousands:
                    position = 4;
                    break;

                default:
                    position = 0;
                    break;
            }

            int index = arabicNumber.Length - position;
            if (index >= 0)
            {
                var arabicUnit = arabicNumber.Substring(index, 1);
                if (!string.IsNullOrEmpty(arabicUnit))
                {
                    return BuildPart(Int32.Parse(arabicUnit), unit);
                }
            }

            return string.Empty;
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

                case Units.Tenths:
                    return new [] { ROMAN_TEN, ROMAN_FIFTY, ROMAN_HUNDRED };
                
                case Units.Hundreds:
                    return new [] { ROMAN_HUNDRED, ROMAN_FIVE_HUNDRED, ROMAN_THOUSAND };

                case Units.Thousands:
                    return new [] { ROMAN_THOUSAND, string.Empty, string.Empty };

                default:
                    return new string[]{};
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
