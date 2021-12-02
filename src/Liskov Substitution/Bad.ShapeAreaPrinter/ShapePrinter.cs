namespace Bad.ShapeAreaPrinter
{
    using System;

    public class ShapePrinter
    {
        public void PrintShapeArea(Shape shape)
        {
            double area = 0;

            if (shape is Square)
                area = GetSquareArea((Square) shape);
            if (shape is Circle)
                area = GetCircleArea((Circle) shape);
            if (shape is Rectangle)
                area = GetRectangleArea((Rectangle) shape);
            if (shape is Triangle) 
                area = GetTriangleArea((Triangle)shape);

            Console.WriteLine("Area is: {0}", area);
        }

        private double GetTriangleArea(Triangle shape)
        {
            return (shape.Base * shape.Height) / 2;
        }

        private double GetRectangleArea(Rectangle rectangle)
        {
            return rectangle.Height * rectangle.Length;
        }

        private double GetCircleArea(Circle circle)
        {
            return Math.PI * circle.Radius * circle.Radius;
        }

        private double GetSquareArea(Square square)
        {
            return square.SideLength * square.SideLength;
        }
    }
}