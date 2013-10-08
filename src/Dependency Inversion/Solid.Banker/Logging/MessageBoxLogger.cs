namespace Solid.Banker.Logging
{
    using System.Windows.Forms;

    public class MessageBoxLogger : ILogger
    {
        public void Log(string message, params object[] param)
        {
            MessageBox.Show(string.Format(message, param));
        }
    }
}