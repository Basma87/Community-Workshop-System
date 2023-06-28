
namespace Community_Workshop_System
{
    partial class frmMultiReturns
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboCustomers = new System.Windows.Forms.ComboBox();
            this.dgvTools = new System.Windows.Forms.DataGridView();
            this.btnReturnAll = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblNote = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTools)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name:";
            // 
            // cboCustomers
            // 
            this.cboCustomers.FormattingEnabled = true;
            this.cboCustomers.Location = new System.Drawing.Point(141, 41);
            this.cboCustomers.Name = "cboCustomers";
            this.cboCustomers.Size = new System.Drawing.Size(219, 24);
            this.cboCustomers.TabIndex = 1;
            this.cboCustomers.SelectedIndexChanged += new System.EventHandler(this.cboCustomers_SelectedIndexChanged);
            // 
            // dgvTools
            // 
            this.dgvTools.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTools.Location = new System.Drawing.Point(22, 91);
            this.dgvTools.Name = "dgvTools";
            this.dgvTools.RowHeadersWidth = 51;
            this.dgvTools.RowTemplate.Height = 24;
            this.dgvTools.Size = new System.Drawing.Size(670, 264);
            this.dgvTools.TabIndex = 2;
            this.dgvTools.DoubleClick += new System.EventHandler(this.dgvTools_DoubleClick);
            // 
            // btnReturnAll
            // 
            this.btnReturnAll.Location = new System.Drawing.Point(457, 396);
            this.btnReturnAll.Name = "btnReturnAll";
            this.btnReturnAll.Size = new System.Drawing.Size(108, 33);
            this.btnReturnAll.TabIndex = 3;
            this.btnReturnAll.Text = "Return All";
            this.btnReturnAll.UseVisualStyleBackColor = true;
            this.btnReturnAll.Click += new System.EventHandler(this.btnReturnAll_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(616, 396);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 33);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(19, 396);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(316, 68);
            this.lblNote.TabIndex = 5;
            this.lblNote.Text = "Double Clcik in the grid to return single item\r\n\r\nNote: Damaged returns must be r" +
    "eturned singly, \r\nand have condition not added";
            // 
            // frmMultiReturns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 534);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReturnAll);
            this.Controls.Add(this.dgvTools);
            this.Controls.Add(this.cboCustomers);
            this.Controls.Add(this.label1);
            this.Name = "frmMultiReturns";
            this.Text = "MultiReturns";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTools)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCustomers;
        private System.Windows.Forms.DataGridView dgvTools;
        private System.Windows.Forms.Button btnReturnAll;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblNote;
    }
}