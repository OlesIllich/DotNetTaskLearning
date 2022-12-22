using DotNetLearning.ArrayTask;
using FluentAssertions;
using Xunit;

namespace DotNetLearningTest
{
    public class ArrayTasksTest
    {
        private readonly ArrayTasks _arrayTasks;

        public ArrayTasksTest()
        {
            _arrayTasks = new ArrayTasks();
        }

        [Fact]
        public void GetElementIndex()
        {
            // Arrange
            var array = new[] { 0, 1, 2, 3, 4, 5, 6, 7 };

            // Act
            // Assert
            _arrayTasks.GetElementIndex(array, 3).Should().Be(3);
        }

        [Fact]
        public void InvertArrayTask()
        {
            // Arrange
            var array = new[] { 0, 1, 2, 3, 4 };
            var result = new[] { 4, 3, 2, 1, 0 };

            // Act
            // Assert
            _arrayTasks.InvertArray(array).Should().BeEquivalentTo(result);
        }

        [Fact]
        public void GetArrayElementSumTest()
        {
            // Arrange
            var array = new[] { 0, 1, 2, 3, 4 };
            var result = 10;

            // Act
            // Assert
            _arrayTasks.GetArrayElementSum(array).Should().Be(result);
        }

        [Fact]
        public void ArrayConcatenationTest()
        {
            // Arrange
            var array = new[] { 0, 1, 2, 3, 4 };
            var secondArray = new[] { 3, 2, 1, 0 };
            var result = new[] { 0, 1, 2, 3, 4, 3, 2, 1, 0 };

            // Act
            // Assert
            _arrayTasks.ArrayConcatenation(array, secondArray).Should().BeEquivalentTo(result);
        }

    }
}