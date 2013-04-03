using System;

namespace Solid.LiskovSubstitutionPrinciple
{
    public class ShapePrinter
    {
        public void PrintShapeArea(Shape shape)
        {
            Console.WriteLine("Area is: {0}", shape.GetArea());
        }
    }
}