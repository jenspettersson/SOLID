namespace Solid.ShapeAreaPrinter.Shapes
{
    using System;

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}