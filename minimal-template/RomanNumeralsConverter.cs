using System.Text;
namespace Kata
{
    public class RomanNumeralsConverter
    {
        private const string ROMAN_ONE = "I";
        private const string ROMAN_FIVE = "V";

        public string FromArabic(int arabicNumber)
        {
            if (arabicNumber <= 3)
            {
                return BuildLessThanOrEqualToThree(arabicNumber);
            }

            if (arabicNumber == 4)
            {
                return "IV";
            }

            if (arabicNumber == 5)
            {
                return ROMAN_FIVE;
            }

            if (arabicNumber < 9)
                return ROMAN_FIVE + BuildLessThanOrEqualToThree(arabicNumber - 5);

            //if (arabicNumber == 9)
                return "IX";
        }

        private string BuildLessThanOrEqualToThree(int arabicNumber)
        {
            StringBuilder sb = new StringBuilder();

            int counter = 0;
            while (counter < arabicNumber && counter < 3)
            {
                sb.Append(ROMAN_ONE);
                counter++;
            }

            return sb.ToString();
        }
    }
}
