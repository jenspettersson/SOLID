namespace Solid.ShapeAreaPrinter.Tests
{
    using NUnit.Framework;
    using Shapes;

    /// <summary>
    /// This test is only to act as a runner for the current shape area printer that just prints to Console
    /// </summary>
    [TestFixture, Explicit]
    public class ShapeAreaPrinterRunner
    {
        [Test]
        public void Run()
        {
            var shapeAreaPrinter = new ShapeAreaPrinter();
            var square = new Square {SideLength = 5};

            shapeAreaPrinter.PrintShapeArea(square);
        }
    }
}