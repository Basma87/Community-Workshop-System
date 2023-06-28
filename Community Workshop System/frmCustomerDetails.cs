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

namespace Community_Workshop_System
{
    public partial class frmCustomerDetails : Form
    {
        Customer customer = new Customer();

        Adapter adapter = new Adapter();
        bool isNew = true;
        bool isEmpty;

        public frmCustomerDetails()
        {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.Color;
        }

        public frmCustomerDetails(int id)
        {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.Color;
            isNew = false;
            showCustomerDetails(id);
        }

        private void showCustomerDetails(int id)
        {
            customer = adapter.getSingleCustomerDetails(id);
            firstTxtbox.Text = customer.FirstName;
            lastTxtbox.Text = customer.LastName;
            phoneTxtbox.Text = customer.Phone;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double number;
            checkEmptyFields();

            if (isEmpty == true)
            {
                MessageBox.Show("Please fill Empty fields");
            }

            else
            {
                if (double.TryParse(phoneTxtbox.Text, out number) == false)   // to ensure that no characters in the phone number
                {
                    MessageBox.Show("phone number should be only digits");
                }

                else
                {
                    saveNewCustomer();
                }
            }
        }
        private void saveNewCustomer()
        {
            customer.FirstName = firstTxtbox.Text;
            customer.LastName = lastTxtbox.Text;
            customer.Phone = phoneTxtbox.Text;

            if (isNew)
            {
                adapter.SaveSingleCustomer(customer);
                MessageBox.Show("Customer is Added Successfully");
            }

            else
            {
                adapter.saveExistinCustomer(customer);
                MessageBox.Show("Customer is updated Successfully");
            }
            
            this.DialogResult = DialogResult.OK;
            
        }

        private void checkEmptyFields()
        {
            if (String.IsNullOrWhiteSpace(lastTxtbox.Text) || String.IsNullOrWhiteSpace(firstTxtbox.Text) || String.IsNullOrWhiteSpace(phoneTxtbox.Text))
            {
                isEmpty = true;
            }

            else
                isEmpty = false;
        }
  }
}
