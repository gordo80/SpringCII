using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeworkGroupProject
{
    class BankQueue
    {
        private CancellationToken m_Canceltoken;
        private BlockingCollection<Transaction> m_BankQueue;

        public BankQueue(CancellationToken CancelToken)
        {
            m_Canceltoken = CancelToken;
            //instanciate a blocking Queue
            m_BankQueue = new BlockingCollection<Transaction>();
        }

        public void Enqueue(Transaction OTransaction)
        {
            m_BankQueue.Add(OTransaction);

        }

        public Transaction Dequeue()
        {
            try
            {
                Transaction myTransaction;
                m_BankQueue.TryTake(out myTransaction, Timeout.Infinite, this.m_Canceltoken);
                return myTransaction;
            }
            catch (Exception E)
            {
                Console.WriteLine(E);//TBD remove this
                //TBD Print the error message with exception
                return null;
            }
        }
    }
}
