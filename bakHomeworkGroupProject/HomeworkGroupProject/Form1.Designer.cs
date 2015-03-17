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
            this.groupTransaction = new System.Windows.Forms.GroupBox();
            this.groupCustomer = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTellers = new System.Windows.Forms.TextBox();
            this.txtCustomers = new System.Windows.Forms.TextBox();
            this.txtIVAmont = new System.Windows.Forms.TextBox();
            this.labelNumberofTellers = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMTAmout = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGoalAmount = new System.Windows.Forms.TextBox();
            this.txtInitialAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.groupBank.Controls.Add(this.txtIVAmont);
            this.groupBank.Controls.Add(this.txtCustomers);
            this.groupBank.Controls.Add(this.txtTellers);
            this.groupBank.Location = new System.Drawing.Point(54, 31);
            this.groupBank.Name = "groupBank";
            this.groupBank.Size = new System.Drawing.Size(295, 117);
            this.groupBank.TabIndex = 0;
            this.groupBank.TabStop = false;
            this.groupBank.Text = "Bank";
            // 
            // groupTransaction
            // 
            this.groupTransaction.Controls.Add(this.label4);
            this.groupTransaction.Controls.Add(this.txtMTAmout);
            this.groupTransaction.Location = new System.Drawing.Point(452, 31);
            this.groupTransaction.Name = "groupTransaction";
            this.groupTransaction.Size = new System.Drawing.Size(387, 100);
            this.groupTransaction.TabIndex = 1;
            this.groupTransaction.TabStop = false;
            this.groupTransaction.Text = "Transaction";
            // 
            // groupCustomer
            // 
            this.groupCustomer.Controls.Add(this.label6);
            this.groupCustomer.Controls.Add(this.label5);
            this.groupCustomer.Controls.Add(this.txtInitialAmount);
            this.groupCustomer.Controls.Add(this.txtGoalAmount);
            this.groupCustomer.Location = new System.Drawing.Point(54, 169);
            this.groupCustomer.Name = "groupCustomer";
            this.groupCustomer.Size = new System.Drawing.Size(785, 86);
            this.groupCustomer.TabIndex = 2;
            this.groupCustomer.TabStop = false;
            this.groupCustomer.Text = "Customer";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(54, 421);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(190, 421);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(776, 421);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(54, 305);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(797, 95);
            this.listBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Transaction History";
            // 
            // txtTellers
            // 
            this.txtTellers.Location = new System.Drawing.Point(136, 19);
            this.txtTellers.Name = "txtTellers";
            this.txtTellers.Size = new System.Drawing.Size(119, 20);
            this.txtTellers.TabIndex = 0;
            // 
            // txtCustomers
            // 
            this.txtCustomers.Location = new System.Drawing.Point(136, 45);
            this.txtCustomers.Name = "txtCustomers";
            this.txtCustomers.Size = new System.Drawing.Size(119, 20);
            this.txtCustomers.TabIndex = 1;
            // 
            // txtIVAmont
            // 
            this.txtIVAmont.Location = new System.Drawing.Point(136, 80);
            this.txtIVAmont.Name = "txtIVAmont";
            this.txtIVAmont.Size = new System.Drawing.Size(119, 20);
            this.txtIVAmont.TabIndex = 2;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of Customers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Initial Vault Amont";
            // 
            // txtMTAmout
            // 
            this.txtMTAmout.Location = new System.Drawing.Point(183, 22);
            this.txtMTAmout.Name = "txtMTAmout";
            this.txtMTAmout.Size = new System.Drawing.Size(163, 20);
            this.txtMTAmout.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Maximum Transaction Amount";
            // 
            // txtGoalAmount
            // 
            this.txtGoalAmount.Location = new System.Drawing.Point(136, 34);
            this.txtGoalAmount.Name = "txtGoalAmount";
            this.txtGoalAmount.Size = new System.Drawing.Size(158, 20);
            this.txtGoalAmount.TabIndex = 0;
            // 
            // txtInitialAmount
            // 
            this.txtInitialAmount.Location = new System.Drawing.Point(581, 34);
            this.txtInitialAmount.Name = "txtInitialAmount";
            this.txtInitialAmount.Size = new System.Drawing.Size(181, 20);
            this.txtInitialAmount.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Goal Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(421, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Initial Amount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 466);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIVAmont;
        private System.Windows.Forms.TextBox txtCustomers;
        private System.Windows.Forms.TextBox txtTellers;
        private System.Windows.Forms.Label labelNumberofTellers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMTAmout;
        private System.Windows.Forms.TextBox txtInitialAmount;
        private System.Windows.Forms.TextBox txtGoalAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

