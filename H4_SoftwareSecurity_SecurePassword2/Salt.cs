using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace H4_SoftwareSecurity_SecurePassword2
{
    internal class Salt
    {
        public const int saltSize = 32;

        public static byte[] GenerateSalt()
        {
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                byte[] randomNumber = new byte[saltSize];
                rng.GetBytes(randomNumber);

                return randomNumber;
            }
        }
    }
}
