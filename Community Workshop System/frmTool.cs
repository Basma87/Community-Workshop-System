using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataManagement;

namespace Community_Workshop_System
{
    /// <summary>
    /// section for handling tools section functions
    /// </summary>
    public partial class frmTools : Form
    {
        List<ToolsView> Alltools = new List<ToolsView>();
        List<ToolsView> filtredList = new List<ToolsView> ();
        List<ToolsView> viewList;
        List<Status> statusList;

        Add_New_Tool frm = new Add_New_Tool();

     
        Adapter adapter = new Adapter();
        public frmTools()
        {
            InitializeComponent();

            this.BackColor = Properties.Settings.Default.Color;
            dgvTools.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DateTime dateTime = System.DateTime.Now;
            string day = dateTime.ToString("dddd");
            Datelbl.Text = $"{ day + ", " + dateTime.ToString()}";

            loadToolsStatuscomboBox();

            GetAllTools();
        }
        // loads data of the comboBox
        private void loadToolsStatuscomboBox()

        {
            statusList = adapter.getAllStatus();
            cboToolStatus.DataSource = statusList;
            cboToolStatus.ValueMember = "StatusID";
            cboToolStatus.DisplayMember = "status";
            cboToolStatus.SelectedIndex = -1;
        }

      

        // loads all tools.
        private void GetAllTools()
        {
            Alltools= adapter.GetAllTools(); 
            viewList = Alltools;

            RefreshedTable();
        }

        private void RefreshedTable()
        {
            dgvTools.DataSource = null;
            dgvTools.DataSource = viewList;
        }

        private void SearchAndFilter()
        {
            bool isMatching;

            filtredList.Clear();


            // if nothing is typed in the serachBox, then all tools.
            if (String.IsNullOrWhiteSpace(txtBox_search.Text))
            {
                viewList = Alltools;
                RefreshedTable();
                return;
            }
            else
            {
                foreach (var Tool in Alltools)
                {
                    isMatching = true;

                    // if toolName is selected then filter the grid based on it.
                    if (radBtn_ToolName.Checked == true)
                    {
                        // if no name is mathing, do nothing
                        if (Tool.ProductName.IndexOf(txtBox_search.Text, StringComparison.OrdinalIgnoreCase) == -1)
                        {
                            isMatching = false;

                        }
                    }
                    // if toolBrand is selected then filter the grid based on it.
                    if (btnRad_BrandName.Checked == true)
                    {
                        // if no barnd is mathing, do nothing
                        if (Tool.ProductBrand.IndexOf(txtBox_search.Text, StringComparison.OrdinalIgnoreCase) == -1)
                        {
                            isMatching = false;

                        }
                    }

                    // if toolCondition is selected then filter the grid based on it.
                    if (radBtn_condition.Checked == true)
                    {
                        // if no condition is mathing, do nothing
                        if (Tool.CurrentCondition.IndexOf(txtBox_search.Text, StringComparison.OrdinalIgnoreCase) == -1)
                        {
                            isMatching = false;
                        }
                    }

                /// if the typed text is matching add to the filtered list
                    if(isMatching) 
                    {
                        filtredList.Add(Tool);
                    }
                }

                viewList = filtredList;
                RefreshedTable();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTools_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void deleteTool()
        {
            if (dgvTools.Rows.Count > 0)
            {
                int id = (int)dgvTools["Tool_ID", dgvTools.CurrentCell.RowIndex].Value;
                DialogResult result = MessageBox.Show("Are you sure to delete this Tool", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    adapter.DeleteTool(id);
                    GetAllTools();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteTool();
        }

        

        private void btnAddNewTool_Click(object sender, EventArgs e)
        {
          

            if (frm.ShowDialog ()== DialogResult.OK)
            {
                GetAllTools();
            }
        }

        private void txtBox_search_Enter(object sender, EventArgs e)
        {
            txtBox_search.Text = null;
        }

        private void txtBox_search_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvTools_DoubleClick(object sender, EventArgs e)
        {
            int id =(int) dgvTools["Tool_ID",dgvTools.CurrentCell.RowIndex].Value; // get toolID

            Add_New_Tool frm = new Add_New_Tool(id);

            if (frm.ShowDialog()==DialogResult.OK)
            {
                GetAllTools();
            }

        }

        // Filter the grid based on the selected values of the comboBox
        private void cboToolStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int id = (int)cboToolStatus.SelectedValue;

                // get Tools, based on the selected status from the comboBox
                if (!String.IsNullOrWhiteSpace(cboToolStatus.Text))
                {
                    Alltools = adapter.GetAllTools(id);
                }

                viewList = Alltools;
                dgvTools.DataSource = viewList;
                SearchAndFilter();
            }
            catch (Exception)
            {

            }
         }

        private void txtBox_search_TextChanged_1(object sender, EventArgs e)
        {
            SearchAndFilter();
        }

        private void radBtn_condition_CheckedChanged(object sender, EventArgs e)
        {
            SearchAndFilter();
        }

        private void btnRad_BrandName_CheckedChanged(object sender, EventArgs e)
        {
            SearchAndFilter();
        }

        private void radBtn_ToolName_CheckedChanged(object sender, EventArgs e)
        {
            SearchAndFilter();
        }

        // reset grid data when combobox value not in any of populated values(active, on rental , retired)
        private void cboToolStatus_TextChanged(object sender, EventArgs e)
        {
            Alltools = adapter.GetAllTools();
            viewList = Alltools;
            dgvTools.DataSource = viewList;
        }


        // Method that saves grid contents to a CSV file
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (saveFileDialogue.ShowDialog() == DialogResult.OK)
            {
                var filePath = saveFileDialogue.FileName;
                if (!filePath.EndsWith(".csv"))
                {
                    filePath = filePath + ".csv";
                }
                using (StreamWriter writer=new StreamWriter (filePath))
                {
                    writer.WriteLine($"{"Tool_ID"},{"ProductNumber"},{"ProductName"},{"ProductBrand"},{"CurrentCondition"},{"Status"}");
                    foreach (var item in viewList)
                    {
                        string line = $"{item.Tool_ID},{item.ProductNumber},{item.ProductName},{item.ProductBrand},{item.CurrentCondition},{item.Status}";
                        writer.WriteLine(line);
                    }

                    MessageBox.Show("File is Saved");
                }
            }
        }

        private void cboToolStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
