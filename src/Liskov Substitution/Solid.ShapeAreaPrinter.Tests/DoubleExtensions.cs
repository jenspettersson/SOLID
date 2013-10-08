namespace Solid.ShapeAreaPrinter.Tests
{
    using System;

    public static class DoubleExtensions
    {
        public static double Decimals(this double value, int decimals)
        {
            return Math.Round(value, decimals, MidpointRounding.AwayFromZero);
        }
    }
}
