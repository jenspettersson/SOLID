using System;

namespace Solid.LiskovSubstitutionPrinciple
{
    public abstract class Shape
    {
        public abstract void Draw();

        public abstract double GetArea();
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override void Draw()
        {
            Console.WriteLine("Drawing the circle with a radius of {0}", Radius);
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Square : Shape
    {
        public double SideLength { get; set; }

        public override void Draw()
        {
            Console.WriteLine("Drawing the shape with a side length of {0}", SideLength);
        }

        public override double GetArea()
        {
            return SideLength * SideLength;
        }
    }

    public class Rectangle : Shape
    {
        public int Height { get; set; }
        public int Length { get; set; }

        public override void Draw()
        {
            
        }

        public override double GetArea()
        {
            return Height * Length;
        }
    }
}