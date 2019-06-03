using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Helpers.Cryptography
{
    class Hashes
    {
        public string GenerateSalt()
        {
            byte[] buffer = new byte[64];
            new Random().NextBytes(buffer);
            return Encoding.Unicode.GetString(buffer);
        }
    }
}
