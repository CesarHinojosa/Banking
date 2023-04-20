using CH.Banking.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH.Banking.BL
{
    //Without List<Customer>We cannot "save" the records or add new customers
    public class CustomerCollection : List<Customer>
    {
        //Creating the xml file name
        public CustomerCollection() 
        {
            DataAccess.XMLFilePath = "customers.xml";
            DataAccess.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CH.Banking;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        
        public void LoadTestCustomers()
        {

            //can't add age because it is only a getter no setter

            //customer objects down below
            Customer customer;

            customer = new Customer();

           

            customer.FirstName = "Cesar";
            customer.LastName = "Hinojosa";
            customer.SSN = "123-45-6789";
            customer.DateOfBirth = new DateTime(2004, 3, 9);

            //needed the new Datetime in order for the constructor to not think that I was adding several constructors 

            customer.Withdrawals.Add(new Withdrawal(4, 452.25, new DateTime(2022, 5, 10)));
            customer.Withdrawals.Add(new Withdrawal(5, 5000, new DateTime(2023, 4, 1)));
            customer.Withdrawals.Add(new Withdrawal(6, 2351.33, new DateTime(2023, 3, 9)));

            customer.Deposit.Add(new Deposit(10, 450, new DateTime(2023, 1, 10)));
            customer.Deposit.Add(new Deposit(11, 101800.99, new DateTime(2023, 3, 8)));
            customer.Deposit.Add(new Deposit(12, 800.45, new DateTime(2023, 2, 14)));

            Add(customer);

            customer = new Customer();

            
            customer.FirstName = "Clark";
            customer.LastName = "Kent";
            customer.SSN = "987-65-4321";
            customer.DateOfBirth = new DateTime(1996, 4, 18);

            //needed the new Datetime in order for the constructor to not think that I was adding several constructors 

            customer.Withdrawals.Add(new Withdrawal(7, 980.25, new DateTime(2023, 2, 19)));
            customer.Withdrawals.Add(new Withdrawal(8, 350.25, new DateTime(2023, 2, 26)));
            customer.Withdrawals.Add(new Withdrawal(9, 100.50, new DateTime(2023, 2, 9)));

            customer.Deposit.Add(new Deposit(13, 350, new DateTime(2023, 2, 16)));
            customer.Deposit.Add(new Deposit(14, 550, new DateTime(2023, 1, 22)));
            customer.Deposit.Add(new Deposit(15, 650, new DateTime(2023, 1, 5)));

            Add(customer);

            customer = new Customer();


            
            customer.FirstName = "Bruce";
            customer.LastName = "Wayne";
            customer.SSN = "111-22-3333";
            customer.DateOfBirth = new DateTime(1998, 10, 5);

            //needed the new Datetime in order for the constructor to not think that I was adding several constructors 

            customer.Withdrawals.Add(new Withdrawal(1, 5000.45, new DateTime(2023, 3, 17)));
            customer.Withdrawals.Add(new Withdrawal(2, 8045.25, new DateTime(2023, 3, 18)));
            customer.Withdrawals.Add(new Withdrawal(3, 10250.55, new DateTime(2023, 3, 19)));

            customer.Deposit.Add(new Deposit(16, 6500, new DateTime(2023, 3, 20)));
            customer.Deposit.Add(new Deposit(17, 80000, new DateTime(2023, 3, 21)));
            customer.Deposit.Add(new Deposit(18, 78000, new DateTime(2023, 3, 22)));

            Add(customer);
        }

      
        //DataBase stuff

        public void LoadFromDB()
        {
            string sql = "SELECT * FROM Customers";
            DataTable table = DataAccess.SelectFromDB(sql);
            foreach (DataRow row in table.Rows)
            {
                //would work
                //Customer customer = new Customer(row);
                //Add(customer);
                Add(new Customer(row));
            }
        }



        public void SaveToXML()
        {
            DataAccess.SaveXML(typeof(CustomerCollection), this);
        }


        //public int GetNextID()
        //{
        //    int nextID = 1;

        //    if (this.Count > 0) 
        //    {
        //        nextID = this.Last().CustomerID + 1;
        //    }
        //    if(this.Count < 0) 
        //    {
        //        nextID = this.Last().CustomerID + 1;
        //        this.Add(new Customer { CustomerID = nextID });
        //    }

        //    return nextID;
        //}
    }
}
