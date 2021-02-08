using Xunit;
using FluentAssertions;

namespace Kata.Test
{
    public class RomanNumeralsConverterTests
    {
        [Fact]
        public void should_return_units_number_in_roman_representation()
        {
            var sut = new RomanNumeralsConverter();

            var result = sut.FromArabic(1);

            result.Should().Be("I");
        }
    }
}
