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
    public partial class frmRentedTools : Form
    {
        List<RentedToolsView> rentedToolsList = new List<RentedToolsView>();

        Adapter adapter = new Adapter();
        
        public frmRentedTools()
        {
            
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.Color;
            // to make grid resizable with the form , change its anchor to be all sides
            dgvRentedTools.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;  // to make all cells filling grid when resizing the form
          
            loadRentedToolsTable();


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loadRentedToolsTable()
        {
            rentedToolsList = adapter.GetAllRentedTools();
            
            dgvRentedTools.DataSource = null;
            dgvRentedTools.DataSource = rentedToolsList;
        }

        private void btnAddNewRent_Click(object sender, EventArgs e)
        {
            frmAddNewRent frm = new frmAddNewRent();

            if (frm.ShowDialog()==DialogResult.OK)
            {
                loadRentedToolsTable();
            }
          
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (dgvRentedTools.Rows.Count>0)
            {
                int id = dgvRentedTools.CurrentCell.RowIndex;

                RentedToolsView returnedtool = rentedToolsList[id];

                if (returnedtool.Returned_Date == null)
                {
                    frmReturnedTool form = new frmReturnedTool(returnedtool);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        loadRentedToolsTable();
                    }
                }

                else
                {
                    MessageBox.Show("this item has already been returned");
                    return;
                }
                
               
            }
           
        }

        private void btnMultiRentals_Click(object sender, EventArgs e)
        {
            frmMultiRentals frm = new frmMultiRentals();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                loadRentedToolsTable();
            }
            
        }

        private void btnMultiReturns_Click(object sender, EventArgs e)
        {
            frmMultiReturns frm = new frmMultiReturns();
            if (frm.ShowDialog()==DialogResult.OK)
            {
                loadRentedToolsTable();
            }
           // frm.Show();
        }
    }
}
