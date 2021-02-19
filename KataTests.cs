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
    }
}
