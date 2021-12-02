using System;
using System.Collections.Generic;
using System.Linq;
using Solid.Banker.Logging;

namespace Solid.Banker
{
    public class Banker
    {
        private readonly ILogger _logger;
        private readonly List<Account> _accounts;

        public Banker(ILogger logger)
        {
            _logger = logger;

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

            Log($"Depositing {amount} to account {account.SocialSecurityNumber}");
        }

        public void Withdraw(string socialSecurityNumber, decimal amount)
        {
            var account = GetAccount(socialSecurityNumber);
            account.Withdraw(amount);

            Log($"Withdrawing {amount} from account {account.SocialSecurityNumber}");
        }

        private Account GetAccount(string socialSecurityNumber)
        {
            Log($"Trying to find account by SSC: {socialSecurityNumber}");
            var account = _accounts.FirstOrDefault(x => x.SocialSecurityNumber == socialSecurityNumber);

            return account;
        }

        private void Log(string message)
        {
            _logger.Log(message);
        }
    }
}