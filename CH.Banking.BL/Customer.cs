using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH.Banking.BL
{

    //Customer dervies from person
    //aka gets all the things a person has
    public class Customer : Person
    {
        public int CustomerID { get; set; }

        //added this here because each customer has withdrawals and deposits

        //but not ever person has them 

        public List<Withdrawal> Withdrawals { get; set; } = new List<Withdrawal>();

        public List<Deposit> Deposit { get; set; } = new List<Deposit>();
    }
}
