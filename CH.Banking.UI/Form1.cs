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
        public bool NewPerson = false;

        //adds customers to the list 
        private void RebindCustomers()
        {
            //need the null because otherwise it won't update the customer on the interface
            lstCustomers.DataSource = null; // unbind
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
                //txtID.Text = selectedCustomer.CustomerID.ToString();

                txtFirstName.Text = selectedCustomer.FirstName;
                txtLastName.Text = selectedCustomer.LastName;
                txtSSN.Text = selectedCustomer.SSN;
                txtBirthDate.Text = selectedCustomer.DateOfBirth.ToString("yyyy-MM-dd");
                txtAge.Text = selectedCustomer.Age.ToString();

                //adds the financial information when the selected customer is selected
                //this is what populates the DGV down below when the customer is selected 
                RebindFinancial(selectedCustomer.Withdrawals, selectedCustomer.Deposit);

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            Customer? selectedCustomer = lstCustomers.SelectedItem as Customer;
            if (selectedCustomer != null && NewPerson == false)
            {
                selectedCustomer.FirstName = txtFirstName.Text;
                selectedCustomer.LastName = txtLastName.Text;
                selectedCustomer.SSN = txtSSN.Text;
                selectedCustomer.DateOfBirth = DateTime.Parse(txtBirthDate.Text);

                RebindCustomers(); 
            }
            else if (btnNew_Click != null)
            {
                //ToDo: Need something for ID here
                Customer customer = new Customer();
                customer.FirstName = txtFirstName.Text;
                customer.LastName = txtLastName.Text;
                customer.SSN = txtSSN.Text;
                customer.DateOfBirth = DateTime.Parse(txtBirthDate.Text);
                customers.Add(customer);
                RebindCustomers();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtSSN.Text = "";
            txtBirthDate.Text = "";
            txtAge.Text = "";
            NewPerson = true;
        }
    }
}
