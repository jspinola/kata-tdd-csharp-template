using System.Text;
namespace Kata
{
    public class RomanNumeralsConverter
    {
        public string FromArabic(int arabicNumber)
        {
            StringBuilder sb = new StringBuilder();

            int counter = 0;
            while (counter < arabicNumber)
            {
                sb.Append("I");
                counter++;
            }

            return sb.ToString();
        }
    }
}
