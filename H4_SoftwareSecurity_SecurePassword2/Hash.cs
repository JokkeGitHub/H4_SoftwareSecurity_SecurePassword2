using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace H4_SoftwareSecurity_SecurePassword2
{
    internal class Hash
    {
        public const int hashSize = 32;
        public const int iterations = 10000;

        public static byte[] HashPassword(byte[] encodedPassword, byte[] salt)
        {
            using (Rfc2898DeriveBytes rfc2898 = new Rfc2898DeriveBytes(encodedPassword, salt, iterations))
            {
                return rfc2898.GetBytes(hashSize);
            }
        }
    }
}
