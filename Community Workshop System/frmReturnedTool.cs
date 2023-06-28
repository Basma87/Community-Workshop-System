using DataManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Community_Workshop_System
{
    public partial class frmReturnedTool : Form
    {
        RentedToolsView selectedTool;
        RentedTools RentedtoolDetails;

        Adapter adapter = new Adapter();

        public frmReturnedTool(RentedToolsView tool)
        {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.Color;
            selectedTool = tool;

            SetupLabel();
        }
        public frmReturnedTool()
        {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.Color;
        }

        private void SetupLabel()
        {
            lbltxt.Text = $"hey, " +
                $"{selectedTool.LastName + " "},{selectedTool.FirstName}" +"\n\n"+ 
                $"you will return, {selectedTool.ProductName}";
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            

        }
        
        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            RentedtoolDetails = adapter.GetrentedToolbyID(selectedTool.ID);

            //// update rented tools table
            RentedtoolDetails.Returned_Date = System.DateTime.Now;
            adapter.updateRentedToolstable(RentedtoolDetails); /// update rentedTools

            Tool UPdatedTool = new Tool();
            UPdatedTool.Tool_ID = RentedtoolDetails.Tool_ID;
            UPdatedTool.CurrentCondition = txtCondition.Text;

            /// update tools table with your preferences
            adapter.updateToolRentalStatus(UPdatedTool.Tool_ID, 1, UPdatedTool.CurrentCondition);  /// update Tools table

            this.DialogResult = DialogResult.OK;

            MessageBox.Show("Tool is returned");
        }
    }
}
