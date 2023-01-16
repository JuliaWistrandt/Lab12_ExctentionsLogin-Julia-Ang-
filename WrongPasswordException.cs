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
        public WrongPasswordException(): base() 
        { 

        }

        public WrongPasswordException(string message): base(message) 
        {
        
        }

    }
   
}




