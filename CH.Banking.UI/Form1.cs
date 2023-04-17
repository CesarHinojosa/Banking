using CH.Banking.BL;
using CH.Banking.PL;

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
           // CustomerCollection customerCollection = new CustomerCollection();
            
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
                txtID.Text = selectedCustomer.CustomerID.ToString();

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
            //important here is the bool NewPerson 
            //without the bool it would adjust the customer and add a new customer
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

                int id;
                //ToDo: Need something for ID here
                //Todo:LOOK HERE
                Customer customer = new Customer();

                customer.FirstName = txtFirstName.Text;
                customer.LastName = txtLastName.Text;
                customer.SSN = txtSSN.Text;

                if(DateTime.TryParse(txtBirthDate.Text, out  DateTime dt)) 
                {
                    customer.DateOfBirth = dt;
                    customers.Add(customer);
                    RebindCustomers();
                }
                else
                {
                    MessageBox.Show("Invalid Input for Birthdate (YYYY/MM/DD)");
                }

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //all the real work is dont in the update button
            //makes the appereance that a new customer was added
            txtID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtSSN.Text = "";
            txtBirthDate.Text = "";
            txtAge.Text = "";
            //THE BOOL IS IMPORTANT
            NewPerson = true;
        }

        private void btnSaveToXML_Click(object sender, EventArgs e)
        {
            //Save to the customer.XML File
            customers.SaveToXML();
        }

        private void btnLoadFromXML_Click(object sender, EventArgs e)
        {
            try
            {
                //Once the customers are added must rebind in order for the to show
                Type type = typeof(CustomerCollection);
                CustomerCollection? temp = DataAccess.LoadXML(type) as CustomerCollection;
                customers = (temp != null) ? temp : new CustomerCollection();
                RebindCustomers();

            }
            catch
            {
                customers = new CustomerCollection();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Message Displayed, Message Title, Buttons Displayed
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "Deleting Customer", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Customer? selectedCustomer = lstCustomers.SelectedItem as Customer;
                if (selectedCustomer != null)
                {
                    //make the textboxes empty as the customer is removed
                    txtID.Text = "";
                    txtFirstName.Text = "";
                    txtLastName.Text = "";
                    txtSSN.Text = "";
                    txtBirthDate.Text = "";
                    txtAge.Text = "";
                    customers.Remove(selectedCustomer);
                    //rebinds the list so that the deleted customer does not show up anymore
                    RebindCustomers();
                }
            }
            //do nothing just close
            else { }
        }
    }
}
