using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    internal class Program
    {

        class Bank
        {
            public int balance = 1000;

            public void check_balance()
            {
                Console.WriteLine("Your balance is: "+balance);
            }

            public void deposit(int amount)
            {
                if (amount > 0)
                {
                    balance += amount;
                    Console.WriteLine("Your amount is: " + amount);
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }

            public void withdraw(int amount)
            {
                if (amount>0 && amount <= balance)
                {
                    balance-= amount;
                    Console.WriteLine("Your amount is: "+amount);
                }
                else
                {
                    Console.WriteLine("Invalid amount");
                }
            }
        }
        static void Main(string[] args)
        {
            Bank b1=new Bank();
            while (true)
            {
                Console.WriteLine("1.Check balance");
                Console.WriteLine("2.Deposit");
                Console.WriteLine("3.Withdraw");
                Console.WriteLine("4.Exit");

                Console.WriteLine("Enter your choice");
                int Choice=int.Parse(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                        b1.check_balance();
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.WriteLine("Enter the amount");
                        int dep;
                        if (int.TryParse(Console.ReadLine(), out dep))
                        {
                            b1.deposit(dep);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input");
                        }
                        b1.check_balance();
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.WriteLine("Enter the amount");
                        int withdrw;
                        if (int.TryParse(Console.ReadLine(), out withdrw))
                        {
                            b1.withdraw(withdrw);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input");
                        }
                        b1.check_balance();
                        Console.WriteLine();
                        break;

                    case 4:
                        Console.WriteLine("Thank you");
                        return;

                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
        }
    }
}
