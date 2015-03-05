using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SharingThreads
{
    class SharedData
    {
        //public Constructor that implements synchronized queue
        private Queue q;

        public SharedData()
        {
            q = Queue.Synchronized(new Queue());
        }

        public void Enqueue(object o)
        {
            q.Enqueue(o);
        }

        public object Dequeue()
        {
            lock (q.SyncRoot)
            {
                if (q.Count > 0)
                {
                    return q.Dequeue();
                }
            }
            return null;
        }
    }
}
