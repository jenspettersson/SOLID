using Solid.ShapeAreaPrinter.Shapes;
using Xunit;

namespace Solid.ShapeAreaPrinter.Tests.ShapesTests
{
    public class SquareTests
    {
        [Fact]
        public void Area_should_be_side_length_times_two()
        {
            var square = new Square {SideLength = 5};
            var area = square.GetArea();

            Assert.Equal(25, area);
        }
    }
}