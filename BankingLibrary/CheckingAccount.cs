using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLibrary
{//This checking class is inhariting from the Account class
    public class CheckingAccount : Account
    {
        // Implements property
        public double MinimumBalance { get; set; }

        // Constructor 
        public CheckingAccount(Customer cust, int accNo, double balance, double minBalance)
        : base(cust, accNo, balance)
        {
            MinimumBalance = minBalance;
        }

        //Now we have to do some math to get the minimum Balance so 
        // If balance - amount < minimum balance, dont make withdrawal
        // Else, subtract amount from balance or displays a message due to insufficent funds
        public void withdraw(double amount)
        {
            if (Balance - amount < MinimumBalance)
            {
                Console.WriteLine("Cannot withdraw this amount from account");
            }
            else
            {
                Balance -= amount;
            }
        }

        // This will return the minimum balance
        public override string ToString()
        {
            return base.ToString() + "\nMinimum Balance: " + MinimumBalance + "\n";
        }
    }
}

