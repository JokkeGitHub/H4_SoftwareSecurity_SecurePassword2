using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace H4_SoftwareSecurity_SecurePassword2
{
    internal class UserFactory
    {
        public static User Create(string username, string password)
        {
            byte[] encodedPassword = Encoding.UTF8.GetBytes(password);
            byte[] salt = Salt.GenerateSalt();
            byte[] hash = Hash.HashPassword(encodedPassword, salt);

            User newUser = new User(username, salt, hash);

            return newUser;
        }
    }
}
