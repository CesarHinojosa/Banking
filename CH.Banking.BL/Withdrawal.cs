using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH.Banking.BL
{
    public class Withdrawal
    {
        public int ID { get; set; }

        public double Amount { get; set; }

        public DateTime Date { get; set; }

        public Withdrawal() { }
        public Withdrawal(int id, double amount, DateTime date)
        {
            ID = id;
            Amount = amount;
            Date = date;
        }
    }
}
