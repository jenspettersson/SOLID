namespace Solid.Banker.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            var banker = new Banker();

            banker.Deposit("12345", 500);
        }
    }
}
