using DotNetLearning.Loops;
using DotNetLearning.Strings;
using FluentAssertions;
using Xunit;

namespace DotNetLearningTest
{
    public class LoopsTaskTest
    {
        private readonly LoopsTask _stringTask;

        public LoopsTaskTest()
        {
            _stringTask = new LoopsTask();
        }

        [Theory]
        [InlineData("alahamora", "lhmor")]
        public void GetAllExceptATest(string str, string result)
        {
            // Act
            // Assert
            _stringTask.GetAllExceptA(str).Should().Be(result);
        }

        [Theory]
        [InlineData("alahamora", "aromahala")]
        public void ReturnMirrorTest(string str, string result)
        {
            // Act
            // Assert
            _stringTask.ReturnMirror(str).Should().Be(result);
        }
    }
}