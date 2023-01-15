using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPasswordException
{
    public class Run
    {
        bool tryAgain = true;

        public void DoRun()
        {
            while (tryAgain)
            {
                try
                {
                    Console.WriteLine("Please, enter your username");
                    string username = Console.ReadLine();
                    Log_In.IsValidLogin(username);
                    Console.WriteLine("Please, enter your password");
                    string password = Console.ReadLine();
                    Console.WriteLine("Please, confirm your password");
                    string comfirmPassword = Console.ReadLine();
                    Log_In.IsValidPassword(password, comfirmPassword);

                    
                    Console.WriteLine("Congratulations! You're inlogged. Welcome to your pages!\"");

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                

                Console.WriteLine("Wanna try again? Y/N: ");
               string response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    tryAgain = true;
                }
                else
                {
                    tryAgain = false;
                }

            }
            Console.WriteLine("Hope to see you soon! Goodbye!");
            
                 
        }
    }
}