using TekTon.Exam.API;
using Xunit;

namespace Tekton.Exam.API.Test
{
    public class ContainerTests
    {
        [Theory,
            InlineData(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49),
            InlineData(new int[] { 1, 1 }, 1),
            InlineData(new int[] { 4, 3, 2, 1, 4 }, 16),
            InlineData(new int[] { 1, 2, 1 }, 2)]
        internal void MaxArea_Returns_Expected(int[] linesHeight, int expected)
        {
            // Act 
            var container = new Container();
            var maxArea = container.MaxArea(linesHeight);
            // Assert
            Assert.Equal(expected, maxArea);
        }
    }
}
