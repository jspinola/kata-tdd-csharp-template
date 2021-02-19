namespace Kata
{
    public class Kata
    {
        public string ToRoman(int number)
        {
            var romanNumbers = new[] { "I", "II", "III", "IV" };

            return romanNumbers[number - 1];
        }
    }
}
