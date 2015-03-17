using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bank_sim_sharath
{
    class Queue
    {
        private CancellationToken m_Canceltoken;
        private BlockingCollection<Transaction> m_BankQueue;

        public Queue(CancellationToken CancelToken)
        {
            m_Canceltoken = CancelToken;
            m_BankQueue = new BlockingCollection<Transaction>();

            //instanciate a blocking Queue
        }
    }
}
