
namespace Community_Workshop_System
{
    partial class frmReturnedTool
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
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.lbltxt = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblConditionDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCondition
            // 
            this.txtCondition.Location = new System.Drawing.Point(150, 167);
            this.txtCondition.Multiline = true;
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(461, 129);
            this.txtCondition.TabIndex = 0;
            // 
            // lbltxt
            // 
            this.lbltxt.AutoSize = true;
            this.lbltxt.Location = new System.Drawing.Point(147, 55);
            this.lbltxt.Name = "lbltxt";
            this.lbltxt.Size = new System.Drawing.Size(46, 17);
            this.lbltxt.TabIndex = 1;
            this.lbltxt.Text = "label1";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(150, 354);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(118, 43);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click_1);
            // 
            // lblConditionDescription
            // 
            this.lblConditionDescription.AutoSize = true;
            this.lblConditionDescription.Location = new System.Drawing.Point(150, 144);
            this.lblConditionDescription.Name = "lblConditionDescription";
            this.lblConditionDescription.Size = new System.Drawing.Size(146, 17);
            this.lblConditionDescription.TabIndex = 3;
            this.lblConditionDescription.Text = "Condition Description:";
            // 
            // frmReturnedTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblConditionDescription);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lbltxt);
            this.Controls.Add(this.txtCondition);
            this.Name = "frmReturnedTool";
            this.Text = "Returned Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCondition;
        private System.Windows.Forms.Label lbltxt;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblConditionDescription;
    }
}