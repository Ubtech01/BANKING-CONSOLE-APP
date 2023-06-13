using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace BANKING_CONSOLE_APP
{
    public class Menu
    {

        public void MenuFunction()
        {
            string option;
            Console.WriteLine("WELCOME TO YOUR CONSOLE BANK APP");
            Console.WriteLine("Select an option to continue");
            Console.WriteLine("1.  Register");
            Console.WriteLine("2.  Login");
            Console.WriteLine("3.  Exit");
            
          

            //CONTROL USER'S OPTION
            do
            {
                Console.WriteLine("\nPlease choose from 1 - 3");
                option = Console.ReadLine();

            } while (!Regex.IsMatch(option,@"^[1-3]$"));
            
            //TAKE USER TO THEIR SELECTED OPTION
                {
                switch(option)
                {
                    case "1":
                        var register = new Registeration();
                        register.RegisterationFunction();
                        return;
                    case "2":
                        var login = new Login();
                        login.LoginFunction();
                        return;
                         default:
                        Console.WriteLine("Thank you for banking with us");
                        System.Environment.Exit(0);
                        return;

                        
                }
            }
        }
            
    }
}
