using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DemoProject.Helpers
{
    /// <summary>
    /// Account array for serialization
    /// </summary>
    [XmlRoot("AccountArray")]
    public class AccountArray
    {
        /// <summary>
        /// List of accounts
        /// </summary>
        [XmlArray("Accounts")]
        public List<Account> accounts;
    }
}
