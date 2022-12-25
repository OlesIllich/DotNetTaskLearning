using AutoFixture.Xunit2;
using DotNetLearning.TuplesTasks;
using FluentAssertions;
using Xunit;

namespace DotNetLearningTest
{
    public class TuplesTasksTest
    {
        private readonly TuplesTasks _task;

        public TuplesTasksTest()
        {
            _task = new TuplesTasks();
        }

        [Theory]
        [AutoData]
        public void GetTupleTest(string str, int i, bool b)
        {
            // Arrange
            // Act
            var result = _task.GetTuple(str, i, b);

            // Assert
            result.String.Should().Be(str);
            result.Bool.Should().Be(b);
            result.Number.Should().Be(i);
        }


        [Theory]
        [AutoData]
        public void GeStringPartTest(string str, int i, bool b)
        {
            // Arrange
            // Act
            var result = _task.GeStringPart(new Tuple<string, int, bool>(str, i, b));

            // Assert
            result.Should().Be(str);
        }

        [Theory]
        [AutoData]
        public void GetIntPartTest(string str, int i, bool b)
        {
            // Arrange
            // Act
            var result = _task.GetIntPart(new Tuple<string, int, bool>(str, i, b));

            // Assert
            result.Should().Be(i);
        }

        [Theory]
        [AutoData]
        public void GeBoolPartTest(string str, int i, bool b)
        {
            // Arrange
            // Act
            var result = _task.GetBoolPart(new Tuple<string, int, bool>(str, i, b));

            // Assert
            result.Should().Be(b);
        }

}
}
