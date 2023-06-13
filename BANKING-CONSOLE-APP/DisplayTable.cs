using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANKING_CONSOLE_APP
{
    public class DisplayTable: Dashboard
    {
        public void DisplayAllTable()
        {
            string allPrints = " ";
            foreach (AccountInfo acc in AccountInfo.allaccounts)
            {
                allPrints += $"|     {acc.FullName,-15}|   {acc.AccountNumber,-15}|     {acc.Accounttype,-15}|      {acc.AccountsBalance,-16}|\n";
            }

            Console.WriteLine("|--------------------|------------------|--------------------|----------------------|");
            Console.WriteLine("|     FULLNAME       |  ACCOUNT NUMBER  |   ACCOUNT TYPE     |   ACCOUNT BALANCE    |");
            Console.WriteLine("|--------------------|------------------|--------------------|----------------------|");
            Console.WriteLine(allPrints);
            Console.WriteLine("|-----------------------------------------------------------------------------------|");
        }
    }
}
    

