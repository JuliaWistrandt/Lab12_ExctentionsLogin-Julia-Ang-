using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPasswordException
{
    public class IsValidLoginPassword
    {
        const int minLength = 3;
        const int maxLength = 20;


        public static bool Inspect(string username, string password, string comfirmPassword)
        {
            // Login: from 3 to 20 characters, no spaces;
            if (username.Length < minLength) throw new WrongLoginException("login must be at least 3 characters long.");

            if (username.Length > maxLength) throw new WrongLoginException("login must be max 20 characters long.");

            if (username.Contains(' ')) throw new WrongLoginException("login cannot contain spaces.");


            // Password: from 3 to 20 characters, contains at least one number, no spaces, matching with confirmPassword;
            if (password.Length < minLength) throw new WrongPasswordException("password must be at least 3 characters long.");

            if (password.Length > maxLength) throw new WrongPasswordException("password must be max 20 characters long.");

            if (!password.Any(char.IsDigit)) throw new WrongPasswordException("password must contain at least one number.");

            if (password.Contains(' ')) throw new WrongPasswordException("password cannot contain spaces.");

            if (!password.Equals(comfirmPassword)) throw new WrongPasswordException("Password does not match password confirmation.");

            return true;


            // method to validate email by @, numbers, .com etc
            //public static bool IsValidEmail(string email)
            //{
            //    Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);
            //    return emailRegex.IsMatch(email);

            //}


        }


    }
}
