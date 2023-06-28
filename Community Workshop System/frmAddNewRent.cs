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

    public partial class frmAddNewRent : Form
    {
        Adapter adapter = new Adapter();

        List<Customer> customerList = new List<Customer>();
        List<Tool> toolsList = new List<Tool>();


        public frmAddNewRent()
        {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.Color;
            loadComboBoxes();
        }

        private void loadComboBoxes()
        {
            customerList = adapter.GetAllCustomers();
            cboCustomer.DataSource = customerList;
            cboCustomer.ValueMember = "CustomerID";
            cboCustomer.DisplayMember = "FullName";
            cboCustomer.SelectedIndex = -1;


            toolsList = adapter.GetToolsList(1); /// available tools
            cboTools.DataSource = toolsList;
            cboTools.ValueMember = "Tool_ID";
            cboTools.DisplayMember = "ProductName";
            cboTools.SelectedIndex = -1;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmAddNewRent_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboCustomer.SelectedIndex > -1 && cboTools.SelectedIndex > -1)
            {
                int status = 2; // change it to database preference

                // add new rented tool
                RentedTools newRentedTool = new RentedTools();
                newRentedTool.Tool_ID = (int)cboTools.SelectedValue;
                newRentedTool.CustomerID = (int)cboCustomer.SelectedValue;
                newRentedTool.Rented_Date = System.DateTime.Now;

                adapter.AddnewRentedTool(newRentedTool);

                //then update its status into tools table 
                Tool updatedTool = new Tool();
                 updatedTool.Tool_ID = newRentedTool.Tool_ID;
                adapter.updateToolRentalStatus(updatedTool.Tool_ID,status);  // onRental =2 --> so update status with 2

                this.DialogResult = DialogResult.OK;
                return;

            }
            MessageBox.Show("PLease complete all fields before saving");

        }
    }
}
