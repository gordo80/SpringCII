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
        private Thread thread = new Thread(new ThreadStart(ThreadProc));
        //static Thread for joining
        static Thread mainThread, thread1, thread2;
        private ListBox _listBox = new ListBox();
        private volatile bool stop;
        private int _numberOfMessages;
        //Constructor for ListBox and NumberMessages
        public Worker(ListBox listBox, int numberOfMessages) 
        {
            this._listBox = listBox; this._numberOfMessages = numberOfMessages;
        }
        //To access Listbox parameter
        //public ListBox WorkersListBox
        //{
        //    get
        //    {
        //        return this._listBox;
        //    }
        //    set
        //    {
        //        // Can only be called in this class.
        //        this._listBox = value;
        //    }
        //}
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

        //ThreadProc Methood
        public static void ThreadProc()
        {
             //We will later add this method and implement it see step iii
            Thread.Sleep(1000);
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
                
            }
        }
    }
}
