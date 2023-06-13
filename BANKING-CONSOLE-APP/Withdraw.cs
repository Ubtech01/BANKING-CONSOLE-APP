using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANKING_CONSOLE_APP
{
    public class Withdraw
    {
        public void WithdrawFunc() 
        {
            string AcctNumber = "";
            Console.WriteLine("Please Enter your account number");
            AcctNumber = Console.ReadLine();

            Console.WriteLine("Enter the amount you want to Withdraw");
            decimal withdraw = Decimal.Parse(Console.ReadLine());

            foreach (AccountInfo account in AccountInfo.allaccounts)
            {
               if (account.AccountNumber == AcctNumber)
               {
                  account.AccountsBalance -= withdraw;
                  Console.WriteLine($"Your account balance for {AcctNumber} is {withdraw}");
               }
            }
       
        }
    }
}
