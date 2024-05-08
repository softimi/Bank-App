namespace week4_BankAPP.User_Inerface
{
    partial class CheckBalanceForm
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
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblFullname = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.Location = new System.Drawing.Point(194, 77);
            this.lblAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(98, 20);
            this.lblAccount.TabIndex = 1;
            this.lblAccount.Text = "account no";
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Location = new System.Drawing.Point(214, 107);
            this.lblFullname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(33, 13);
            this.lblFullname.TabIndex = 2;
            this.lblFullname.Text = "name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblAccount);
            this.panel1.Controls.Add(this.lblAccountType);
            this.panel1.Location = new System.Drawing.Point(67, 147);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 152);
            this.panel1.TabIndex = 4;
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Location = new System.Drawing.Point(185, 21);
            this.lblAccountType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(89, 13);
            this.lblAccountType.TabIndex = 0;
            this.lblAccountType.Text = "Account Balance";
            // 
            // CheckBalanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 548);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblFullname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(367, 74);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CheckBalanceForm";
            this.Text = "CheckBalanceForm";
            this.Load += new System.EventHandler(this.CheckBalanceForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAccountType;
    }
}