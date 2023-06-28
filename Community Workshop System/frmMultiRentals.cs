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
    
    public partial class frmMultiRentals : Form
    {
        Adapter adapter = new Adapter();

        List<Customer> customersList = new List<Customer>();
        List<ToolsView> availableTools;
        List<ToolsView> selectedTools = new List<ToolsView> ();
        public frmMultiRentals()
        {
            InitializeComponent();
            LoadCustomerComboBox();
            LoadAvailableTools();

            this.BackColor = Properties.Settings.Default.Color;
            dgvAvailableTools.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSelected.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadCustomerComboBox()
        {
            customersList = adapter.GetAllCustomers();
            cboCustomers.DataSource = customersList;
            cboCustomers.DisplayMember = "FullName";
            cboCustomers.ValueMember = "CustomerID";
            cboCustomers.SelectedIndex = -1;

        }

        private void LoadAvailableTools()
        {
            availableTools = adapter.GetAllTools(1);     // 1= active tools
            dgvAvailableTools.DataSource = availableTools;
        }

        // rfresh content of the grid when item is removed or added.
        private void RefreshDataTables()
        { 
            availableTools = availableTools.OrderBy(t=>t.Tool_ID).ToList();   // sort list when switching items between two lists
            dgvAvailableTools.DataSource = null;
            dgvAvailableTools.DataSource = availableTools;
           

            dgvSelected.DataSource = null;
            dgvSelected.DataSource = selectedTools;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // when Double click this grid, it will move tool to the other grid (selectedTools)
        private void dgvAvailableTools_DoubleClick(object sender, EventArgs e)
        {
            if (dgvAvailableTools.Rows.Count > 0)
            {
                int index = dgvAvailableTools.CurrentCell.RowIndex;    // diffrenet than the other getting primary key to open in a new form, this get index of the row.
                selectedTools.Add(availableTools[index]);  
                availableTools.RemoveAt(index);
                RefreshDataTables();
            }
        }


        // when Double click this grid, it will move tool to the other grid (availableTools)
        private void dgvSelected_DoubleClick(object sender, EventArgs e)
        {
            if (dgvSelected.Rows.Count>0)
            {
                int index = dgvSelected.CurrentCell.RowIndex;
                availableTools.Add(selectedTools[index]);
                selectedTools.RemoveAt(index);
                RefreshDataTables();
            }
        }


        // add list of rented tools for the cutsomer
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboCustomers.SelectedIndex > -1 && dgvSelected.Rows.Count>0)
            {
                RentedTools rentedTools = new RentedTools();
                rentedTools.CustomerID =(int) cboCustomers.SelectedValue;
                rentedTools.Rented_Date = System.DateTime.Now;
                foreach (var tool in selectedTools)
                {
                    rentedTools.Tool_ID = tool.Tool_ID;
                    adapter.AddnewRentedTool(rentedTools);

                    adapter.updateToolRentalStatus(tool.Tool_ID, 2);  // update tool status to be onRental
                }

                this.DialogResult = DialogResult.OK;
                return;
            }

            // if no customer , or tools are selected
            MessageBox.Show("please select customer and tool to borrow.");
        }
    }
}
