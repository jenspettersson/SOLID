namespace Solid.ShapeAreaPrinter.Shapes
{
    public class Square : Shape
    {
        public double SideLength { get; set; }

        public override double GetArea()
        {
            return SideLength * SideLength;
        }
    }
}