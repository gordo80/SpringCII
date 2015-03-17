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
            while (true)
            {
                Random rand = new Random();
                Thread.Sleep(100);
                this.shareData.Enqueue(rand.Next());

                for (int rand = 0; rand < length; i++)
                {
                    
                }
            }
        }
    }
}
