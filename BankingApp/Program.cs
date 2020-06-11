using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// This is nothing more then an application to simulate what a Banking Application would look like
namespace BankingLibrary
{
    class AccountDemo
    {
        static void Main()
        {
            Customer c1 = new Customer("Jane Doe", "1199846823");


            Customer c2 = new Customer("James Smith", "9988472949");


            SavingsAccount sa = new SavingsAccount(c1, 12001, 25000, 4.5);


            CheckingAccount ca = new CheckingAccount(c2, 10001, 75500, 5000);

            Console.WriteLine("Savings Account");


            Console.WriteLine(sa);

            Console.WriteLine("Checking Account");


            Console.WriteLine(ca);

            Console.WriteLine("Withdraw 5000, Then deposit 1500");


            sa.withdraw(5000);


            sa.deposit(1500);


            Console.WriteLine(sa);

            Console.WriteLine("Withdraw 71000, then deposit 5000");
            ca.withdraw(71000);


            ca.deposit(5000);


            Console.WriteLine(ca);


        }
    }
}