namespace Solid.ShapeAreaPrinter.Tests.ShapesTests
{
    using NUnit.Framework;
    using Shapes;

    [TestFixture]
    public class RectangleTests
    {
        [Test]
        public void Area_should_be_height_times_length()
        {
            var rectangle = new Rectangle {Height = 10, Length = 5};
            var area = rectangle.GetArea();

            Assert.AreEqual(50, area);
        }
    }
}