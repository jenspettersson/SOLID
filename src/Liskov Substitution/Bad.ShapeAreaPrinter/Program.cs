namespace Bad.ShapeAreaPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            var badPrinter = new ShapePrinter();

            var rectangle = new Rectangle { Height = 10, Length = 20 };
            var circle = new Circle { Radius = 5 };
            var triangle = new Triangle { Height = 2, Base = 10 };

            badPrinter.PrintShapeArea(rectangle);
            badPrinter.PrintShapeArea(circle);
            badPrinter.PrintShapeArea(triangle);
        }
    }

    public class Triangle : Shape
    {
        public int Base { get; set; }
        public int Height { get; set; }
    }
}
