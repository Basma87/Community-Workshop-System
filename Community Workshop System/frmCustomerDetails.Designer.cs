
namespace Community_Workshop_System
{
    partial class frmCustomerDetails
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lastTxtbox = new System.Windows.Forms.TextBox();
            this.firstTxtbox = new System.Windows.Forms.TextBox();
            this.phoneTxtbox = new System.Windows.Forms.TextBox();
            this.LastNameLbl = new System.Windows.Forms.Label();
            this.FirstNamelbl = new System.Windows.Forms.Label();
            this.phonelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(44, 207);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(192, 207);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lastTxtbox
            // 
            this.lastTxtbox.Location = new System.Drawing.Point(130, 46);
            this.lastTxtbox.Name = "lastTxtbox";
            this.lastTxtbox.Size = new System.Drawing.Size(141, 22);
            this.lastTxtbox.TabIndex = 2;
            // 
            // firstTxtbox
            // 
            this.firstTxtbox.Location = new System.Drawing.Point(130, 89);
            this.firstTxtbox.Name = "firstTxtbox";
            this.firstTxtbox.Size = new System.Drawing.Size(141, 22);
            this.firstTxtbox.TabIndex = 3;
            // 
            // phoneTxtbox
            // 
            this.phoneTxtbox.Location = new System.Drawing.Point(130, 132);
            this.phoneTxtbox.Name = "phoneTxtbox";
            this.phoneTxtbox.Size = new System.Drawing.Size(141, 22);
            this.phoneTxtbox.TabIndex = 4;
            // 
            // LastNameLbl
            // 
            this.LastNameLbl.AutoSize = true;
            this.LastNameLbl.Location = new System.Drawing.Point(41, 46);
            this.LastNameLbl.Name = "LastNameLbl";
            this.LastNameLbl.Size = new System.Drawing.Size(84, 17);
            this.LastNameLbl.TabIndex = 6;
            this.LastNameLbl.Text = "Last Name: ";
            // 
            // FirstNamelbl
            // 
            this.FirstNamelbl.AutoSize = true;
            this.FirstNamelbl.Location = new System.Drawing.Point(41, 89);
            this.FirstNamelbl.Name = "FirstNamelbl";
            this.FirstNamelbl.Size = new System.Drawing.Size(84, 17);
            this.FirstNamelbl.TabIndex = 7;
            this.FirstNamelbl.Text = "First Name: ";
            // 
            // phonelbl
            // 
            this.phonelbl.AutoSize = true;
            this.phonelbl.Location = new System.Drawing.Point(41, 132);
            this.phonelbl.Name = "phonelbl";
            this.phonelbl.Size = new System.Drawing.Size(57, 17);
            this.phonelbl.TabIndex = 8;
            this.phonelbl.Text = "Phone: ";
            // 
            // frmCustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 342);
            this.Controls.Add(this.phonelbl);
            this.Controls.Add(this.FirstNamelbl);
            this.Controls.Add(this.LastNameLbl);
            this.Controls.Add(this.phoneTxtbox);
            this.Controls.Add(this.firstTxtbox);
            this.Controls.Add(this.lastTxtbox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmCustomerDetails";
            this.Text = "Add / Edit Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox lastTxtbox;
        private System.Windows.Forms.TextBox firstTxtbox;
        private System.Windows.Forms.TextBox phoneTxtbox;
        private System.Windows.Forms.Label LastNameLbl;
        private System.Windows.Forms.Label FirstNamelbl;
        private System.Windows.Forms.Label phonelbl;
    }
}