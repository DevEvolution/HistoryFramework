using System;
using System.Xml.Serialization;

namespace DemoProject.Helpers
{
    /// <summary>
    /// Account class
    /// </summary>
    [Serializable]
    public class Account
    {
        /// <summary>
        /// Login
        /// </summary>
        [XmlElement("Login")]
        public string login;

        /// <summary>
        /// Password
        /// </summary>
        [XmlElement("Password")]
        public string password;
    }
}
