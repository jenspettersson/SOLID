using System;

namespace Solid.LiskovSubstitutionPrinciple
{
    public class BadShapePrinter
    {
        public void PrintShapeArea(BadShape badShape)
        {
            double area = 0;

            if (badShape is BadSquare)
                area = GetSquareArea((BadSquare) badShape);
            if (badShape is BadCircle)
                area = GetCircleArea((BadCircle) badShape);
            if (badShape is BadRectangle)
                area = GetRectangleArea((BadRectangle) badShape);

            Console.WriteLine("Area is: {0}", area);
        }

        private double GetRectangleArea(BadRectangle badRectangle)
        {
            return badRectangle.Height * badRectangle.Length;
        }

        private double GetCircleArea(BadCircle badCircle)
        {
            return Math.PI * badCircle.Radius * badCircle.Radius;
        }

        private double GetSquareArea(BadSquare badSquare)
        {
            return badSquare.SideLength * badSquare.SideLength;
        }
    }
}