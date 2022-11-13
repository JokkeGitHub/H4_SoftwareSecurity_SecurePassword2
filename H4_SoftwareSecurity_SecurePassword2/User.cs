using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4_SoftwareSecurity_SecurePassword2
{
    internal class User
    {
        public string UserName { get; set; }
        public byte[] Salt { get; set; }
        public byte[] Hash { get; set; }

        public User(string userName, byte[] salt, byte[] hash)
        {
            UserName = userName;
            Salt = salt;
            Hash = hash;
        }
    }
}
