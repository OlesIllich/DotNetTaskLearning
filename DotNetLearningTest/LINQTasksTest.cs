using DotNetLearning.LINQTasks;
using FluentAssertions;
using Xunit;

namespace DotNetLearningTest
{
    public class LINQTasksTest
    {
        private LINQTasks _linqTasks;

        public LINQTasksTest()
        {
            _linqTasks = new LINQTasks();
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void OnlyPositiveFirstValueTest(List<LINQTestData> dataList)
        {
            // Act
            // Assert
            _linqTasks.OnlyPositiveFirstValue(dataList)
                .Any(d => d.FirstValue < 0).Should().BeFalse();
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void FirstValueSecondValueSumTest(List<LINQTestData> dataList)
        {
            // Act
            // Assert
            _linqTasks.FirstValueSecondValueSum(dataList).Should().Be(6);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void IsEmptyTest(List<LINQTestData> dataList)
        {
            // Act
            // Assert
            _linqTasks.IsEmpty(dataList).Should().BeFalse();
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void ReturnDateTimeListTest(List<LINQTestData> dataList)
        {
            // Act
            // Assert
            _linqTasks.ReturnDateTimeList(dataList).Should().AllBeOfType<DateTime>();
        }

        public static IEnumerable<object[]> Data()
        {
            yield return new object[]
            { new List<LINQTestData> {
                new() { DateTime = new DateTime(), FirstValue = 1, SecondValue = 1 },
                new() { DateTime = new DateTime(), FirstValue = -1, SecondValue = 1 },
                new() { DateTime = new DateTime(), FirstValue = 2, SecondValue = 1 },
                new() { DateTime = new DateTime(), FirstValue = -2, SecondValue = 1 },
                new() { DateTime = new DateTime(), FirstValue = 3, SecondValue = 1 },
                new() { DateTime = new DateTime(), FirstValue = -3, SecondValue = 1 }}
            };
        }
    }
}