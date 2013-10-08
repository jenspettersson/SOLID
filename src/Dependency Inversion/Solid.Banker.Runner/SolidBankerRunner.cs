namespace Solid.Banker.Runner
{
    using Logging;
    using NUnit.Framework;

    [TestFixture, Explicit("This is just an example runner")]
    public class SolidBankerRunner
    {
        [Test]
        public void RunBanker()
        {
            var banker = new Banker(new ConsoleLogger());

            banker.Deposit("12345", 500);
        }
    }
}
