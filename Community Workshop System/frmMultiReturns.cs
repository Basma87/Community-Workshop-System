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
    /// <summary>
    ///this module allows multiToolsReturn from the customer
    /// </summary>
    public partial class frmMultiReturns : Form
    {
        Adapter adapter = new Adapter();
        List<Customer> CustomersList;
        List<RentedToolsView> rentedToolsList;
      

        public frmMultiReturns()
        {

            InitializeComponent();
            this.BackColor = Properties.Settings.Default.Color;
            LoadCustomersComboBox();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        //loads all customers in the comboBox
        private void LoadCustomersComboBox()
        {
            CustomersList = adapter.GetAllCustomers();
            cboCustomers.DataSource = CustomersList;
            cboCustomers.ValueMember = "CustomerID";
            cboCustomers.DisplayMember = "FullName";
            cboCustomers.SelectedIndex = -1;
        }

        private void cboCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRentedTools();
        }


        // loads all rented tools of a specific customer, based on CustomerID
     
        private void LoadRentedTools()
        {
            try
            {
                if (cboCustomers.SelectedIndex>-1)
                {
                    int customerID = (int)cboCustomers.SelectedValue;
                    rentedToolsList = adapter.GetAllRentedToolsByCustomerID(customerID);
                    dgvTools.DataSource = null;
                    dgvTools.DataSource = rentedToolsList;
                }
            }
            catch
            { 

            }
        }

        private void dgvTools_DoubleClick(object sender, EventArgs e)
        {
            if (dgvTools.Rows.Count > 0)
            {
                int index = dgvTools.CurrentCell.RowIndex;

                frmReturnedTool frm = new frmReturnedTool(rentedToolsList[index]);

                if (frm.ShowDialog()==DialogResult.OK)
                {
                    LoadRentedTools();
                }
            }
        }

        private void btnReturnAll_Click(object sender, EventArgs e)
        {
            if (dgvTools.Rows.Count <= 0)
            {
                MessageBox.Show("No tools to be returned");
            }
            else
            {
                
                        foreach (var item in rentedToolsList)
                        {
                            RentedTools currentRentedTool = adapter.GetrentedToolbyID(item.ID);
                            currentRentedTool.Returned_Date = System.DateTime.Now;
                            adapter.updateRentedToolstable(currentRentedTool);

                            adapter.updateToolRentalStatus(currentRentedTool.Tool_ID, 1); // update tool in the tools table to be active
                        }
                
                MessageBox.Show("All tools are returned, thanks.");
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
