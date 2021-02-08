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
        public void should_return_units_number_in_roman_representation(int number, string expectedValue)
        {
            var sut = new RomanNumeralsConverter();

            var result = sut.FromArabic(number);

            result.Should().Be(expectedValue);
        }
    }
}