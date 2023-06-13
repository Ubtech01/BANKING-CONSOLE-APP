using BANKING_CONSOLE_APP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BANKING_CONSOLE_APP
{
    public class Registeration
    {
     

        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        

        public void RegisterationFunction()
        {

            Console.WriteLine("\nKindly input your registeration details");


            Console.Write("Enter your Fullname:\t");
            string fullName = Console.ReadLine()!;


            bool isValidEmail = false;

            while (!isValidEmail)
            {
                Console.Clear();
                Console.Write("Enter your email address:\t ");
                string email = Console.ReadLine()!;
                Email = email;
               

                if (IsValidEmail(email))
                {
                    isValidEmail = true;
                }
                else
                {
                    Console.Write("Invalid email. Please try again.");
                }

            }
            Console.Write("Enter your password:\t");
            string password = Console.ReadLine()!;
            

            CustomerInfo info = new CustomerInfo(fullName, Email, password);
            CustomerInfo.allcustomers.Add(info);

            Console.WriteLine("**********Registeration successfull********\n");

            Login log = new Login();
            log.LoginFunction();
        }

    

        private static bool IsValidEmail(string email)
        {

            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return Regex.IsMatch(email, pattern);
        }
    }
}
