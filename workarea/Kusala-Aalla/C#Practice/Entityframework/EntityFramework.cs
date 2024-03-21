using System.Drawing.Text;
using System.Linq.Expressions;

namespace EntityFramework
{
    public partial class Form1 : Form
    {
        CustomerContext customerDb;
        List<Customer> customerList;
        public Form1()
        {
            customerDb = new CustomerContext();
            InitializeComponent();

            //customerList = customerDb.Customers.Select(c => c).ToList();

            ShowCustomer();
        }

        private void ShowCustomers(List<Customer> custList)
        {
            customerList = customerDb.Customers.Select(c => c).ToList();
            lblResult.Text = "";

            foreach (Customer customer in customerList)
            {
                lblResult.Text += customer.ToString();
            }
        }

        private void btnSearchCustomers_Click(object sender, EventArgs e)
        {
            lblMinBudgetCust.Text = "";
            float minBudgetSearch = float.Parse(txtMinBudget.Text);

            //from person in Data.People
            //where person.DateOfBirth.Year < 2000
            //select person.LastName;

            customerList = customerDb.Customers
            .OrderBy(c => c.CustomerName)
            .Where(c => c.Budget > minBudgetSearch)
            .Select(c => c).ToList();

            foreach (Customer customer in customerList)
            {
                lblMinBudgetCust.Text += customer.ToString();
            }
        }

        Private void btnIdSearch_Click(object sender, EventArgs e)
        {
            lblMinBudgetCust.Text = "";
            int custId = int.Parse(txtCustId.Text);
            Customer? cust = customerDb.Customers.Where(char => char.CustomerId == cust.CustomerId).FirstOrDefault();
            if (cust != null)
            {
                lblMinBudgetCust.Text = cust.ToString();
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Customer addCustomer = new() { Budget = double.Parse(txtAddBudget.Text), CustomerName = txtAddName.Text };
            try
            {
                customerDb.customers.Add(addCustomer);
                customerDb.SaveChanges();
            }Catch(Exception ex)
            {

            }

            ShowCustomers();
        }
    }
}
