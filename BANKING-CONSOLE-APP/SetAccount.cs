using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANKING_CONSOLE_APP
{
    public class SetAccount
    {
        private string FullName;

        public void SetAccountFunc()
        {
            string Acct = "";
            Console.WriteLine("Enter an account type: \n1.  Current\n2.  Savings");
            string option = Console.ReadLine();

            if (option == "1")
            {
                Acct = "current";


                Random random = new Random();
                var i = random.Next(1000000000, 2099999999);
                string accountnumber = i.ToString();
                Console.WriteLine($"Your Current Account number is: {accountnumber}");
                //Console.WriteLine(accountnumber);

                decimal accountbalance = 0;
                Console.WriteLine($"Your current account balance is: {accountbalance}");

                Console.WriteLine("Make a deposit:");
                decimal deposit = decimal.Parse(Console.ReadLine());
                accountbalance += deposit;
                Console.WriteLine($"Your initial deposit is: {deposit}");

                
                AccountInfo info = new AccountInfo(FullName, accountnumber, Acct, accountbalance);
                AccountInfo.allaccounts.Add(info);
            }

            else if (option == "2")
            {
                Acct = "savings";

                Random random = new Random();
                var i = random.Next(1000000000, 2099999999);
                string accountnumber = i.ToString();
                Console.WriteLine($"Your Current Account number is: {accountnumber}");
                //Console.WriteLine(accountnumber);

                decimal accountbalance = 0;
                Console.WriteLine($"Your account balance is: {accountbalance}");

                Console.WriteLine("Make an initial deposit:");
                decimal deposit = decimal.Parse(Console.ReadLine());
                accountbalance += deposit;
                Console.WriteLine($"Your initial deposit is: {deposit}");

                
                AccountInfo info = new AccountInfo(FullName, accountnumber, Acct, accountbalance);
                AccountInfo.allaccounts.Add(info);
            }
        }
    }
    
}
