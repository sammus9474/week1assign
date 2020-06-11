using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BankingLibrary
{ //this is the base class
    public class Account
    {// Here is am setting some variables
       public int AccountNumber { get; set; }
        public double Balance { get; set; }
        public Customer Cust { get; set; }
        

        public Account (Customer cust, int AccNo, double balance)
        {
            AccountNumber = AccNo;
            Balance = balance;
            Cust = cust;
        }// Provides the Deposit and balance
        public void deposit(double amount)
        {
            Balance += amount;
        }
        public override string ToString()
        {
            return Cust.ToString()+"\nAccount Number: "+AccountNumber+"\nBalance: $ "+Balance;
        }

        //Happens when there is a Withdrawal unless there is not enough funds the displays a message
        public void withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Cannot withdraw this amount from account");
            }
        }
    }
}
