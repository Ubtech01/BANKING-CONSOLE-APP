using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BANKING_CONSOLE_APP
{
    public class Login
    {
        public void LoginFunction()
        {

            Console.WriteLine("Enter your email");
            string emailAddress = Console.ReadLine();
            Console.WriteLine("Enter correct password");
            string password = Console.ReadLine();

            {
                if (emailAddress == emailAddress && password == password)
                {
                    Console.WriteLine("You are Logged in Successfully");
                    Dashboard dashBoard = new Dashboard();
                    dashBoard.DashBoardFunction();
                }
                else
                {
                    Console.WriteLine("Invalid Login details");
                    
                }
                Console.ReadLine();
            }
        }
    }
}
