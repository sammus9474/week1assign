using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BankingLibrary
{//This savings class is inhariting from the Account class 
    public class SavingsAccount : Account
    {

        // Implements property 
        public double InterestRate { get; set; }

        // Constructor 
        public SavingsAccount(Customer cust, int accNo, double balance, double rate)
        : base(cust, accNo, balance)
        {
            InterestRate = rate;
        }

        // Return string which contains interest rate balance 
        public override string ToString()
        {
            return base.ToString() + "\nInterest Rate: " + InterestRate + "%\n";
        }
    }
}

