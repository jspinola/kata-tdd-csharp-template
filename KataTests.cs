using Xunit;
using FluentAssertions;

namespace Kata.Test
{
    public class KataTests
    {
        [Fact]
        public void foo_should_return_one()
        {
            var sut = new Kata();

            var result = sut.Foo();

            result.Should().Be(1);
        }
    }
}
