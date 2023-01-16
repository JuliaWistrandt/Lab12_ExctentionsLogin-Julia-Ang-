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
        public string login;
        public string password;
        public string confirmPassword;


        public Log_In(string login, string password, string confirmPassword)
        {
            this.login = login;
            this.password = password;
            this.confirmPassword = confirmPassword;
        }

    }
}
 