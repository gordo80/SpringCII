using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HomeworkGroupProject
{
    class Customer
    {
        private int m_iCustomerID;
        private int m_iAccountBalence;
        private int m_iCustomerGoalAmount;
        private volatile bool m_bCustomerbusy;
        private object m_OLock;
        private CancellationToken m_CancelToken;

        //TODO : sharath, Is there a better way to store the transaction history
        private List<string> m_CustTxnHist;

        // This property uses lock to gaurd the private variable m_bCustomerBusy
        // Transaction generator need to check the flag before picking the customer for transaction
        // Teller task will make this flag as free.

        public bool IsCustomerbusy
        {
            get 
            {
                lock (m_OLock)
                {
                    return m_bCustomerbusy;
                }
            }
            set
            {
                lock (m_OLock)
                {
                    m_bCustomerbusy = value;
                }
            }
        }

        // There is no need to gaurd this with lock, as:
        // there will be only one transaction generator.
        // Transaction generator will make sure only one transaction per customer in queue at a given of time.
        // And at a time only one Teller will update the Customer balance at a time

        public int AccountBalenceProperty
        {
            get { return m_iAccountBalence; }
            set { m_iAccountBalence = value; }
        }

        public void AddTransactiontoHostory(string sTxnEntry)
        {
            m_CustTxnHist.Add(sTxnEntry);
        }



        //Constructor

        public Customer(int CustomerID,int iInitialAmount, int iCustGoalAmt,CancellationToken CancelToken)
        {
            m_iCustomerID = CustomerID;
            m_iAccountBalence = iInitialAmount;
            m_CancelToken = CancelToken;
            m_bCustomerbusy = false; // Set the customer as free.

            m_iCustomerGoalAmount = iCustGoalAmt;

            //Instanciate an object for acquiring lock.
            //This lock will be per customer basis.
            //Transaction generator should check if customer is busy before picking him for transaction.
            m_OLock = new Object();

            //instanciate a collection of string to store the transaction
            m_CustTxnHist = new List<string>();

        }
    }
}
