using System;

namespace Solid.DependencyInversionPrinciple
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Select {1} for ConsoleBanker and {2} for MessageBoxBanker");
            while(true)
            {
                GetInput();
            }
        }

        private static void GetInput()
        {
            ConsoleKeyInfo key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.D1:
                    ConsoleBanker();
                    break;
                case ConsoleKey.D2:
                    MessageBoxBanker();
                    break;
            }
        }

        private static void ConsoleBanker()
        {
            var banker = new Banker(new ConsoleLogger());

            banker.Deposit("12345", 500);
            banker.Withdraw("12345", 1500);
        }

        private static void MessageBoxBanker()
        {
            var banker = new Banker(new MessageBoxLogger());

            banker.Deposit("12345", 500);
            banker.Withdraw("12345", 1500);
        }
    }
}
