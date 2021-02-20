using Xunit;
using FluentAssertions;

namespace Kata.Test
{
    public class KataTests
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        public void should_return_up_to_five_in_roman(int number, string expected)
        {
            var sut = new Kata();

            var result = sut.ToRoman(number);

            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(6, "VI")]
        [InlineData(7, "VII")]
        [InlineData(8, "VIII")]
        [InlineData(9, "IX")]
        public void should_return_in_roman(int number, string expected)
        {
            var sut = new Kata();

            var result = sut.ToRoman(number);

            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(10, "X")]
        [InlineData(11, "XI")]
        [InlineData(19, "XIX")]
        [InlineData(20, "XX")]
        [InlineData(29, "XXIX")]
        [InlineData(30, "XXX")]
        [InlineData(34, "XXXIV")]
        [InlineData(39, "XXXIX")]
        [InlineData(40, "XL")]
        [InlineData(49, "XLIX")]
        [InlineData(52, "LII")]
        [InlineData(64, "LXIV")]
        [InlineData(77, "LXXVII")]
        [InlineData(89, "LXXXIX")]
        [InlineData(90, "XC")]
        [InlineData(99, "XCIX")]
        public void should_return_in_roman_tenths(int number, string expected)
        {
            var sut = new Kata();

            var result = sut.ToRoman(number);

            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(999, "CMXCIX")]
        public void should_return_in_roman_hundreds(int number, string expected)
        {
            var sut = new Kata();

            var result = sut.ToRoman(number);

            result.Should().Be(expected);
        }
    }
}
