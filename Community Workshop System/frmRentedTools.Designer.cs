
namespace Community_Workshop_System
{
    partial class frmRentedTools
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
            this.dgvRentedTools = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddNewRent = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnMultiRentals = new System.Windows.Forms.Button();
            this.btnMultiReturns = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentedTools)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRentedTools
            // 
            this.dgvRentedTools.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRentedTools.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentedTools.Location = new System.Drawing.Point(12, 12);
            this.dgvRentedTools.Name = "dgvRentedTools";
            this.dgvRentedTools.RowHeadersWidth = 51;
            this.dgvRentedTools.RowTemplate.Height = 24;
            this.dgvRentedTools.Size = new System.Drawing.Size(971, 551);
            this.dgvRentedTools.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(863, 592);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 44);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddNewRent
            // 
            this.btnAddNewRent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddNewRent.Location = new System.Drawing.Point(12, 592);
            this.btnAddNewRent.Name = "btnAddNewRent";
            this.btnAddNewRent.Size = new System.Drawing.Size(156, 44);
            this.btnAddNewRent.TabIndex = 2;
            this.btnAddNewRent.Text = "Add New Rent";
            this.btnAddNewRent.UseVisualStyleBackColor = true;
            this.btnAddNewRent.Click += new System.EventHandler(this.btnAddNewRent_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReturn.Location = new System.Drawing.Point(174, 592);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(156, 44);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnMultiRentals
            // 
            this.btnMultiRentals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMultiRentals.Location = new System.Drawing.Point(408, 592);
            this.btnMultiRentals.Name = "btnMultiRentals";
            this.btnMultiRentals.Size = new System.Drawing.Size(156, 44);
            this.btnMultiRentals.TabIndex = 4;
            this.btnMultiRentals.Text = "Multi rentals";
            this.btnMultiRentals.UseVisualStyleBackColor = true;
            this.btnMultiRentals.Click += new System.EventHandler(this.btnMultiRentals_Click);
            // 
            // btnMultiReturns
            // 
            this.btnMultiReturns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMultiReturns.Location = new System.Drawing.Point(570, 592);
            this.btnMultiReturns.Name = "btnMultiReturns";
            this.btnMultiReturns.Size = new System.Drawing.Size(156, 44);
            this.btnMultiReturns.TabIndex = 5;
            this.btnMultiReturns.Text = "Multi Returns";
            this.btnMultiReturns.UseVisualStyleBackColor = true;
            this.btnMultiReturns.Click += new System.EventHandler(this.btnMultiReturns_Click);
            // 
            // frmRentedTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 668);
            this.Controls.Add(this.btnMultiReturns);
            this.Controls.Add(this.btnMultiRentals);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddNewRent);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvRentedTools);
            this.Name = "frmRentedTools";
            this.Text = "Rented Tools";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentedTools)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRentedTools;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddNewRent;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnMultiRentals;
        private System.Windows.Forms.Button btnMultiReturns;
    }
}