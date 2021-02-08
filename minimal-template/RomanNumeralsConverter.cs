using System.Text;
namespace Kata
{
    public class RomanNumeralsConverter
    {
        private const string ROMAN_ONE = "I";

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
                return "V";
            }

            return $"V" + BuildLessThanOrEqualToThree(arabicNumber - 5);
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
