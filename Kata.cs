namespace Kata
{
    public class Kata
    {
        public string ToRoman(int number)
        {
            var romanNumbers = new[] { "I", "II", "III", "IV", "V" };

            if (number < 6 )
            {
                return romanNumbers[number - 1];
            }

            if (number == 9)
            {
                return "IX";
            }

            return ToRoman(number - 1) + ToRoman(1);
        }
    }
}
