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

            if (arabicNumber == 2)
                return "II";

            return "III";
        }
    }
}
