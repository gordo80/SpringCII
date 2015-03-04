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
        //static Thread for joining
        //static Thread mainThread, thread1, thread2;
        private ListBox _listBox = new ListBox();
        private volatile bool stop;
        private int _numberOfMessages;
        //Constructor for ListBox and NumberMessages
        public Worker(ListBox listBox, int numberOfMessages) 
        {
            this._listBox = listBox; this._numberOfMessages = numberOfMessages;
        }
        //bool property stop
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
        //This calls the worker to stop
        public void RequestStop()
        {
            stop = true;
        }
        //Add a public method called Join with a bool return and one parameter of type int named timeOut.
        public static bool Join(int timeOut)
        {
            return true;
        }

        //Method for Updating List Box
        private void UpdateListBox(string message)
        {
            if(this._listBox.InvokeRequired)
            {
                Update update = new Update(UpdateListBox);
                this._listBox.Invoke(update, new object[] { message });
            }
            else
            {
                this._listBox.Items.Add(message);
            }
        }

        //ThreadProc Methood 
        private void ThreadProc()
        {
            UpdateListBox("Thread {0} begin." + Thread.CurrentThread.ManagedThreadId);
            
            for (int i = 0; i < this._numberOfMessages; i++)
            {
                if (this.stop == true)
                {
                    break;
                }
                UpdateListBox("{0}. Message." + Thread.CurrentThread.ManagedThreadId);
                i++;
                Thread.Sleep(500);
                UpdateListBox("Thread {0} end." + Thread.CurrentThread.ManagedThreadId);
            }
            //We will later add this method and implement it see step iii
            
        }
    }
}
