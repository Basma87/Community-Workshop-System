
namespace Community_Workshop_System
{
    partial class frmMultiRentals
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
            this.cboCustomers = new System.Windows.Forms.ComboBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.dgvAvailableTools = new System.Windows.Forms.DataGridView();
            this.dgvSelected = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblAvailableTools = new System.Windows.Forms.Label();
            this.lblSelectedTools = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableTools)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCustomers
            // 
            this.cboCustomers.FormattingEnabled = true;
            this.cboCustomers.Location = new System.Drawing.Point(119, 51);
            this.cboCustomers.Name = "cboCustomers";
            this.cboCustomers.Size = new System.Drawing.Size(270, 24);
            this.cboCustomers.TabIndex = 0;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(41, 51);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(72, 17);
            this.lblCustomer.TabIndex = 1;
            this.lblCustomer.Text = "Customer:";
            // 
            // dgvAvailableTools
            // 
            this.dgvAvailableTools.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableTools.Location = new System.Drawing.Point(12, 159);
            this.dgvAvailableTools.Name = "dgvAvailableTools";
            this.dgvAvailableTools.RowHeadersWidth = 51;
            this.dgvAvailableTools.RowTemplate.Height = 24;
            this.dgvAvailableTools.Size = new System.Drawing.Size(522, 281);
            this.dgvAvailableTools.TabIndex = 2;
            this.dgvAvailableTools.DoubleClick += new System.EventHandler(this.dgvAvailableTools_DoubleClick);
            // 
            // dgvSelected
            // 
            this.dgvSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelected.Location = new System.Drawing.Point(540, 159);
            this.dgvSelected.Name = "dgvSelected";
            this.dgvSelected.RowHeadersWidth = 51;
            this.dgvSelected.RowTemplate.Height = 24;
            this.dgvSelected.Size = new System.Drawing.Size(572, 281);
            this.dgvSelected.TabIndex = 3;
            this.dgvSelected.DoubleClick += new System.EventHandler(this.dgvSelected_DoubleClick);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(59, 482);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Location = new System.Drawing.Point(164, 482);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblAvailableTools
            // 
            this.lblAvailableTools.AutoSize = true;
            this.lblAvailableTools.Location = new System.Drawing.Point(28, 136);
            this.lblAvailableTools.Name = "lblAvailableTools";
            this.lblAvailableTools.Size = new System.Drawing.Size(111, 17);
            this.lblAvailableTools.TabIndex = 6;
            this.lblAvailableTools.Text = "Available tools : ";
            // 
            // lblSelectedTools
            // 
            this.lblSelectedTools.AutoSize = true;
            this.lblSelectedTools.Location = new System.Drawing.Point(580, 136);
            this.lblSelectedTools.Name = "lblSelectedTools";
            this.lblSelectedTools.Size = new System.Drawing.Size(106, 17);
            this.lblSelectedTools.TabIndex = 7;
            this.lblSelectedTools.Text = "Selected Tools:";
            // 
            // frmMultiRentals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 556);
            this.Controls.Add(this.lblSelectedTools);
            this.Controls.Add(this.lblAvailableTools);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvSelected);
            this.Controls.Add(this.dgvAvailableTools);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.cboCustomers);
            this.Name = "frmMultiRentals";
            this.Text = "frmMultiRentals";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableTools)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCustomers;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.DataGridView dgvAvailableTools;
        private System.Windows.Forms.DataGridView dgvSelected;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblAvailableTools;
        private System.Windows.Forms.Label lblSelectedTools;
    }
}