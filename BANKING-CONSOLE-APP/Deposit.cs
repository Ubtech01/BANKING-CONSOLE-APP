using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANKING_CONSOLE_APP
{
    internal class Deposit
    {
        public void DepositFunc() 
        {
             string AcctNumber;
             Console.WriteLine("Please Enter Your Account Number");
             AcctNumber = Console.ReadLine();

             Console.WriteLine("Enter the amount to deposit");
             decimal deposit = Decimal.Parse(Console.ReadLine());

             foreach (AccountInfo account in AccountInfo.allaccounts)
             {
                 if (AcctNumber == account.AccountNumber)
                {
                   deposit += account.AccountsBalance;
                   Console.WriteLine($"Your account balance for {AcctNumber} is {deposit}");
                }
             }
        }
    }
}
