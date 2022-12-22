using DotNetLearning.EnumTask;
using FluentAssertions;
using Xunit;

namespace DotNetLearningTest
{
    public class EnumTaskTests
    {
        private readonly EnumTask _enumTask;

        public EnumTaskTests()
        {
            _enumTask = new EnumTask();
        }

        [Theory]
        [InlineData(DaysOfTheWeek.Monday)]
        public void GetFirstDayOfTheWeek(DaysOfTheWeek firstDaysOfTheWeek)
        {
            // Act
            // Assert
            _enumTask.GetFirstDayOfTheWeek().Should().Be(firstDaysOfTheWeek);
        }

        [Theory]
        [InlineData(0, DaysOfTheWeek.Monday)]
        [InlineData(1, DaysOfTheWeek.Tuesday)]
        [InlineData(2, DaysOfTheWeek.Wednesday)]
        [InlineData(3, DaysOfTheWeek.Thursday)]
        [InlineData(4, DaysOfTheWeek.Friday)]
        [InlineData(5, DaysOfTheWeek.Saturday)]
        [InlineData(6, DaysOfTheWeek.Sunday)]
        public void GetDayOfTheWeekTest(int index, DaysOfTheWeek result)
        {
            // Act
            // Assert
            _enumTask.GetDayOfTheWeek(index).Should().Be(result);
        }

        [Fact]
        public void GetAllDaysOfTheWeek()
        {
            // Arrange
            var resultList = new List<string>()
                { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            // Act
            // Assert
            _enumTask.GetAllDaysOfTheWeek().Should().BeEquivalentTo(resultList);
        }
    }
}
