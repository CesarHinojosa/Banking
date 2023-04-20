using System;
using System.Collections.Generic;
using System.Data;
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

        public Deposit(DataRow depositRow)
        {
            ID = Convert.ToInt32(depositRow["ID"]);
            Amount = Convert.ToDouble(depositRow["Amount"])!;
            Date = Convert.ToDateTime(depositRow["Date"])!;
            //the one in quotation is the one pulling into the database 

        }
    }
}
