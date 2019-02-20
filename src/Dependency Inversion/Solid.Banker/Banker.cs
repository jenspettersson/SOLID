using System.Collections.Generic;
using System.Linq;

namespace Solid.Banker
{
    public class Banker
    {
        private readonly List<Account> _accounts;

        public Banker()
        {
            #region Persistance stuff

            var accountOne = new Account("12345");
            accountOne.Deposit(1000);

            var accountTwo = new Account("54321");
            accountTwo.Deposit(5000);

            _accounts = new List<Account>
                {
                    accountOne,
                    accountTwo
                };

            #endregion
        }


        public void Deposit(string socialSecurityNumber, decimal amount)
        {
            Account account = GetAccount(socialSecurityNumber);

            account.Deposit(amount);

            Log("Depositing {0} to account {1}", amount, account.SocialSecurityNumber);
        }

        public void Withdraw(string socialSecurityNumber, decimal amount)
        {
            var account = GetAccount(socialSecurityNumber);
            account.Withdraw(amount);

            Log("Withdrawing {0} from account {1}", amount, account.SocialSecurityNumber);
        }

        private Account GetAccount(string socialSecurityNumber)
        {
            Log("Trying to find account by SSC: {0}", socialSecurityNumber);
            var account = _accounts.FirstOrDefault(x => x.SocialSecurityNumber == socialSecurityNumber);

            return account;
        }

        private void Log(string message, params object[] param)
        {
            //Todo: Implement SOLID logging
        }
    }
}