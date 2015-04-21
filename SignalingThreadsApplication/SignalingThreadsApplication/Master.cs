using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace SignalingThreadsApplication
{
    class Master
    {
        private ListBoxHelper lbh;
        private ManualResetEvent manualResetEvent;
        private SharedData shareData;
        private Thread thread;
        //Constructor
        public Master(ListBoxHelper lbh, ManualResetEvent manualResetEvent, SharedData shareData)
        {
            this.lbh = lbh; this.manualResetEvent = manualResetEvent; this.shareData = shareData;
            thread = new Thread(ThreadProc);
            thread.IsBackground = true;
            thread.Start();
        }

        private void ThreadProc()
        {
            
            Random rand = new Random();
            try
            {
                while (true)
                {
                    
                    Thread.Sleep(100);

                    for (int i = 0; i < 21; i++)
                    {
                        //message stating how many integers it has processed since it started
                        shareData.Enqueue(rand.Next());
                        
                        lbh.AddString(string.Format("Number of threads started: {0}", Thread.CurrentThread.ManagedThreadId));
                    }
                    lbh.AddString("Master.ThreadProc requested to stop.");
                    manualResetEvent.WaitOne(1);
                    // Implement ThreadInterruptException and ThreadAbortException
                    //code to display here:
                }
            }
            catch (ThreadInterruptedException tie)
            {
                lbh.AddString(tie.ToString());
            }
            catch (ThreadAbortException tae)
            {
                lbh.AddString(tae.ToString());
            }
            finally
            {
                lbh.AddString(string.Format("Thread {0} stopped", Thread.CurrentThread.ManagedThreadId));
            }
        }
    }
}
