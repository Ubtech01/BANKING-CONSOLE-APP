using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANKING_CONSOLE_APP
{
    internal class CustomerInfo
    {
        public static List<CustomerInfo> allcustomers = new List<CustomerInfo>();

        

        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public CustomerInfo(string fullName, string email, string password) 
        {
            this.FullName = fullName;
            this.Email = email;
            this.Password = password;
        }
    }
}
