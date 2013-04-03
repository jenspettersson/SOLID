using NUnit.Framework;
using Solid.LiskovSubstitutionPrinciple;

namespace Solid
{
    [TestFixture]
    public class LiskovSubstitutionPrincipleRunner
    {
        [Test]
        public void BadShapePrinter()
        {
            var badShapePrinter = new BadShapePrinter();

            //BadCircle circle = new BadCircle {Radius = 15};

            //badShapePrinter.PrintShapeArea(circle);

            var badRectangle = new BadRectangle {Height = 10, Length = 5};
            badShapePrinter.PrintShapeArea(badRectangle);
        }

        [Test]
        public void GoodShapePrinter()
        {
            var shapePrinter = new ShapePrinter();

            //var circle = new Circle {Radius = 15};

            var rectangle = new Rectangle {Height = 10, Length = 5};

            shapePrinter.PrintShapeArea(rectangle);
        }
    }
}