namespace Solid.ShapeAreaPrinter.Tests.ShapesTests
{
    using NUnit.Framework;
    using Shapes;

    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void Area_should_be_pi_times_radius_squared()
        {
            var circle = new Circle {Radius = 10};
            var area = circle.GetArea();

            Assert.AreEqual(314.2, area.Decimals(1));
        }
    }
}