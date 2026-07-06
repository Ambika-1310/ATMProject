using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ATM atm = new ATM();
            if (atm.login() == true)
            {
                while (true)
                {
                    Console.WriteLine("=====ATM=====");
                    Console.WriteLine("1. check balance ");
                    Console.WriteLine("2. Deposite");
                    Console.WriteLine("3. withdrawn");
                    Console.WriteLine("4.change pin");
                    Console.WriteLine("5.exit");

                    Console.WriteLine("Enter the choice ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            atm.checkBalance();
                            break;
                        case 2:
                            atm.deposite();
                            break;
                        case 3:
                            atm.withDrawn();
                            break;
                        case 4:
                            atm.changePin();
                            break;
                        case 5:
                            return;
                    }
                }
            }

            
        }
    }
}
