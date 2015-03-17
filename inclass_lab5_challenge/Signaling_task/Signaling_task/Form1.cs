using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Signaling_task
{
    public partial class Form1 : Form
    {
        private SynchronizationContext syncContext;
        private delegate void UpdateListBox(string msg);
        private CancellationTokenSource cts;
        private SharedData shared;
        private Master master;
        private AutoResetEvent genVal;

        public Form1()
        {
            InitializeComponent();
            
            syncContext = WindowsFormsSynchronizationContext.Current;
            genVal = new AutoResetEvent(false);
                       
            
        }

        public void UpdateList(string msg)
        {
            syncContext.Send(o=>{
                this.listBox1.Items.Add(msg);
                this.listBox1.SelectedIndex = -1;},msg);
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            cts = new CancellationTokenSource();
            shared = new SharedData(cts.Token);
            this.master = new Master(cts.Token, shared, this, genVal); 

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.cts.Cancel();
        }

        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            new Worker(this.cts.Token, this.shared, this);
        }

        private void btnAddVal_Click(object sender, EventArgs e)
        {
            this.genVal.Set();
        }
    }
}
