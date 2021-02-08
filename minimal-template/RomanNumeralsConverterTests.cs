using Xunit;
using FluentAssertions;

namespace Kata.Test
{
    public class RomanNumeralsConverterTests
    {
        [Fact]
        public void foo_should_return_one()
        {
            var sut = new RomanNumeralsConverter();

            var result = sut.FromArabic();

            result.Should().Be(1);
        }
    }
}
