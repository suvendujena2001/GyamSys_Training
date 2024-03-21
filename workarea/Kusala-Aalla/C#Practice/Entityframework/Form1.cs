using System.Drawing.Text;
using System.Linq.Expressions;

namespace EntityFramework
{
    public partial class Form1 : Form
    {
        CustomerContext customerDb;
        List<Customer> customerList;
        private int _custUpdateId;
        private Customer? updateCust;
        public Form1()
        {
            customerDb = new CustomerContext();
            InitializeComponent();

            //customerList = customerDb.Customers.Select(c => c).ToList();

            ShowCustomers();
        }

        private void ShowCustomers()
        {
            customerList = customerDb.Customers.Select(c => c).ToList();
            lblResult.Text = "";

            cboCustIds.Items.Clear();

            foreach (Customer customer in customerList)
            {
                lblResult.Text += customer.ToString();
                cboCustIds.Items.Add(customer.CustomerId);
                cboUpdateById.Items.Add(customer.CustomerId);

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

        private void btnDeleteCust_Click(object sender, EventArgs e)
        {
            int custIdToDelete = (int)cboCustIds.SelectedItem;

            Customer? custToDelete = customerDb.Customers.Find(custIdToDelete);
            if (custToDelete != null)
            {
                try
                {
                    customerDb.Customers.Remove(custToDelete);
                    customerDb.SaveChanges();
                    lblDelete.Text = "Customer Deleted!";
                    ShowCustomers();
                }
                catch (Exception ex)
                {

                }
            }
        }
        private void cboUpdateById_SelectedIndexChanged(object sender, EventArgs e)
        {
            _custUpdateId = (int)cboUpdateById.SelectedItem;
            updateCust = customerDb.Customers.Find(_custUpdateId);

            Customer? updateCust = customerDb.Customers.Find(_custUpdateId);

            if (updateCust != null)
            {
                txtUpdateName.Text = updateCust.CustomerName;
                txtUpdateBudget.Text = updateCust.Budget.ToString();
            }

            //lblUpdateCust.Text = _custUpdateId.ToString();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (updateCust != null)
            {
                updateCust.CustomerName = txtUpdateName.Text;
                updateCust.Budget = double.Parse(txtUpdateBudget.Text);

                try
                {
                    customerDb.Customers.Update(updateCust);
                    customerDb.SaveChanges();
                    lblUpdateCust.Text = $"{updateCust.CustomerName} has been updated!";
                    ShowCustomers();
                }catch (Exception ex)
                {

                }
                
            }

        }
    }
}
