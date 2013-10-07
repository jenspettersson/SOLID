namespace Solid.ShapeAreaPrinter.Shapes
{
    public class Rectangle : Shape
    {
        public int Height { get; set; }
        public int Length { get; set; }

        public override double GetArea()
        {
            return Height * Length;
        }
    }
}