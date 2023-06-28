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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.Color;
        }


        // dialoge result = ok is set in close brn properitis 
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog()==DialogResult.OK)
            {
                Properties.Settings.Default.Color = colorDialog.Color;   // change color settings to user instead of app to get rid of red line
                Properties.Settings.Default.Save();
            }

            this.BackColor = Properties.Settings.Default.Color;
        }
    }
}
