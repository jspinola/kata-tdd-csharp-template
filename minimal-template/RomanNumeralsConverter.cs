namespace Kata
{
    public class RomanNumeralsConverter
    {
        public string FromArabic(int arabicNumber)
        {
            if (arabicNumber == 1)
            {
                return "I";
            }

            return "II";
        }
    }
}
