using CH.Banking.BL;

namespace CH.Banking.UI
{
    public partial class Form1 : Form
    {
        //fields
        private CustomerCollection customers = new CustomerCollection();

        public Form1()
        {
            InitializeComponent();

            customers.LoadTestCustomers();

            if (customers.Count > 0)
            {
               RebindCustomers();
            }
        }

        //adds customers to the list 
        private void RebindCustomers()
        {
            //lstCustomers.DataSource = null; // unbind
            lstCustomers.DataSource = customers; // re-bind

        }

        //two different methods would have worked but easier wiht one
        private void RebindFinancial(List<Withdrawal> withdrawals, List<Deposit> deposits)
        {
            //DGVWithdrawals.DataSource = null;
            DGVWithdrawals.DataSource = withdrawals;

            //DGVDeposits.DataSource = null;
            DGVDeposits.DataSource = deposits;
        }

        private void lstCustomers_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Customer? selectedCustomer = lstCustomers.SelectedItem as Customer;
            if (selectedCustomer != null)
            {
                //this is what populates the text boxes when a customer is selected
                txtID.Text = selectedCustomer.CustomerID.ToString();
                txtFirstName.Text = selectedCustomer.FirstName;
                txtLastName.Text = selectedCustomer.LastName;
                txtSSN.Text = selectedCustomer.SSN;
                txtBirthDate.Text = selectedCustomer.DateOfBirth.ToString("yyyy-MM-dd");
                txtAge.Text = selectedCustomer.Age.ToString();

                //adds the financial information when the selected customer is selected
                //this is what populates the DGV down below when the customer is selected 
                RebindFinancial(selectedCustomer.Withdrawls, selectedCustomer.Deposit);

            }
        }
    }
}
