using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DemoProject.Helpers
{
    class Authorization
    {
        public static Account AuthorizedAccount { get; set; }

        private List<Account> Accounts { get; set; }

        public Authorization()
        {
            Accounts = new List<Account>() { new Account() { accountType = Enums.AccountType.Logist, login = "logist", password = "123" } };
        }

        public Account Authorize(string login, string password)
        {
            Account account = Accounts.FirstOrDefault(acc => acc.login == login && acc.password == password);
            AuthorizedAccount = account;
            return account;
        }
    }
}
