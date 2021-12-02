using System;

namespace Bad.Banker
{
    class Program
    {
        static void Main(string[] args)
        {
            var banker = new Banker(true, true, false);

            banker.Deposit("12345", 500);
            banker.Withdraw("12345", 1500);

            Console.ReadLine();
        }
    }
}
