namespace Bad.Banker
{
    using System;

    public class ConsoleLogger
    {
        public void Log(string message, params object[] param)
        {
            Console.WriteLine(message, param);
        }
    }
}