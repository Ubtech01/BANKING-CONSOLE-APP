using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANKING_CONSOLE_APP
{
    internal class AccountInfo
    {

        public static List<AccountInfo> allaccounts = new List<AccountInfo>();

        public string FullName { get; set; }
        public string AccountNumber { get; set; }
        public string Accounttype { get; set; }
        public decimal AccountsBalance { get; set; }

        public decimal StatementOfAccount { get; set; }
     

        public AccountInfo(string fullName, string accountNumber, string accountType, decimal accountBalance ) 
        { 
           this.FullName = fullName;
           this.AccountNumber = accountNumber;
           this.Accounttype = accountType;
           this.AccountsBalance = accountBalance;
            this.StatementOfAccount = StatementOfAccount;
        }
    }
}
