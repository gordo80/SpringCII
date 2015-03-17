using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Threading;

namespace Signaling_task
{
    class SharedData
    {
        private BlockingCollection<int?> q;
        private CancellationToken Cancel;

        public SharedData(CancellationToken cancel)
        {
            q = new BlockingCollection<int?>();
            this.Cancel = cancel;
        }

        public void Enqueue(int i)
        {
            q.Add(i);
            return;
        }

        public int? Dequeue()
        {
            int? val = null;
            q.TryTake(out val, Timeout.Infinite,this.Cancel);
            return val;
        }
    }
}
