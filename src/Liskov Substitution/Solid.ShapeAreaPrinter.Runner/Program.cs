
using Solid.ShapeAreaPrinter.Shapes;

namespace Solid.ShapeAreaPrinter.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapeAreaPrinter = new ShapeAreaPrinter();
            var square = new Square { SideLength = 5 };

            shapeAreaPrinter.PrintShapeArea(square);
        }
    }
}
