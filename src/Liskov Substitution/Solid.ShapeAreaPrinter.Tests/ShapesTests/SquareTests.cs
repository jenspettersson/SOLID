namespace Solid.ShapeAreaPrinter.Tests.ShapesTests
{
    using NUnit.Framework;
    using Shapes;

    [TestFixture]
    public class SquareTests
    {
        [Test]
        public void Area_should_be_side_length_times_two()
        {
            var square = new Square {SideLength = 5};
            var area = square.GetArea();

            Assert.AreEqual(25, area);
        }
    }
}