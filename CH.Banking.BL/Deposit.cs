using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH.Banking.BL
{
    public class Deposit 
    {
        public int ID { get; set; }

        public double Amount { get; set; }

        public DateTime Date { get; set; }

        //created constructor in order to be able to save the financial info

        public Deposit() { }
        public Deposit(int id, double amount, DateTime date)
        {
            ID = id;
            Amount = amount;
            Date = date;
        }
    }
}
