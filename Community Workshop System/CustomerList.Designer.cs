
namespace Community_Workshop_System
{
    partial class CustomerList
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
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtBox_Search = new System.Windows.Forms.TextBox();
            this.radbtn_firstName = new System.Windows.Forms.RadioButton();
            this.radbtn_lastName = new System.Windows.Forms.RadioButton();
            this.btnMainForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(3, 201);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.RowTemplate.Height = 24;
            this.dgvCustomers.Size = new System.Drawing.Size(853, 204);
            this.dgvCustomers.TabIndex = 0;
            this.dgvCustomers.DoubleClick += new System.EventHandler(this.dgvCustomers_DoubleClick);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(723, 634);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 41);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(190, 562);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 48);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Customer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Location = new System.Drawing.Point(46, 562);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(111, 48);
            this.btnNewCustomer.TabIndex = 3;
            this.btnNewCustomer.Text = "Add new / Edit customer";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Community workshop System";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(26, 79);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(86, 17);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "System.date";
            // 
            // txtBox_Search
            // 
            this.txtBox_Search.Location = new System.Drawing.Point(269, 160);
            this.txtBox_Search.Multiline = true;
            this.txtBox_Search.Name = "txtBox_Search";
            this.txtBox_Search.Size = new System.Drawing.Size(160, 25);
            this.txtBox_Search.TabIndex = 8;
            this.txtBox_Search.Text = "Customer Name...";
            this.txtBox_Search.TextChanged += new System.EventHandler(this.txtBox_Search_TextChanged);
            this.txtBox_Search.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // radbtn_firstName
            // 
            this.radbtn_firstName.AutoSize = true;
            this.radbtn_firstName.Location = new System.Drawing.Point(29, 161);
            this.radbtn_firstName.Name = "radbtn_firstName";
            this.radbtn_firstName.Size = new System.Drawing.Size(97, 21);
            this.radbtn_firstName.TabIndex = 9;
            this.radbtn_firstName.TabStop = true;
            this.radbtn_firstName.Text = "First Name";
            this.radbtn_firstName.UseVisualStyleBackColor = true;
            // 
            // radbtn_lastName
            // 
            this.radbtn_lastName.AutoSize = true;
            this.radbtn_lastName.Location = new System.Drawing.Point(146, 161);
            this.radbtn_lastName.Name = "radbtn_lastName";
            this.radbtn_lastName.Size = new System.Drawing.Size(88, 21);
            this.radbtn_lastName.TabIndex = 10;
            this.radbtn_lastName.TabStop = true;
            this.radbtn_lastName.Text = "SurName";
            this.radbtn_lastName.UseVisualStyleBackColor = true;
            // 
            // btnMainForm
            // 
            this.btnMainForm.Location = new System.Drawing.Point(643, 79);
            this.btnMainForm.Name = "btnMainForm";
            this.btnMainForm.Size = new System.Drawing.Size(139, 29);
            this.btnMainForm.TabIndex = 11;
            this.btnMainForm.Text = "Back to main Form";
            this.btnMainForm.UseVisualStyleBackColor = true;
            this.btnMainForm.Click += new System.EventHandler(this.btnMainForm_Click);
            // 
            // CustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(859, 687);
            this.Controls.Add(this.btnMainForm);
            this.Controls.Add(this.radbtn_lastName);
            this.Controls.Add(this.radbtn_firstName);
            this.Controls.Add(this.txtBox_Search);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewCustomer);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvCustomers);
            this.Name = "CustomerList";
            this.Text = "CustomerList";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtBox_Search;
        private System.Windows.Forms.RadioButton radbtn_firstName;
        private System.Windows.Forms.RadioButton radbtn_lastName;
        private System.Windows.Forms.Button btnMainForm;
    }
}