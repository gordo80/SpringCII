namespace HomeworkGroupProject
{
    partial class Form1
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
            this.groupBank = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNumberofTellers = new System.Windows.Forms.Label();
            this.txtInitVaultAmt = new System.Windows.Forms.TextBox();
            this.txtCustomers = new System.Windows.Forms.TextBox();
            this.txtTellers = new System.Windows.Forms.TextBox();
            this.groupTransaction = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaxTxnAmout = new System.Windows.Forms.TextBox();
            this.groupCustomer = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustInitialAmount = new System.Windows.Forms.TextBox();
            this.txtCustGoalAmount = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBank.SuspendLayout();
            this.groupTransaction.SuspendLayout();
            this.groupCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBank
            // 
            this.groupBank.Controls.Add(this.label3);
            this.groupBank.Controls.Add(this.label2);
            this.groupBank.Controls.Add(this.labelNumberofTellers);
            this.groupBank.Controls.Add(this.txtInitVaultAmt);
            this.groupBank.Controls.Add(this.txtCustomers);
            this.groupBank.Controls.Add(this.txtTellers);
            this.groupBank.Location = new System.Drawing.Point(54, 5);
            this.groupBank.Name = "groupBank";
            this.groupBank.Size = new System.Drawing.Size(338, 129);
            this.groupBank.TabIndex = 0;
            this.groupBank.TabStop = false;
            this.groupBank.Text = "Bank";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Initial Vault Amont";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of Customers";
            // 
            // labelNumberofTellers
            // 
            this.labelNumberofTellers.AutoSize = true;
            this.labelNumberofTellers.Location = new System.Drawing.Point(7, 25);
            this.labelNumberofTellers.Name = "labelNumberofTellers";
            this.labelNumberofTellers.Size = new System.Drawing.Size(90, 13);
            this.labelNumberofTellers.TabIndex = 3;
            this.labelNumberofTellers.Text = "Number of Tellers";
            // 
            // txtInitVaultAmt
            // 
            this.txtInitVaultAmt.Location = new System.Drawing.Point(165, 84);
            this.txtInitVaultAmt.Name = "txtInitVaultAmt";
            this.txtInitVaultAmt.Size = new System.Drawing.Size(119, 20);
            this.txtInitVaultAmt.TabIndex = 2;
            this.txtInitVaultAmt.Text = "5000";
            // 
            // txtCustomers
            // 
            this.txtCustomers.Location = new System.Drawing.Point(165, 49);
            this.txtCustomers.Name = "txtCustomers";
            this.txtCustomers.Size = new System.Drawing.Size(119, 20);
            this.txtCustomers.TabIndex = 1;
            this.txtCustomers.Text = "20";
            // 
            // txtTellers
            // 
            this.txtTellers.Location = new System.Drawing.Point(165, 19);
            this.txtTellers.Name = "txtTellers";
            this.txtTellers.Size = new System.Drawing.Size(119, 20);
            this.txtTellers.TabIndex = 0;
            this.txtTellers.Text = "5";
            // 
            // groupTransaction
            // 
            this.groupTransaction.Controls.Add(this.label4);
            this.groupTransaction.Controls.Add(this.txtMaxTxnAmout);
            this.groupTransaction.Location = new System.Drawing.Point(452, 5);
            this.groupTransaction.Name = "groupTransaction";
            this.groupTransaction.Size = new System.Drawing.Size(399, 53);
            this.groupTransaction.TabIndex = 1;
            this.groupTransaction.TabStop = false;
            this.groupTransaction.Text = "Transaction";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Maximum Transaction Amount";
            // 
            // txtMaxTxnAmout
            // 
            this.txtMaxTxnAmout.Location = new System.Drawing.Point(224, 19);
            this.txtMaxTxnAmout.Name = "txtMaxTxnAmout";
            this.txtMaxTxnAmout.Size = new System.Drawing.Size(117, 20);
            this.txtMaxTxnAmout.TabIndex = 0;
            this.txtMaxTxnAmout.Text = "100";
            // 
            // groupCustomer
            // 
            this.groupCustomer.Controls.Add(this.label6);
            this.groupCustomer.Controls.Add(this.label5);
            this.groupCustomer.Controls.Add(this.txtCustInitialAmount);
            this.groupCustomer.Controls.Add(this.txtCustGoalAmount);
            this.groupCustomer.Location = new System.Drawing.Point(452, 64);
            this.groupCustomer.Name = "groupCustomer";
            this.groupCustomer.Size = new System.Drawing.Size(399, 70);
            this.groupCustomer.TabIndex = 2;
            this.groupCustomer.TabStop = false;
            this.groupCustomer.Text = "Customer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Initial Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Goal Amount";
            // 
            // txtCustInitialAmount
            // 
            this.txtCustInitialAmount.Location = new System.Drawing.Point(224, 44);
            this.txtCustInitialAmount.Name = "txtCustInitialAmount";
            this.txtCustInitialAmount.Size = new System.Drawing.Size(117, 20);
            this.txtCustInitialAmount.TabIndex = 1;
            this.txtCustInitialAmount.Text = "100";
            // 
            // txtCustGoalAmount
            // 
            this.txtCustGoalAmount.Location = new System.Drawing.Point(224, 18);
            this.txtCustGoalAmount.Name = "txtCustGoalAmount";
            this.txtCustGoalAmount.Size = new System.Drawing.Size(117, 20);
            this.txtCustGoalAmount.TabIndex = 0;
            this.txtCustGoalAmount.Text = "2000";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(54, 640);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(95, 34);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(182, 640);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(91, 34);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(755, 640);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 34);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.Location = new System.Drawing.Point(54, 188);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(797, 433);
            this.ListBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Transaction History";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 699);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupCustomer);
            this.Controls.Add(this.groupTransaction);
            this.Controls.Add(this.groupBank);
            this.Name = "Form1";
            this.Text = "Bank Teller Simulation";
            this.groupBank.ResumeLayout(false);
            this.groupBank.PerformLayout();
            this.groupTransaction.ResumeLayout(false);
            this.groupTransaction.PerformLayout();
            this.groupCustomer.ResumeLayout(false);
            this.groupCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBank;
        private System.Windows.Forms.GroupBox groupTransaction;
        private System.Windows.Forms.GroupBox groupCustomer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInitVaultAmt;
        private System.Windows.Forms.TextBox txtCustomers;
        private System.Windows.Forms.TextBox txtTellers;
        private System.Windows.Forms.Label labelNumberofTellers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaxTxnAmout;
        private System.Windows.Forms.TextBox txtCustInitialAmount;
        private System.Windows.Forms.TextBox txtCustGoalAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

