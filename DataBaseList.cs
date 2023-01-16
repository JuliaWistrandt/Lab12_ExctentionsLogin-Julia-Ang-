using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace LoginPasswordException
{
    public class DataBaseList
    {
        public List<Log_In> usersList = new List<Log_In>();

        public void AddUser(string login, string password, string confirmPassword)
        {
            usersList.Add(new Log_In(login, password, confirmPassword));
        }


    }
}
