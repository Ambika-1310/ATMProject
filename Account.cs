using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Account
    {
        List<Account> accounts=new List<Account>();
        public int accNo { get; set; }
        public string accHolderName { get; set; }
        public int pin { get; set; }
        public double balance { get; set; }

        public void AccountDetails()
        {
            Account acc = new Account();
            Console.WriteLine("Enter the account number: ");
            acc.accNo=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the account holder name:");
            acc.accHolderName=Console.ReadLine();

            Console.WriteLine("Enter the Pin: ");
            acc.pin=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the balance: ");
            acc.balance=Convert.ToDouble(Console.ReadLine());
            
            accounts.Add(acc);

        }
        public List<Account> GetAccounts()
        {
            return accounts;
        }
    }
    
}
