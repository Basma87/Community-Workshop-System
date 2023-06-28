
namespace Community_Workshop_System
{
    partial class Add_New_Tool
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
            this.txtboxProductNumber = new System.Windows.Forms.TextBox();
            this.txtboxProductName = new System.Windows.Forms.TextBox();
            this.txtBoxBrand = new System.Windows.Forms.TextBox();
            this.txtboxCondition = new System.Windows.Forms.TextBox();
            this.lblProductNumber = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblCurrentCondition = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboStatusList = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtboxProductNumber
            // 
            this.txtboxProductNumber.Location = new System.Drawing.Point(168, 64);
            this.txtboxProductNumber.Multiline = true;
            this.txtboxProductNumber.Name = "txtboxProductNumber";
            this.txtboxProductNumber.Size = new System.Drawing.Size(178, 41);
            this.txtboxProductNumber.TabIndex = 0;
            // 
            // txtboxProductName
            // 
            this.txtboxProductName.Location = new System.Drawing.Point(168, 126);
            this.txtboxProductName.Multiline = true;
            this.txtboxProductName.Name = "txtboxProductName";
            this.txtboxProductName.Size = new System.Drawing.Size(178, 41);
            this.txtboxProductName.TabIndex = 1;
            // 
            // txtBoxBrand
            // 
            this.txtBoxBrand.Location = new System.Drawing.Point(168, 188);
            this.txtBoxBrand.Multiline = true;
            this.txtBoxBrand.Name = "txtBoxBrand";
            this.txtBoxBrand.Size = new System.Drawing.Size(178, 41);
            this.txtBoxBrand.TabIndex = 2;
            // 
            // txtboxCondition
            // 
            this.txtboxCondition.Location = new System.Drawing.Point(168, 250);
            this.txtboxCondition.Multiline = true;
            this.txtboxCondition.Name = "txtboxCondition";
            this.txtboxCondition.Size = new System.Drawing.Size(178, 41);
            this.txtboxCondition.TabIndex = 3;
            // 
            // lblProductNumber
            // 
            this.lblProductNumber.AutoSize = true;
            this.lblProductNumber.Location = new System.Drawing.Point(33, 67);
            this.lblProductNumber.Name = "lblProductNumber";
            this.lblProductNumber.Size = new System.Drawing.Size(111, 17);
            this.lblProductNumber.TabIndex = 4;
            this.lblProductNumber.Text = "Product Number";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(33, 128);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(98, 17);
            this.lblProductName.TabIndex = 5;
            this.lblProductName.Text = "Product Name";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(33, 189);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(78, 17);
            this.lblBrand.TabIndex = 6;
            this.lblBrand.Text = "Tool Brand";
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrentCondition
            // 
            this.lblCurrentCondition.AutoSize = true;
            this.lblCurrentCondition.Location = new System.Drawing.Point(33, 250);
            this.lblCurrentCondition.Name = "lblCurrentCondition";
            this.lblCurrentCondition.Size = new System.Drawing.Size(67, 17);
            this.lblCurrentCondition.TabIndex = 7;
            this.lblCurrentCondition.Text = "Condition";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Status";
            // 
            // cboStatusList
            // 
            this.cboStatusList.FormattingEnabled = true;
            this.cboStatusList.Location = new System.Drawing.Point(168, 312);
            this.cboStatusList.Name = "cboStatusList";
            this.cboStatusList.Size = new System.Drawing.Size(178, 24);
            this.cboStatusList.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(99, 400);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 41);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add Tool";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Add_New_Tool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 487);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboStatusList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCurrentCondition);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblProductNumber);
            this.Controls.Add(this.txtboxCondition);
            this.Controls.Add(this.txtBoxBrand);
            this.Controls.Add(this.txtboxProductName);
            this.Controls.Add(this.txtboxProductNumber);
            this.Name = "Add_New_Tool";
            this.Text = "Add_New_Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxProductNumber;
        private System.Windows.Forms.TextBox txtboxProductName;
        private System.Windows.Forms.TextBox txtBoxBrand;
        private System.Windows.Forms.TextBox txtboxCondition;
        private System.Windows.Forms.Label lblProductNumber;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblCurrentCondition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboStatusList;
        private System.Windows.Forms.Button btnAdd;
    }
}