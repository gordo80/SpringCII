using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.ManualResetEvent;
using System.Threading;

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
        }
    }
}
