using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANKING_CONSOLE_APP
{
    internal class Balance
    {
        public void checkBalance()
        {
            string AcctNumber = "";

            Console.WriteLine($"Please Enter your Account Number");
            AcctNumber = Console.ReadLine();

            foreach (AccountInfo account in AccountInfo.allaccounts)
            {
                if (account.AccountNumber == AcctNumber)
                {
                    Console.WriteLine($"Your balance for account number {AcctNumber} is {account.AccountsBalance}");
                }
            }
        }
    }
}

