using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace DemoProject.Helpers
{
    /// <summary>
    /// Account authorization
    /// </summary>
    class Authorization
    {
        /// <summary>
        /// Handles authorized account
        /// </summary>
        public static Account AuthorizedAccount { get; set; }

        /// <summary>
        /// List of accounts
        /// </summary>
        private AccountArray Accounts { get; set; }

        /// <summary>
        /// Default constructor for <see cref="Authorization"/>
        /// </summary>
        public Authorization()
        {
            LoadAccountArray("accounts.xml");
        }

        /// <summary>
        /// Loads accounts from file
        /// <paramref name="filename"/>
        /// </summary>
        /// <param name="filename">Serialized account array filename</param>
        private void LoadAccountArray(string filename)
        {
            if (File.Exists(filename))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(AccountArray));
                TextReader reader = new StreamReader(filename);
                Accounts = (AccountArray)serializer.Deserialize(reader);
                reader.Close();
            }
            else
            {
                Accounts = new AccountArray() { accounts = new List<Account>() };
            }
        }

        /// <summary>
        /// Authorize method
        /// </summary>
        /// <param name="login">Account login</param>
        /// <param name="password">Account password</param>
        /// <returns>Account or null if not match</returns>
        public Account Authorize(string login, string password)
        {
            Account account = Accounts.accounts.FirstOrDefault(acc => acc.login == login && acc.password == password);
            AuthorizedAccount = account;
            return account;
        }

        /// <summary>
        /// Account creation method
        /// </summary>
        /// <param name="login">Account login</param>
        /// <param name="password">Account password</param>
        public void CreateAccount(string login, string password)
        {
            Accounts.accounts.Add(new Account() { login = login, password = password });

            XmlSerializer serializer = new XmlSerializer(typeof(AccountArray));
            TextWriter writer = new StreamWriter("accounts.xml");
            serializer.Serialize(writer, Accounts);
            writer.Flush();
            writer.Close();
        }
    }
}
