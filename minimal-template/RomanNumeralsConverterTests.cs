using Xunit;
using FluentAssertions;

namespace Kata.Test
{
    public class RomanNumeralsConverterTests
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(6, "VI")]
        [InlineData(7, "VII")]
        [InlineData(8, "VIII")]
        [InlineData(9, "IX")]
        [InlineData(10, "X")]
        public void should_return_units_number_in_roman_representation(int number, string expectedValue)
        {
            var sut = new RomanNumeralsConverter();

            var result = sut.FromArabic(number);

            result.Should().Be(expectedValue);
        }
    }
}
