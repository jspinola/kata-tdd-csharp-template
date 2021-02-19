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
        public void should_return_up_to_three_in_roman(int number, string expected)
        {
            var sut = new Kata();

            var result = sut.ToRoman(number);

            result.Should().Be(expected);
        }

        [Fact]
        public void should_return_four_in_roman()
        {
            var sut = new Kata();

            var result = sut.ToRoman(4);

            result.Should().Be("IV");
        }

        [Fact]
        public void should_return_five_in_roman()
        {
            var sut = new Kata();

            var result = sut.ToRoman(5);

            result.Should().Be("V");
        }
    }
}
