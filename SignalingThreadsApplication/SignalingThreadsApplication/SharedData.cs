using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;

namespace SignalingThreadsApplication
{
    class SharedData
    {
        Queue<int?> q = null;
        private ManualResetEvent workReadyEvent;
        //public constructor
        public SharedData(ManualResetEvent workReadyEvent)
        {   
            this.workReadyEvent = workReadyEvent;
            this.q = new Queue<int?>();
        }
        public void Enqueue(int? val)
        {
            ICollection c = q;
            lock (c.SyncRoot)
            {
                q.Enqueue(val);
                workReadyEvent.Set();
            }
        }
        //Add a public method called Dequeue with a return of int? (Nullable<int>) and no parameters.
        public int? Dequeue()
        {
            ICollection c = q;
            lock(c.SyncRoot)
            {
                while (q.Count == 0)
                    Monitor.Wait(q);
                return q.Dequeue();
            }
        }
        //Add a public method called Clear.
        public void Clear()
        {
            ICollection c = q;
            lock (c.SyncRoot)
            {
                // Clears the Queue.
                q.Clear();
            }
        }
    }
}
