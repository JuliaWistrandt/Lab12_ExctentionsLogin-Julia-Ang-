using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPasswordException
{
    internal class UsersForTest
    {
        public List<Log_In> usersList = new List<Log_In>();

        public void AddUser(string login, string password, string confirmPassword)
        {
            usersList.Add(new Log_In(login, password, confirmPassword));
        }
    }
}
