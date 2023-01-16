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
            //option one: test manually 
            var database =  new DataBaseList();
            AddUsers(database);

            foreach (var user in database.usersList)
            {
                try
                {
                    Console.Write($"{user.login}\t{user.password}\t{user.confirmPassword}");
                    IsValidLoginPassword.Inspect(user.login, user.password, user.confirmPassword);
                    Console.WriteLine("\tallowed");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\t" + ex.Message);
                }

            }


            // option two: test with user input
            while (tryAgain)
            {
                try
                {
                    Console.WriteLine("\nYour username must be:\n* between 3 and 20 characters long\n* cannot contain spaces.\n");
                    Console.WriteLine("Please, enter your username");
                    string username = Console.ReadLine();

                    Console.WriteLine("Your password must be:\n* have at least 3 characters long\n* have max 20 characters long\n* contain at least one number\n* * cannot contain spaces.\n");
                    Console.WriteLine("Please, enter your password");
                    string password = Console.ReadLine();
                    Console.WriteLine("Please, confirm your password");
                    string comfirmPassword = Console.ReadLine();
                    IsValidLoginPassword.Inspect(username, password, comfirmPassword);

                    Console.WriteLine("Congratulations! You're inlogged. Welcome to your pages!\"");

                }
                catch (Exception ex)
                {

                    Console.WriteLine("\n" + ex.Message);
                }


                Console.WriteLine("Want to exit the program? Y/N: ");
                string response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y") tryAgain = false;


            }

            Console.WriteLine("Hope to see you soon! Goodbye!");



        }

        static void AddUsers(DataBaseList database)
        {
            database.AddUser(" Urt", "wer2", "wer2"); // empty space in login
            database.AddUser("Uu", "Wrt", "Wrt"); // login is too short 
            database.AddUser("123456789101112131411", "Wrt", "Wrt"); // login is too long

            database.AddUser("Uuu", "W rt", "Wrt"); // password contains empty spaces
            database.AddUser("Uuu", "123456789101112131411", "Wrt"); // password is too long
            database.AddUser("Uuu", "Wrt", "Wrt2"); // password and confirmation password are different
            database.AddUser("Uuu", "Wrt", "Wrt"); // password contains no numbers 
            database.AddUser("Uuu", "Wrt", "Wrt2"); // password and confirmation password are different 

        }


    }
}