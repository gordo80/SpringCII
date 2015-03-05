using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharingThreads
{
    class Worker
    {
        private delegate void Update(string message);
        private Thread t;
        private ListBox listbox;
        private volatile bool quit;
        private SharedData shareData;
        public bool Quit { set { quit = value; } }

        public Worker(SharedData shareData, ListBox listbox)
        {
            this.shareData = shareData; this.listbox = listbox;
            t = new Thread(ThreadProc);
            t.IsBackground = true;
            t.Start();
        }

        public void ThreadProc()
        { 
            UpdateListBox(string.Format("Thread {0} started",Thread.CurrentThread.ManagedThreadId));

            try
            {
                while (!this.quit)
                {
                    object o = shareData.Dequeue();
                    if (o != null)
                    {
                        UpdateListBox(string.Format("{0}", o));
                    }
                    Thread.Sleep(1);

                }
            }
            catch (ThreadInterruptedException tie)
            {
                UpdateListBox(tie.ToString());
            }
            catch (ThreadAbortException tae)
            {
                UpdateListBox(tae.ToString());
            }
            finally
            { 
                UpdateListBox(string.Format("Thread {0} stopped",Thread.CurrentThread.ManagedThreadId));
            }
        }

        private void UpdateListBox(string message)
        {
            if (this.listbox.InvokeRequired)
            {
                Update u = UpdateListBox;
                this.listbox.Invoke(u,message);
            }
            else
            {
                this.listbox.Items.Add(message);
            }
        }
    }
}
