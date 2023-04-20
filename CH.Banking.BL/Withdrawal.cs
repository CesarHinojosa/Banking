using CH.Banking.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CH.Banking.BL
{
    public class Withdrawal
    {
        public int ID { get; set; }

        public double Amount { get; set; }

        public DateTime Date { get; set; }

        //created constructor in order to be able to save the financial info

        public Withdrawal() { }
        public Withdrawal(int id, double amount, DateTime date)
        {
            ID = id;
            Amount = amount;
            Date = date;
        }


        public Withdrawal(DataRow withdrawlRow)
        {
            ID = Convert.ToInt32(withdrawlRow["ID"]);
            Amount = Convert.ToDouble(withdrawlRow["Amount"])!;
            Date = Convert.ToDateTime(withdrawlRow["Date"])!;
            //the one in quotation is the one pulling into the database 
            
        }



        //Vehicle has a forign key 
        //doesn't include ownerID
        
    }
}
