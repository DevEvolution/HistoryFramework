using demo.mdi.ais.Helpers.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.mdi.ais.Helpers
{
    class Authorization
    {
        public static Account AuthorizedAccount { get; set; }

        private List<Account> Accounts { get; set; }

        public Authorization()
        {
            Accounts = JsonConvert.DeserializeObject<List<Account>>(File.ReadAllText("accounts.json"));
        }

        public Account Authorize(string login, string password)
        {
            Account account = Accounts.FirstOrDefault(acc => acc.login == login && acc.password == password);
            AuthorizedAccount = account;
            return account;
        }
    }
}
