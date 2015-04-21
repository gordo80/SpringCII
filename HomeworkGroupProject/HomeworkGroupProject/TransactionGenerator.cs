using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeworkGroupProject
{
    class TransactionGenerator
    {
        //private int transactionAmount;
        //private int deposit_withdraw;
        //private int selectCustomers;
        private Random randCust;
        private Random randTxnAmount;
        private Random randTxnType;
        private Task task;
        private CancellationToken cancelToken;
        private Form1 form;
        //private AutoResetEvent resetEvent;
        private BankQueue bankqueue;
        private Customer[] customerArray;
        private int iMaxTransactionAmount;
        
        public TransactionGenerator(CancellationToken cancelToken, BankQueue bankqueue, Form1 form,
                                    int iMaxTransactionAmount, params Customer[] customerArray)
        {
            this.cancelToken = cancelToken;
            this.form = form;
            //this.resetEvent = resetEvent;
            this.customerArray = customerArray;
            this.iMaxTransactionAmount = iMaxTransactionAmount;
            this.bankqueue = bankqueue;
            task = new Task(TaskProc);
            task.Start();
        }

        private void TaskProc()
        {
            //TODO: From the Form1 Class
            //this.form.UpdateList(("Master.TaskProc started on :" + task.Id));

            randCust = new Random();
            randTxnAmount = new Random();
            randTxnType = new Random();

            try
            {
                while (true)
                {
                    int iRandTxnAmt;
                    int iRandTxnType;
                    int iRandCustID;

                    iRandTxnAmt = randTxnAmount.Next(iMaxTransactionAmount);
                    iRandTxnType = randTxnType.Next((int)TRANSACTION_TYPE.DEPOSIT + 1);
                    iRandCustID = randCust.Next(customerArray.Length);

                    //lets validate if customer is free

                    if (customerArray[iRandCustID].IsCustomerbusy)
                    {
                        form.UpdateListBox(string.Format("Transaction generator, found customer {0} is busy, try picking new customer", iRandCustID));
                        continue;
                    }


                    // we found a free customer, lets mrk him as busy

                    customerArray[iRandCustID].IsCustomerbusy = true;
                    form.UpdateListBox(string.Format("Transaction generator, found free customer: {0}, Transaction type : {1}, Transaction amount ", iRandCustID, iRandTxnType, iRandTxnAmt));

                    //CREATE TRANSACTION OBJECT AND INITIALIZE IT

                    Transaction TxnEntry = new Transaction();
                    TxnEntry.CustID = iRandCustID;
                    TxnEntry.iTxnAmt = iRandTxnAmt;
                    TxnEntry.TxnType = (TRANSACTION_TYPE)iRandTxnType;
                    TxnEntry.OCust = customerArray[iRandCustID];

                    bankqueue.Enqueue(TxnEntry);

                    Thread.Sleep(40);
                    this.cancelToken.ThrowIfCancellationRequested();

                }
            }
            catch (OperationCanceledException OCE)
            {
                form.UpdateListBox("Transaction Generator task is exiting ");
                form.EnableUIControlsOnStop();
                return;
            }
        }// End of TaskProc


    }
}
