using DotNetLearning.Strings;
using FluentAssertions;
using Xunit;

namespace DotNetLearningTest
{
    public class StringTaskTests
    {
        private readonly StringTask _stringTask;
        public StringTaskTests()
        {
            _stringTask = new StringTask();
        }

        [Theory]
        [InlineData("string", 's')]
        public void GetFirstTest(string str, char result)
        {
            // Act
            // Assert
            _stringTask.GetFirst(str).Should().Be(result);
        }

        [Theory]
        [InlineData("string", 5)]
        public void GetStringLengthTest(string str , int result)
        {
            // Act
            // Assert
            _stringTask.GetStringLength(str).Should().Be(result);
        }

        [Theory]
        [InlineData("string", "STRING")]
        public void GetUpperCaseTest(string str, string result)
        {
            // Act
            // Assert
            _stringTask.GetUpperCase(str).Should().Be(result);
        }

        [Theory]
        [InlineData("string", "string", "stringstring")]
        public void Concatenate(string firstStr, string secondStr, string result)
        {
            // Act
            // Assert
            _stringTask.Concatenate(firstStr, secondStr).Should().Be(result);
        }
    }
}