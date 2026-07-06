using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class ATM
    {
        Account acc = new Account();
        public bool login()
        {
            acc.AccountDetails();

            bool found = false;
            Console.WriteLine("------To varify login account-----");
            Console.WriteLine("Enter the account number: ");
            int accountNo=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the pin:");
            int pin =Convert.ToInt32(Console.ReadLine());

            foreach (Account a in acc.GetAccounts())
            {
                if(a.accNo==accountNo && a.pin == pin)
                {
                    found = true;
                    Console.WriteLine("login Sucessfull!!");
                    return true;
                }
                else
                {
                    Console.WriteLine("invalid login");
                }
            }
            return false;
        }
        public void checkBalance()
        {
            Console.WriteLine("----check balance----");
            foreach (Account a in acc.GetAccounts())
            {
                Console.WriteLine("Balance " + a.balance);
            }
        }
        public void deposite()
        {
            Console.WriteLine("---deposite----");
            Console.WriteLine("Enter the amount to deposite");
            int dept = Convert.ToInt32(Console.ReadLine());

            foreach (Account a in acc.GetAccounts())
            {
                if (dept>0)
                {
                    a.balance += dept;
                    Console.WriteLine(" balance " + a.balance);
                }
            }

        }
        public void withDrawn()
        {
            Console.WriteLine("---withdrawn----");
            Console.WriteLine("Enter the amount to withdraw");
            int amount = Convert.ToInt32(Console.ReadLine());

            foreach (Account a in acc.GetAccounts())
            {
                if (amount < a.balance)
                {
                    a.balance -= amount;
                    Console.WriteLine("Reamaing balance " + a.balance);
                }
            }

        }
        public void changePin()
        {
            Console.WriteLine("---Change pin-----");
            Console.WriteLine("Enter the current pin ");
            int currentPin = Convert.ToInt32(Console.ReadLine());

            foreach(Account a in acc.GetAccounts())
            {
                if (a.pin == currentPin)
                {
                    Console.WriteLine("Enter the new pin ");
                    int newPin= Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the new pin once again ");
                    int newPin1= Convert.ToInt32(Console.ReadLine());


                    if(newPin == newPin1)
                    {
                        a.pin= newPin1;
                        Console.WriteLine("Changed pin "+a.pin);
                        Console.WriteLine("pin changed  successful ");

                    }

                }
            }
        }
    }
}
