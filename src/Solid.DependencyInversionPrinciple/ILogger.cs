using System;
using System.Windows.Forms;

namespace Solid.DependencyInversionPrinciple
{
    public interface ILogger
    {
        void Log(string message, params object[] param);
    }


    public class ConsoleLogger : ILogger
    {
        public void Log(string message, params object[] param)
        {
            Console.WriteLine(message, param);
        }
    }

    public class MessageBoxLogger : ILogger
    {
        public void Log(string message, params object[] param)
        {
            MessageBox.Show(string.Format(message, param));
        }
    }
}