using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLibrary
{// This is my customer class. I built it this way so that I can reuse if necessary 
    public class Customer
    {
        public string CustomerName { get; set; }
        public string Phone { get; set; }

        public Customer(string Name, string phone)
        {
            CustomerName = Name;
            Phone = phone;
        }
        public override string ToString()
        {
            return string.Format("Customer Name: {0} Customer Phone Number: {1}",CustomerName,Phone);
        }
    }
}
