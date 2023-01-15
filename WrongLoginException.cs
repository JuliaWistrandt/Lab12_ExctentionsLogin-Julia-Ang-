using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPasswordException
{
    public class WrongLoginException : Exception
    {
        public WrongLoginException() 
            : base("Your username must be:\n* between 3 and 20 characters long\n* cannot contain spaces.\n")
        {

        }
        public WrongLoginException(string message) 
            : base(message)
        {

        }
    }
}
