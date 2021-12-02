using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Solid.Banker.Logging;

namespace Solid.Banker.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            var banker = new Banker(new CompoundLogger(
                new List<ILogger>
                {
                    new ScreamingLogger(new MessageBoxLogger()),
                    new ColorLogger(ConsoleColor.Yellow, new ConsoleLogger()),
                    new ConsoleLogger()
                }));

            banker.Deposit("12345", 500);
            banker.Withdraw("12345", 1000);

            Console.ReadLine();
        }
    }

    internal class ColorLogger : ILogger
    {
        private readonly ConsoleColor _consoleColor;
        private readonly ILogger _logger;

        public ColorLogger(ConsoleColor consoleColor, ILogger logger)
        {
            _consoleColor = consoleColor;
            _logger = logger;
        }

        public void Log(string message)
        {
            Console.ForegroundColor = _consoleColor;
            _logger.Log(message);
            Console.ResetColor();
        }
    }

    public class ScreamingLogger : ILogger
    {
        private readonly ILogger _logger;

        public ScreamingLogger(ILogger logger)
        {
            _logger = logger;
        }
        public void Log(string message)
        {
            message = message.ToUpper();
            _logger.Log(message);
        }
    }
    
    public class CompoundLogger : ILogger
    {
        private readonly List<ILogger> _loggers;

        public CompoundLogger(List<ILogger> loggers)
        {
            _loggers = loggers;
        }

        public void Log(string message)
        {
            foreach (var logger in _loggers)
            {
                logger.Log(message);
            }
        }
    }

    internal class MessageBoxLogger : ILogger
    {
        public void Log(string message)
        {
            MessageBox.Show(message);
        }
    }

    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
