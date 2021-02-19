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
    }
}
