using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignalingThreadsApplication
{
    public partial class Form1 : Form
    {
        private ManualResetEvent quitEvent;
        private ManualResetEvent workToDoEvent;
        private SharedData shareData;
        private ListBoxHelper listBoxHelper;
        
        public Form1()
        {
            InitializeComponent();
            quitEvent = new ManualResetEvent(false);
            quitEvent.Set();
            workToDoEvent = new ManualResetEvent(false);
            workToDoEvent.Set();
            this.shareData = new SharedData(quitEvent);
            this.listBoxHelper=new ListBoxHelper(listBox1);

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                quitEvent.Reset();
                workToDoEvent.Reset();
                this.shareData.Clear();
                Master master = new Master(this.listBoxHelper, this.workToDoEvent, this.shareData);
                
            }
            catch (Exception)
            {

                MessageBox.Show("Error while runing the Threaad");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            quitEvent.Set();
            quitEvent.Close();
            
        }

        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            Worker worker = new Worker(this.listBoxHelper, this.quitEvent, this.workToDoEvent, this.shareData);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.shareData.Clear();
        }
    }
}
