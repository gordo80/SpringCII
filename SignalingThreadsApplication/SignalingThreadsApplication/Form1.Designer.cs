namespace SignalingThreadsApplication
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddWorker = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(34, 36);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(173, 35);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(416, 35);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnAddWorker
            // 
            this.btnAddWorker.Location = new System.Drawing.Point(34, 91);
            this.btnAddWorker.Name = "btnAddWorker";
            this.btnAddWorker.Size = new System.Drawing.Size(75, 23);
            this.btnAddWorker.TabIndex = 3;
            this.btnAddWorker.Text = "Add Worker";
            this.btnAddWorker.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(34, 155);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(457, 251);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 435);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAddWorker);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Signaling Threads Application";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddWorker;
        private System.Windows.Forms.ListBox listBox1;
    }
}

