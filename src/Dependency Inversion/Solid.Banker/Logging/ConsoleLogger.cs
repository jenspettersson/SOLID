namespace Solid.Banker.Logging
{
    using System;

    public class ConsoleLogger : ILogger
    {
        public void Log(string message, params object[] param)
        {
            Console.WriteLine(message, param);
        }
    }
}