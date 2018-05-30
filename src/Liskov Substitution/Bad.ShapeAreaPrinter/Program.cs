namespace Bad.ShapeAreaPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            var badPrinter = new ShapePrinter();

            var rectangle = new Rectangle { Height = 10, Length = 20 };
            var circle = new Circle { Radius = 5 };

            badPrinter.PrintShapeArea(rectangle);
            badPrinter.PrintShapeArea(circle);
        }
    }
}
