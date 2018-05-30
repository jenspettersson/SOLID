using Solid.ShapeAreaPrinter.Shapes;
using Xunit;

namespace Solid.ShapeAreaPrinter.Tests.ShapesTests
{
    public class CircleTests
    {
        [Fact]
        public void Area_should_be_pi_times_radius_squared()
        {
            var circle = new Circle {Radius = 10};
            var area = circle.GetArea();

            Assert.Equal(314.2, area.Decimals(1));
        }
    }
}