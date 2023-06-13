using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BANKING_CONSOLE_APP
{
    public class Dashboard : Login
    {
        private string fullName = "";

        public void DashBoardFunction()
        {
            string option;
            Console.WriteLine("Welcome to your DashBoard\n");
            Console.WriteLine("Please select an option");
            Console.WriteLine("1. Setup Account\n2. Check Balance\n3. Deposit\n4. Withdraw\n5. Account Details\n6. Account Statement\n7. Transfer\n8. Logout\n");
            Console.WriteLine(" ");
            option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    SetAccount set = new SetAccount();
                    set.SetAccountFunc();
                    DashBoardFunction();
                    break;
                case "2":
                    Balance balance = new Balance();
                    balance.checkBalance();
                    DashBoardFunction();
                    break;
                case "3":
                    Deposit deposit = new Deposit();
                    deposit.DepositFunc();
                    DashBoardFunction();
                    break;
                case "4":
                    Withdraw withdraw = new Withdraw();
                    withdraw.WithdrawFunc();
                    DashBoardFunction();
                    break;
                case "5":
                    Console.WriteLine("Below is your account details");
                    DisplayTable display = new DisplayTable();
                    display.DisplayAllTable();
                    break;
                case "6":
                    Console.WriteLine("Below is your account details");
                    break;
                case "7":
                    Transaction transaction = new Transaction();    
                    transaction.Transfer();
                    DashBoardFunction();
                    break;
                case "8":
                    Logout log = new Logout();
                    log.LogoutFunc();   
                    DashBoardFunction();
                    break;
            }
        }

    }
}
   




