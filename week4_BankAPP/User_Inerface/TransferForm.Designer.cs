﻿namespace week4_BankAPP.User_Inerface
{
    partial class TransferForm
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
            this.txtAccountTrf = new System.Windows.Forms.TextBox();
            this.txtAmountTrf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.errorMsgTransfer = new System.Windows.Forms.Label();
            this.successMsgTransfer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAccountTrf
            // 
            this.txtAccountTrf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountTrf.Location = new System.Drawing.Point(304, 158);
            this.txtAccountTrf.Name = "txtAccountTrf";
            this.txtAccountTrf.Size = new System.Drawing.Size(317, 30);
            this.txtAccountTrf.TabIndex = 0;
            // 
            // txtAmountTrf
            // 
            this.txtAmountTrf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountTrf.Location = new System.Drawing.Point(304, 213);
            this.txtAmountTrf.Name = "txtAmountTrf";
            this.txtAmountTrf.Size = new System.Drawing.Size(317, 30);
            this.txtAmountTrf.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Account:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Amount:";
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(371, 314);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(130, 48);
            this.btnTransfer.TabIndex = 4;
            this.btnTransfer.Text = "TRANSFER";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // errorMsgTransfer
            // 
            this.errorMsgTransfer.AutoSize = true;
            this.errorMsgTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMsgTransfer.ForeColor = System.Drawing.Color.Red;
            this.errorMsgTransfer.Location = new System.Drawing.Point(349, 246);
            this.errorMsgTransfer.Name = "errorMsgTransfer";
            this.errorMsgTransfer.Size = new System.Drawing.Size(163, 25);
            this.errorMsgTransfer.TabIndex = 5;
            this.errorMsgTransfer.Text = "errorMsgTransfer";
            // 
            // successMsgTransfer
            // 
            this.successMsgTransfer.AutoSize = true;
            this.successMsgTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successMsgTransfer.ForeColor = System.Drawing.Color.Green;
            this.successMsgTransfer.Location = new System.Drawing.Point(366, 85);
            this.successMsgTransfer.Name = "successMsgTransfer";
            this.successMsgTransfer.Size = new System.Drawing.Size(84, 25);
            this.successMsgTransfer.TabIndex = 6;
            this.successMsgTransfer.Text = "success";
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 674);
            this.Controls.Add(this.successMsgTransfer);
            this.Controls.Add(this.errorMsgTransfer);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAmountTrf);
            this.Controls.Add(this.txtAccountTrf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(367, 74);
            this.Name = "TransferForm";
            this.Text = "TransferForm";
            this.Load += new System.EventHandler(this.TransferForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAccountTrf;
        private System.Windows.Forms.TextBox txtAmountTrf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Label errorMsgTransfer;
        private System.Windows.Forms.Label successMsgTransfer;
    }
}