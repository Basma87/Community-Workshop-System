
namespace Community_Workshop_System
{
    partial class Menu
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
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.Datelbl = new System.Windows.Forms.Label();
            this.Titlelbl = new System.Windows.Forms.Label();
            this.btnTools = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnRentedTools = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCustomers
            // 
            this.btnCustomers.AutoSize = true;
            this.btnCustomers.Location = new System.Drawing.Point(118, 178);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(134, 52);
            this.btnCustomers.TabIndex = 0;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Location = new System.Drawing.Point(285, 254);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(134, 52);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Location = new System.Drawing.Point(138, 75);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(38, 17);
            this.Datelbl.TabIndex = 7;
            this.Datelbl.Text = "Date";
            // 
            // Titlelbl
            // 
            this.Titlelbl.AutoSize = true;
            this.Titlelbl.Location = new System.Drawing.Point(138, 27);
            this.Titlelbl.Name = "Titlelbl";
            this.Titlelbl.Size = new System.Drawing.Size(191, 17);
            this.Titlelbl.TabIndex = 6;
            this.Titlelbl.Text = "Community workshop System";
            // 
            // btnTools
            // 
            this.btnTools.AutoSize = true;
            this.btnTools.Location = new System.Drawing.Point(118, 254);
            this.btnTools.Name = "btnTools";
            this.btnTools.Size = new System.Drawing.Size(134, 52);
            this.btnTools.TabIndex = 1;
            this.btnTools.Text = "Tools";
            this.btnTools.UseVisualStyleBackColor = true;
            this.btnTools.Click += new System.EventHandler(this.btnTools_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(285, 178);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(134, 52);
            this.btnSettings.TabIndex = 8;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnRentedTools
            // 
            this.btnRentedTools.Location = new System.Drawing.Point(118, 329);
            this.btnRentedTools.Name = "btnRentedTools";
            this.btnRentedTools.Size = new System.Drawing.Size(134, 52);
            this.btnRentedTools.TabIndex = 9;
            this.btnRentedTools.Text = "Rented Tools";
            this.btnRentedTools.UseVisualStyleBackColor = true;
            this.btnRentedTools.Click += new System.EventHandler(this.btnRentedTools_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 532);
            this.Controls.Add(this.btnRentedTools);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnTools);
            this.Controls.Add(this.Datelbl);
            this.Controls.Add(this.Titlelbl);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCustomers);
            this.MaximumSize = new System.Drawing.Size(574, 579);
            this.MinimumSize = new System.Drawing.Size(574, 579);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Label Titlelbl;
        private System.Windows.Forms.Button btnTools;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnRentedTools;
    }
}

