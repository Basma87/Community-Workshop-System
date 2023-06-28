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
    public partial class Add_New_Tool : Form
    {
        Adapter adapter = new Adapter();
        Tool tool = new Tool();
        ToolsView toolView = new ToolsView();
        bool isEmpty;
        bool isNew = true;

        public Add_New_Tool()
        {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.Color;
            LoadComboBox();
        }

        public Add_New_Tool( int id)
        {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.Color;
            isNew = false;
            LoadComboBox();
            GetToolDetails(id);
        }


        private void LoadComboBox()
        {
            List<Status> status = adapter.getAllStatus();
            cboStatusList.DataSource = status;
            cboStatusList.DisplayMember = "status";
            cboStatusList.ValueMember = "StatusID";
            cboStatusList.SelectedIndex = 0;
        }

        private void GetToolDetails(int id)
        {
            toolView = adapter.GetToolbyID(id);
            txtboxProductNumber.Text = toolView.ProductNumber;
            txtboxProductName.Text = toolView.ProductName;
            txtBoxBrand.Text = toolView.ProductBrand;
            txtboxCondition.Text = toolView.CurrentCondition;
            cboStatusList.Text = toolView.Status;



        }


        private bool checkEmptyFields()
        {
            if (String.IsNullOrWhiteSpace(txtboxProductName.Text) ||
                String.IsNullOrWhiteSpace(txtboxProductNumber.Text) ||
                String.IsNullOrWhiteSpace(txtBoxBrand.Text))
            {
                return false;
            }

            else
                return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkEmptyFields()==false)
            {
                MessageBox.Show("please fill missing textboxes");
            }

            else
            { 
            
            tool.ProductNumber = txtboxProductNumber.Text;
            tool.ProductName = txtboxProductName.Text;
            tool.ProductBrand = txtBoxBrand.Text;
            tool.CurrentCondition = txtboxCondition.Text;
            tool.StatusID = (int)cboStatusList.SelectedValue;


            List<TextBox> txtBoxes = new List<TextBox>();

            if (isNew)
            {
                adapter.AddTool(tool);

                MessageBox.Show("Tool is added Successfully.");
            }
            else
            {

                tool.Tool_ID = toolView.Tool_ID;
                adapter.updateTool(tool);
                MessageBox.Show("Tool is updated Successfully.");
            }

            this.DialogResult = DialogResult.OK;

            /// clearing textboxes after adding the tool
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = null;
                }
            }
        }
        }
    }
}
