namespace Solid.LiskovSubstitutionPrinciple
{
    public class BadShape
    {

    }

    public class BadCircle : BadShape
    {
        public double Radius { get; set; }
    }

    public class BadSquare : BadShape
    {
        public double SideLength { get; set; }
    }

    public class BadRectangle : BadShape
    {
        public double Length { get; set; }
        public double Height { get; set; }
    }
}