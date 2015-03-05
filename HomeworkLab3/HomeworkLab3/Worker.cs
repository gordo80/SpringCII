using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace HomeworkLab3
{
    class Worker
    {
        private delegate void Update(string message);
        private Thread thread;
        private ListBox listBox = new ListBox();
        private volatile bool stop;
        private int numberOfMessages;
        
        //Constructor 
        public Worker(ListBox listBox, int numberOfMessages) 
        {
            this.listBox = listBox; this.numberOfMessages = numberOfMessages;
            ThreadStart threadDelegate = new ThreadStart(ThreadProc);
            thread = new Thread(threadDelegate);
            thread.IsBackground = true;
            thread.Start();
        }
        public bool Stop
        {
            get
            {
                return this.stop;
            }
            set
            {
                // Can only be called in this class.
                this.stop = value;
            }
        }
        //Add a public method called Join with a bool return and one parameter of type int named timeOut.
        public bool Join(int timeOut)
        {
            return true;
        }
        //ThreadProc Methood 
        private void ThreadProc()
        {
            //UpdateListBox("Thread {0} begin." + Thread.CurrentThread.ManagedThreadId);

            //for (int i = 0; i < this._numberOfMessages; i++)
            //{
            //    if (this.stop == true)
            //    {
            //        break;
            //    }
            //    UpdateListBox("{0}. Message." + Thread.CurrentThread.ManagedThreadId);
            //    i++;
            //    Thread.Sleep(500);
            //    UpdateListBox("Thread {0} end." + Thread.CurrentThread.ManagedThreadId);
            //}
            //We will later add this method and implement it see step iii

        }        
        //This calls the worker to stop
        public void RequestStop()
        {
            stop = true;
        }
        

        //Method for Updating List Box
        private void UpdateListBox(string message)
        {
            if(this.listBox.InvokeRequired)
            {
                Update update = new Update(UpdateListBox);
                this.listBox.Invoke(update, new object[] { message });
            }
            else
            {
                this.listBox.Items.Add(message);
            }
        }
    }
}
