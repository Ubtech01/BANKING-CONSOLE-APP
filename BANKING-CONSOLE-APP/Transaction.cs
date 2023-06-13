using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANKING_CONSOLE_APP
{
    internal class Transaction
    {
        public void Transfer() 
        {
            string AcctNumber = "";
            decimal withdraw = 0;
            decimal transfer = 0;

            Console.WriteLine("Please Enter your account number");
            AcctNumber = Console.ReadLine();

            Console.WriteLine("Enter the amount you want to Transfer");
            withdraw = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter beneficiary account number");
            transfer = Decimal.Parse(Console.ReadLine());

            foreach (AccountInfo account in AccountInfo.allaccounts)
            {

                if (account.AccountNumber == AcctNumber && withdraw <= account.AccountsBalance)

                {

                    account.AccountsBalance -= withdraw;

                }
                else if (account.AccountNumber == AcctNumber)

                {

                    account.AccountNumber += transfer;

                }
            }
        }
    }
}
