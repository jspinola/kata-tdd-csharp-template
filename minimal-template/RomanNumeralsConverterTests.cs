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
        public void should_return_units_number_in_roman_representation(int number, string expectedValue)
        {
            var sut = new RomanNumeralsConverter();

            var result = sut.FromArabic(number);

            result.Should().Be(expectedValue);
        }

        [Theory]
        [InlineData(10, "X")]
        [InlineData(30, "XXX")]
        [InlineData(40, "XL")]
        [InlineData(50, "L")]
        [InlineData(90, "XC")]
        public void should_return_tenths_number_in_roman_representation(int number, string expectedValue)
        {
            var sut = new RomanNumeralsConverter();

            var result = sut.FromArabic(number);

            result.Should().Be(expectedValue);
        }

        [Theory]
        [InlineData(11, "XI")]
        [InlineData(34, "XXXIV")]
        [InlineData(99, "XCIX")]
        public void should_return_tenths_with_units_number_in_roman_representation(int number, string expectedValue)
        {
            var sut = new RomanNumeralsConverter();

            var result = sut.FromArabic(number);

            result.Should().Be(expectedValue);
        }

        [Theory]
        [InlineData(100, "C")]
        [InlineData(500, "D")]
        [InlineData(999, "CMXCIX")]
        public void should_return_any_number_from_100_to_999_in_roman_representation(int number, string expectedValue)
        {
            var sut = new RomanNumeralsConverter();

            var result = sut.FromArabic(number);

            result.Should().Be(expectedValue);
        }

        [Theory]
        [InlineData(1000, "M")]
        [InlineData(3000, "MMM")]
        [InlineData(3999, "MMMCMXCIX")]
        public void should_return_any_number_from_1000_to_3999_in_roman_representation(int number, string expectedValue)
        {
            var sut = new RomanNumeralsConverter();

            var result = sut.FromArabic(number);

            result.Should().Be(expectedValue);
        }
    }
}
