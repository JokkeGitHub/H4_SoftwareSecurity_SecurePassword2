using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4_SoftwareSecurity_SecurePassword2
{
    internal class PasswordChecker
    {
        public static bool Validate(string username, string password)
        {
            bool validatedPassword = false;

            byte[] encodedPassword = Encoding.UTF8.GetBytes(password);
            byte[] salt = DatabaseConnection.GetSalt(username);
            byte[] hash = DatabaseConnection.GetHash(username);

            byte[] tempHash = Hash.HashPassword(encodedPassword, salt);

            if (Convert.ToBase64String(tempHash) == Convert.ToBase64String(hash))
            {
                validatedPassword = true;
            }
            return validatedPassword;
        }
    }
}
