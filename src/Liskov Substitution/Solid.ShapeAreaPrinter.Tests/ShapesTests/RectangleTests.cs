using Solid.ShapeAreaPrinter.Shapes;
using Xunit;

namespace Solid.ShapeAreaPrinter.Tests.ShapesTests
{
    public class RectangleTests
    {
        [Fact]
        public void Area_should_be_height_times_length()
        {
            var rectangle = new Rectangle {Height = 10, Length = 5};
            var area = rectangle.GetArea();

            Assert.Equal(50, area);
        }
    }
}