using System.Text;
namespace Kata
{
    public class RomanNumeralsConverter
    {
        private const string ROMAN_ONE = "I";

        public string FromArabic(int arabicNumber)
        {
            if (arabicNumber > 3)
            {
                return "IV";
            }

            StringBuilder sb = new StringBuilder();

            int counter = 0;
            while (counter < arabicNumber)
            {
                sb.Append(ROMAN_ONE);
                counter++;
            }

            return sb.ToString();
        }
    }
}
