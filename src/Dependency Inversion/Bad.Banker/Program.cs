namespace Bad.Banker
{
    using System;

    class Program
    {
        static void Main()
        {
            var banker = new Banker();

            banker.Deposit("12345", 500);
            banker.Withdraw("12345", 1500);

            Console.ReadLine();
        }
    }
}
