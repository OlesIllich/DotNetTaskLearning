using DotNetLearning.Strings;
using FluentAssertions;
using Xunit;

namespace DotNetLearningTest
{
    public class StringBuilderTaskTest
    {
        private readonly StringBuilderTask _stringBuilderTask;

        public StringBuilderTaskTest()
        {
            _stringBuilderTask = new StringBuilderTask();
        }

        [Theory]
        [InlineData("a", "b", "c", "abc")]
        public void GetFirstTest(string str1, string str2, string str3, string result)
        {
            // Act
            // Assert
            _stringBuilderTask.SetStringBuilder(str1, str2, str3).Should().Be(result);
        }
    }
}