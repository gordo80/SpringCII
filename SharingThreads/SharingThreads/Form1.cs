using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharingThreads
{
    public partial class Form1 : Form
    {
        private SharedData shareData;
        private ArrayList workers;
        private Random rand;
        public Form1()
        {
            InitializeComponent();
            this.shareData=new SharedData();
            this.workers = new ArrayList();
            this.rand = new Random();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            workers.Add(new Worker(this.shareData, this.listBox1));
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            foreach (Worker worker in this.workers)
            {
                worker.Quit = true;
            }
            workers.Clear();
        }

        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            shareData.Enqueue(rand.Next());
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this.btnStop_Click(this, e);
        }
        
    }
}
