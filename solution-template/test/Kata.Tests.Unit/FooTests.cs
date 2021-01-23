using Xunit;
using FluentAssertions;

namespace Kata.Test.Unit
{
    public class FooTests
    {
        public class FooMethod_Should
        {
            [Fact]
            public void be_one()
            {
                // Arrange
                var sut = new Foo();

                // Act
                var result = sut.Bar();

                // Assert
                result
                    .Should()
                    .Be(1);
            }
        }
    }
}
