using CH.Banking.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH.Banking.BL
{

    //Customer dervies from person
    //aka gets all the things a person has
    public class Customer : Person
    {
        //I just created hardcorded ID's for everyone
        
        public int CustomerID { get; set; }

        //added this here because each customer has withdrawals and deposits

        //but not ever person has them 

        public List<Withdrawal> Withdrawals { get; set; } = new List<Withdrawal>();

        public List<Deposit> Deposit { get; set; } = new List<Deposit>();

        public Customer()
        {

        }

        public void LoadWithdrawalsFromDB()
        {
            Withdrawals.Clear();
            string sql = "SELECT * FROM Withdrawals WHERE OwnerID = @ID";

            DataTable table = DataAccess.SelectFromDB(sql, GetParameters());

            foreach (DataRow row in table.Rows)
            {
                Withdrawals.Add(new Withdrawal(row));
            }
        }

        public void LoadDepositsFromDB()
        {
            Deposit.Clear();
            string sql = "SELECT * FROM Deposits WHERE OwnerID = @ID";

            DataTable table = DataAccess.SelectFromDB(sql, GetParameters());

            foreach (DataRow row in table.Rows)
            {
                Deposit.Add(new Deposit(row));
            }
        }

        public void InsertIntoDB()
        {
            string sql = "Insert Into customers(FirstName, LastName, SSN, DOB) " +
                "VALUES (@FirstName, @LastName, @SSN, @DOB); Select SCOPE_IDENTITY()";
            CustomerID = DataAccess.ExecuteSql(sql, GetParameters());

        }

        public void UpdateDB()
        {
            string sql = "UPDATE customers SET FirstName = @FirstName, LastName = @LastName, " +
                "SSN = @SSN, DOB = @DOB WHERE ID = @ID";

            DataAccess.ExecuteSql(sql, GetParameters());
        }

        public void DeleteFromDB()
        {
            string sql = "DELETE FROM customers WHERE ID = @ID";
            DataAccess.ExecuteSql(sql, GetParameters());
        }

        public Customer(DataRow customerRow)
        {
            CustomerID = Convert.ToInt32(customerRow["ID"]);
            FirstName = Convert.ToString(customerRow["FirstName"])!;
            LastName = Convert.ToString(customerRow["LastName"])!;
            //the one in quotation is the one pulling into the database 
            SSN = Convert.ToString(customerRow["SSN"])!;
            DateOfBirth = Convert.ToDateTime(customerRow["DOB"])!;
        }


        private List<SqlParameter> GetParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@ID", CustomerID));
            parameters.Add(new SqlParameter("@FirstName", FirstName));
            parameters.Add(new SqlParameter("@LastName", LastName));
            parameters.Add(new SqlParameter("@SSN", SSN));
            parameters.Add(new SqlParameter("@DOB", DateOfBirth));
            return parameters;
        }



    }
}
