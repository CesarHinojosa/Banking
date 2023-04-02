using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH.Banking.BL
{
    public class CustomerCollection : List<Customer>
    {
        public void LoadTestCustomers()
        {

            //can't add age because it is only a getter no setter
            Customer customer;

            customer = new Customer();
            customer.CustomerID = 1;
            customer.FirstName = "Cesar";
            customer.LastName = "Hinojosa";
            customer.SSN = "123-45-6789";
            customer.DateOfBirth = new DateTime(2004, 3, 9);

            //needed the new Datetime in order for the constructor to not think that I was adding several constructors 

            customer.Withdrawls.Add(new Withdrawal(4, 452.25, new DateTime(2022,5,10) ));
            customer.Withdrawls.Add(new Withdrawal(5, 5000, new DateTime(2023, 4, 1)));
            customer.Withdrawls.Add(new Withdrawal(6, 2351.33, new DateTime(2023, 3, 9)));

            customer.Deposit.Add(new Deposit(10, 450, new DateTime(2023, 1, 10)));
            customer.Deposit.Add(new Deposit(11, 101800.99, new DateTime(2023, 3, 8)));
            customer.Deposit.Add(new Deposit(12, 800.45, new DateTime(2023, 2, 14)));

            Add(customer);

            customer = new Customer();
            customer.CustomerID = 2;
            customer.FirstName = "Clark";
            customer.LastName = "Kent";
            customer.SSN = "987-65-4321";
            customer.DateOfBirth = new DateTime(1996, 4, 18);

            //needed the new Datetime in order for the constructor to not think that I was adding several constructors 

            customer.Withdrawls.Add(new Withdrawal(7, 980.25, new DateTime(2023, 2, 19)));
            customer.Withdrawls.Add(new Withdrawal(8, 350.25, new DateTime(2023, 2, 26)));
            customer.Withdrawls.Add(new Withdrawal(9, 100.50, new DateTime(2023, 2, 9)));

            customer.Deposit.Add(new Deposit(13, 350, new DateTime(2023, 2, 16)));
            customer.Deposit.Add(new Deposit(14, 550, new DateTime(2023, 1, 22)));
            customer.Deposit.Add(new Deposit(15, 650, new DateTime(2023, 1, 5)));

            Add(customer);

            customer = new Customer();
            customer.CustomerID = 3;
            customer.FirstName = "Bruce";
            customer.LastName = "Wayne";
            customer.SSN = "111-22-3333";
            customer.DateOfBirth = new DateTime(1998, 10, 5);

            //needed the new Datetime in order for the constructor to not think that I was adding several constructors 

            customer.Withdrawls.Add(new Withdrawal(1, 5000.45, new DateTime(2023, 3, 17)));
            customer.Withdrawls.Add(new Withdrawal(2, 8045.25, new DateTime(2023, 3, 18)));
            customer.Withdrawls.Add(new Withdrawal(3, 10250.55, new DateTime(2023, 3, 19)));

            customer.Deposit.Add(new Deposit(16, 6500, new DateTime(2023, 3,20)));
            customer.Deposit.Add(new Deposit(17, 80000, new DateTime(2023, 3, 21)));
            customer.Deposit.Add(new Deposit(18, 78000, new DateTime(2023, 3, 22)));

            Add(customer);
        }
    }
}
