
namespace Community_Workshop_System
{
    partial class frmTools
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvTools = new System.Windows.Forms.DataGridView();
            this.btnAddNewTool = new System.Windows.Forms.Button();
            this.Datelbl = new System.Windows.Forms.Label();
            this.Titlelbl = new System.Windows.Forms.Label();
            this.txtBox_search = new System.Windows.Forms.TextBox();
            this.radBtn_ToolName = new System.Windows.Forms.RadioButton();
            this.btnRad_BrandName = new System.Windows.Forms.RadioButton();
            this.radBtn_condition = new System.Windows.Forms.RadioButton();
            this.cboToolStatus = new System.Windows.Forms.ComboBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.saveFileDialogue = new System.Windows.Forms.SaveFileDialog();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTools)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(236, 557);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(144, 33);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete Tool";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(427, 557);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(144, 33);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvTools
            // 
            this.dgvTools.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTools.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTools.Location = new System.Drawing.Point(32, 182);
            this.dgvTools.Name = "dgvTools";
            this.dgvTools.RowHeadersWidth = 51;
            this.dgvTools.RowTemplate.Height = 24;
            this.dgvTools.Size = new System.Drawing.Size(799, 319);
            this.dgvTools.TabIndex = 4;
            this.dgvTools.DoubleClick += new System.EventHandler(this.dgvTools_DoubleClick);
            // 
            // btnAddNewTool
            // 
            this.btnAddNewTool.Location = new System.Drawing.Point(36, 557);
            this.btnAddNewTool.Name = "btnAddNewTool";
            this.btnAddNewTool.Size = new System.Drawing.Size(147, 33);
            this.btnAddNewTool.TabIndex = 7;
            this.btnAddNewTool.Text = "Add New / Edit tool";
            this.btnAddNewTool.UseVisualStyleBackColor = true;
            this.btnAddNewTool.Click += new System.EventHandler(this.btnAddNewTool_Click);
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Location = new System.Drawing.Point(29, 45);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(38, 17);
            this.Datelbl.TabIndex = 9;
            this.Datelbl.Text = "Date";
            // 
            // Titlelbl
            // 
            this.Titlelbl.AutoSize = true;
            this.Titlelbl.Location = new System.Drawing.Point(29, 18);
            this.Titlelbl.Name = "Titlelbl";
            this.Titlelbl.Size = new System.Drawing.Size(191, 17);
            this.Titlelbl.TabIndex = 8;
            this.Titlelbl.Text = "Community workshop System";
            // 
            // txtBox_search
            // 
            this.txtBox_search.Location = new System.Drawing.Point(513, 141);
            this.txtBox_search.Multiline = true;
            this.txtBox_search.Name = "txtBox_search";
            this.txtBox_search.Size = new System.Drawing.Size(183, 22);
            this.txtBox_search.TabIndex = 10;
            this.txtBox_search.TextChanged += new System.EventHandler(this.txtBox_search_TextChanged_1);
            this.txtBox_search.Enter += new System.EventHandler(this.txtBox_search_Enter);
            // 
            // radBtn_ToolName
            // 
            this.radBtn_ToolName.AutoSize = true;
            this.radBtn_ToolName.Checked = true;
            this.radBtn_ToolName.Location = new System.Drawing.Point(52, 141);
            this.radBtn_ToolName.Name = "radBtn_ToolName";
            this.radBtn_ToolName.Size = new System.Drawing.Size(98, 21);
            this.radBtn_ToolName.TabIndex = 11;
            this.radBtn_ToolName.TabStop = true;
            this.radBtn_ToolName.Text = "Tool Name";
            this.radBtn_ToolName.UseVisualStyleBackColor = true;
            this.radBtn_ToolName.CheckedChanged += new System.EventHandler(this.radBtn_ToolName_CheckedChanged);
            // 
            // btnRad_BrandName
            // 
            this.btnRad_BrandName.AutoSize = true;
            this.btnRad_BrandName.Location = new System.Drawing.Point(188, 141);
            this.btnRad_BrandName.Name = "btnRad_BrandName";
            this.btnRad_BrandName.Size = new System.Drawing.Size(108, 21);
            this.btnRad_BrandName.TabIndex = 12;
            this.btnRad_BrandName.Text = "Brand Name";
            this.btnRad_BrandName.UseVisualStyleBackColor = true;
            this.btnRad_BrandName.CheckedChanged += new System.EventHandler(this.btnRad_BrandName_CheckedChanged);
            // 
            // radBtn_condition
            // 
            this.radBtn_condition.AutoSize = true;
            this.radBtn_condition.Location = new System.Drawing.Point(321, 141);
            this.radBtn_condition.Name = "radBtn_condition";
            this.radBtn_condition.Size = new System.Drawing.Size(88, 21);
            this.radBtn_condition.TabIndex = 14;
            this.radBtn_condition.Text = "Condition";
            this.radBtn_condition.UseVisualStyleBackColor = true;
            this.radBtn_condition.CheckedChanged += new System.EventHandler(this.radBtn_condition_CheckedChanged);
            // 
            // cboToolStatus
            // 
            this.cboToolStatus.FormattingEnabled = true;
            this.cboToolStatus.Location = new System.Drawing.Point(513, 98);
            this.cboToolStatus.Name = "cboToolStatus";
            this.cboToolStatus.Size = new System.Drawing.Size(183, 24);
            this.cboToolStatus.TabIndex = 15;
            this.cboToolStatus.SelectedIndexChanged += new System.EventHandler(this.cboToolStatus_SelectedIndexChanged);
            this.cboToolStatus.SelectedValueChanged += new System.EventHandler(this.cboToolStatus_SelectedValueChanged);
            this.cboToolStatus.TextChanged += new System.EventHandler(this.cboToolStatus_TextChanged);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(713, 134);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(118, 35);
            this.btnExport.TabIndex = 16;
            this.btnExport.Text = "Export to CSV";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(424, 101);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(88, 17);
            this.lblStatus.TabIndex = 17;
            this.lblStatus.Text = "Tool Status: ";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // frmTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 685);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.cboToolStatus);
            this.Controls.Add(this.radBtn_condition);
            this.Controls.Add(this.btnRad_BrandName);
            this.Controls.Add(this.radBtn_ToolName);
            this.Controls.Add(this.txtBox_search);
            this.Controls.Add(this.Datelbl);
            this.Controls.Add(this.Titlelbl);
            this.Controls.Add(this.btnAddNewTool);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvTools);
            this.Name = "frmTools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tools list";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTools)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvTools;
        private System.Windows.Forms.Button btnAddNewTool;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Label Titlelbl;
        private System.Windows.Forms.TextBox txtBox_search;
        private System.Windows.Forms.RadioButton radBtn_ToolName;
        private System.Windows.Forms.RadioButton btnRad_BrandName;
        private System.Windows.Forms.RadioButton radBtn_condition;
        private System.Windows.Forms.ComboBox cboToolStatus;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.SaveFileDialog saveFileDialogue;
        private System.Windows.Forms.Label lblStatus;
    }
}