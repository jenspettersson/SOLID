using Solid.Banker.Logging;

namespace Solid.Banker.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            var banker = new Banker(new ConsoleLogger());

            banker.Deposit("12345", 500);
        }
    }
}
