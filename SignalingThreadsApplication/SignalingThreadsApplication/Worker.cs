using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SignalingThreadsApplication
{
    class Worker
    {
        private ListBoxHelper lbh;
        private ManualResetEvent quitEvent;
        private ManualResetEvent workToDoEvent;
        private SharedData shareData;
        // Check pause state
        public bool IsPaused { get { return !quitEvent.WaitOne(1); } }
        private Thread thread;
        public Worker(ListBoxHelper lbh, ManualResetEvent quitEvent, ManualResetEvent workToDoEvent,SharedData shareData)
        {
            this.lbh = lbh;
            this.quitEvent = quitEvent;
            this.workToDoEvent = workToDoEvent;
            this.shareData = shareData;
            thread = new Thread(ThreadProc);
            thread.IsBackground =true;
            thread.Start();
        }
        private void ThreadProc()
        {
            while (true)
            {
                quitEvent = new ManualResetEvent(false);
                quitEvent.WaitOne(1);
                quitEvent.Set();
                shareData.Dequeue();
                lbh.AddString(string.Format("Here is the number of integers that have been started on the thread:", 
                Thread.CurrentThread.ManagedThreadId));
                if (IsPaused !=false)
                {
                    //string message reporting the thread’s ManagedThreadId and “requested to stop.”
                    lbh.AddString(string.Format("Threaad requested to stop!!",
                    Thread.CurrentThread.ManagedThreadId));
                    return;
                }
            }
        }
    }
}
