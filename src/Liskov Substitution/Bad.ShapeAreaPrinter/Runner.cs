using NUnit.Framework;

namespace Bad.ShapeAreaPrinter
{
    [TestFixture, Explicit]
    public class Runner
    {
        [Test]
        public void Run_BadShapePrinter_Example()
        {
            var badPrinter = new ShapePrinter();

            var rectangle = new Rectangle { Height = 10, Length = 20 };
            var circle = new Circle { Radius = 5 };

            badPrinter.PrintShapeArea(rectangle);
            badPrinter.PrintShapeArea(circle);
        }
    }
}