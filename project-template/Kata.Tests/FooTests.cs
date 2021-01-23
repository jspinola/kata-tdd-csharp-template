using Xunit;
using FluentAssertions;

namespace Kata.Tests
{
    public class FooTests
    {
        [Fact]
        public void Bar_should()
        {
            // Arrange
            var sut = new Foo();

            // Act
            var result = sut.Bar();

            // Assert
            result.Should().Be(1);
        }
    }
}
