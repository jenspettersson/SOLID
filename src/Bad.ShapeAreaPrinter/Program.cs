namespace Bad.ShapeAreaPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            var printer = new ShapePrinter();

            var badRectangle = new Rectangle {Height = 10, Length = 20};

            printer.PrintShapeArea(badRectangle);

        }
    }
}
