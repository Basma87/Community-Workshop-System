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
    public partial class Menu : Form
    {
       
        public Menu()
        {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.Color;
            DateTime dateTime = System.DateTime.Now;
            string day = dateTime.ToString("dddd");
            Datelbl.Text = $"{ day + ", " + dateTime.ToString()}";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            CustomerList customerList = new CustomerList();

            customerList.Show();  
          
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            frmTools frm = new frmTools();
            frm.Show();

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm frm = new SettingsForm();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = Properties.Settings.Default.Color;
            }
           
        }

        private void btnRentedTools_Click(object sender, EventArgs e)
        {
            frmRentedTools form = new frmRentedTools();
            form.Show();
        }
    }
}
