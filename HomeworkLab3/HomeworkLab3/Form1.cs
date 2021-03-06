﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeworkLab3
{
    public partial class Form1 : Form
    {
        private Worker worker;        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.worker = new Worker(listBox1, 10);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (this.worker != null)
            {
                worker.Stop =true;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
        //Onclosing protected method
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (this.worker != null)
            {
                worker.Join(2000);

            }
            if (worker.Join(2000) == false)
            {
                MessageBox.Show("Worker failed to exit in 2000 milliseconds");
            }
        }
    }
}
