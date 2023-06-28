using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataManagement;


/// <summary>
/// This module is used to show customers in a grid view.
/// </summary>

namespace Community_Workshop_System
    {     

    public partial class CustomerList : Form

    {
        List<Customer> customrList = new List<Customer>();
        List<Customer> filteredList = new List<Customer>();
        List<Customer> ViewList;

        DataManagement.IDataAdapter adapter = Helper.GetAdapter();    // Get connection string
  

        public CustomerList()
        {
            InitializeComponent();
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.BackColor = Properties.Settings.Default.Color; /// Get Color Setting
            DateTime dateTime = System.DateTime.Now;
            string day = dateTime.ToString("dddd");

            lblDate.Text = $"{ day + "," + dateTime.ToString()}";

            LoadCustomers();
        }

        private void LoadCustomers()
        {

            customrList = adapter.GetAllCustomers();
            ViewList = customrList;
            RefreshedTable();

        }


        // refreshing customers data grid view
        private void RefreshedTable()
        {
            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = ViewList;

            dgvCustomers.Columns["Phone"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCustomers.Columns["FullName"].Visible = false;
            dgvCustomers.Columns["LastName"].HeaderText = "Surname"; // changes column header name
        }

        private void DeleteCustomer()
        {

            if (dgvCustomers.Rows.Count>0)
            {
                int id = (int)dgvCustomers["CustomerID", dgvCustomers.CurrentCell.RowIndex].Value;
                DialogResult result = MessageBox.Show("Delete this person?", "Confirmation",MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    adapter.DeleteCustomer(id);
                    LoadCustomers();
                }
            }
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.Rows.Count==0)
            {
                MessageBox.Show("No customers to be deleted");
            }

            else

            DeleteCustomer();
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            frmCustomerDetails frm = new frmCustomerDetails();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadCustomers();
            }
        }

        private void dgvCustomers_DoubleClick(object sender, EventArgs e)
        {
            int id = (int)dgvCustomers["CustomerID", dgvCustomers.CurrentCell.RowIndex].Value;

            frmCustomerDetails frm = new frmCustomerDetails(id);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadCustomers();
            }

        }
      
        /// <summary>
        ///  comparing typed name in the search box with names in the grid and show the matched name.
        /// </summary>
        private void SearchAndFilter()
        {
            bool isMatching;
            filteredList.Clear();


            // if searchbox is empty, load all customers 
            if (String.IsNullOrWhiteSpace(txtBox_Search.Text))
            {
                ViewList = customrList;
                RefreshedTable();
                return;
            }
            
            else
            {
                foreach (var customer in customrList)
                {
                    isMatching = true;

                    // if typed text not matching any of first names, do nothing
                    if (radbtn_firstName.Checked == true)
                    {
                        if (customer.FirstName.IndexOf(txtBox_Search.Text, StringComparison.OrdinalIgnoreCase) == -1)
                        {
                            isMatching = false;

                        }
                    }
                    
                   if (radbtn_lastName.Checked == true)
                    {
                        // if typed text not matching any of last names, do nothing
                        if (customer.LastName.IndexOf(txtBox_Search.Text, StringComparison.OrdinalIgnoreCase) == -1)
                        {
                            isMatching = false;

                        }
                    }
                
                   /// add the matched text to filtered list
                    if(isMatching )
                    {
                        filteredList.Add(customer);
                    }
                }

                // copy content of view list that will fill the grid same content of filtered list.
                ViewList = filteredList;
                RefreshedTable();
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
           txtBox_Search.Text = null;
        }

        private void txtBox_Search_TextChanged(object sender, EventArgs e)
        {
            SearchAndFilter();
        }

        private void btnMainForm_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.Show();

            this.Close();

        }
    }
}
