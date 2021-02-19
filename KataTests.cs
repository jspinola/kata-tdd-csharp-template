using Xunit;
using FluentAssertions;

namespace Kata.Test
{
    public class KataTests
    {
        [Fact]
        public void should_return_one_in_roman()
        {
            var sut = new Kata();

            var result = sut.ToRoman(1);

            result.Should().Be("I");
        }

        [Fact]
        public void should_return_two_in_roman()
        {
            var sut = new Kata();

            var result = sut.ToRoman(2);

            result.Should().Be("II");
        }
    }
}
