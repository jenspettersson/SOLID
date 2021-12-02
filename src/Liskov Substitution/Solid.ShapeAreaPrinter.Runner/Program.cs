
using Solid.ShapeAreaPrinter.Shapes;

namespace Solid.ShapeAreaPrinter.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapeAreaPrinter = new ShapeAreaPrinter();
            var square = new Square { SideLength = 5 };

            var triangle = new Triangle { Base = 10, Height = 2 };
            
            shapeAreaPrinter.PrintShapeArea(square);
            shapeAreaPrinter.PrintShapeArea(triangle);
        }
    }

    public class Triangle : Shape
    {
        public int Height { get; set; }
        public int Base { get; set; }
        public override double GetArea()
        {
            return (Height * Base) / 2;
        }
    }
}
