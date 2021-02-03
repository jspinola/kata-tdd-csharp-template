using Xunit;
using FluentAssertions;

namespace Kata.Test.Unit
{
    public class StringCalculatorSpecs
    {
        private StringCalculator _sut = new StringCalculator();

        [Fact]
        public void addition_of_nothing_is_zero()
        {
            var result = _sut.Add(string.Empty);
            result.Should().Be(0);
        }

        [Theory]
        [InlineData("1", 1)]
        [InlineData("2", 2)]
        [InlineData("3", 3)]
        public void addition_of_a_single_number_is_itself(string inputValue, int expectedValue)
        {
            var result = _sut.Add(inputValue);
            result.Should().Be(expectedValue);
        }

        [Theory]
        [InlineData("1,2", 3)]
        [InlineData("2,3", 5)]
        [InlineData("3,4", 7)]
        public void addition_of_two_numbers_is_their_sum(string inputValue, int expectedValue)
        {
            var result = _sut.Add(inputValue);
            result.Should().Be(expectedValue);
        }

        [Theory]
        [InlineData("1,2,3", 6)]
        [InlineData("2,3,4,5", 14)]
        [InlineData("3,4,5,6,7", 25)]
        public void addition_of_many_numbers_is_their_sum(string inputValue, int expectedValue)
        {
            var result = _sut.Add(inputValue);
            result.Should().Be(expectedValue);
        }

        [Fact]
        public void end_of_line_is_a_valid_number_separator()
        {
            var result = _sut.Add("1\n2,3");
            result.Should().Be(6);
        }

        [Theory]
        [InlineData(';')]
        public void custom_delimiter_can_be_specified(char customDelimiter)
        {
            var result = _sut.Add($"//{customDelimiter}\n1{customDelimiter}2");

            result.Should().Be(3);
        }
    }
}
