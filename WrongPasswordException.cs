using LoginPasswordException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPasswordException
{
    public class WrongPasswordException : Exception
    {
        public WrongPasswordException()
            : base("Your password must be:\n* have at least 3 characters long\n* have max 20 characters long\n* contain at least one number\n* * cannot contain spaces.\n") 
        { 

        
        }

        public WrongPasswordException(string message)
            : base(message) 
        {
        
        }




    }
   
}




