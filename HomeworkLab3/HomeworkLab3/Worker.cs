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
            thread.Join(timeOut);
            return thread.Join(timeOut);
        }
        //ThreadProc Methood 
        private void ThreadProc()
        {
            UpdateListBox(string.Format("Thread {0} begin.",Thread.CurrentThread.ManagedThreadId));

            for (int i = 0; i < this.numberOfMessages; i++)
            {
                if (this.stop == true)
                {
                    break;
                }
                UpdateListBox(string.Format("{0}. Message." , Thread.CurrentThread.ManagedThreadId));
                i++;
                Thread.Sleep(500);
                UpdateListBox(string.Format("Thread {0} end." ,Thread.CurrentThread.ManagedThreadId));
            }
        }        
       
        private void UpdateListBox(string message)
        {
            if(this.listBox.InvokeRequired)
            {
                Update update = new Update(UpdateListBox);
                this.listBox.Invoke(update, message);
            }
            else
            {
                this.listBox.Items.Add(message);
            }
        }
    }
}
