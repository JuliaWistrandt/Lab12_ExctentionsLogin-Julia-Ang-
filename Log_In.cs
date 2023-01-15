using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LoginPasswordException
{
    public class Log_In
    {
        string username;
        string password;
        string comfirmPassword;
        //string email;
        const int minLength = 3;
        const int maxLength = 20;

        public Log_In(string username, string password, string comfirmPassword)
        {
            this.username = username;
            this.password = password;
            this.comfirmPassword = comfirmPassword;
            
        }

        // from 3 to 20 characters, not empty 
        public static bool IsValidLogin(string username)
        {
            if(username.Length < minLength || username.Length > maxLength || string.IsNullOrWhiteSpace(username)) throw new WrongLoginException();
            return false;
        }


        // from 3 to 20 characters, contains at least one number, not empty, matching with confirmPassword
        public static bool IsValidPassword(string password, string comfirmPassword)
        {

            if (!password.Equals(comfirmPassword)) throw new WrongPasswordException("Password does not match password confirmation.");
                
            if (password.Length < minLength || password.Length > maxLength || string.IsNullOrWhiteSpace(password) || !password.Any(char.IsDigit)) throw new WrongPasswordException();

            return false;

        }



        // method to validate email by @, numbers, .com etc
        //public static bool IsValidEmail(string email)
        //{
        //    Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);
        //    return emailRegex.IsMatch(email);

        //}




    }
}

// källor:
// https://www.youtube.com/watch?v=JTMdCC5FY34 