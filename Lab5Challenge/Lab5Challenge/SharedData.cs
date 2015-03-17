using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace Lab5Challenge
{
    class SharedData
    {   
        private System.Collections.Concurrent.BlockingCollection<int>? q;
        private CancellationToken cancelToken;

        public SharedData(CancellationToken cancelToken)
        {
            q = new BlockingCollection<int>();
            this.cancelToken = cancelToken;
        }
        public void Enqueue(int i)
        {
            q.Add(i);
        }
    }
}
