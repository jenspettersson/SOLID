namespace Solid.Banker
{
    public class Account
    {
        public string SocialSecurityNumber { get; private set; }

        public decimal Amount { get; private set; }

        public Account(string ssc)
        {
            SocialSecurityNumber = ssc;
        }

        public void Withdraw(decimal amount)
        {
            Amount -= amount;
        }

        public void Deposit(decimal amount)
        {
            Amount += amount;
        }
    }
}