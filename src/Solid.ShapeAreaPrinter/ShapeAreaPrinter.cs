namespace Solid.ShapeAreaPrinter
{
    using System;
    using Shapes;

    public class ShapeAreaPrinter
    {
        public void PrintShapeArea(Shape shape)
        {
            Console.WriteLine("Area is: {0}", shape.GetArea());
        }
    }
}