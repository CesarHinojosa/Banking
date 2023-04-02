using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH.Banking.BL
{
    public class Customer : Person
    {
        public int CustomerID { get; set; }

        public List<Withdrawal> Withdrawls { get; set; } = new List<Withdrawal>();

        public List<Deposit> Deposit { get; set; } = new List<Deposit>();
    }
}
