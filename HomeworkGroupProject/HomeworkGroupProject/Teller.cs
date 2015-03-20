using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeworkGroupProject
{
    class Teller
    {
        private Customer[] CustomerArr;
        private CancellationToken CancelToken;
        private Bank OBank;
        private int CustomerGoal;
        private Task TellerTask;
        private int TellerID;
        private BankQueue OBankQueue;
        private Form1 form;
        private int m_custGoalReached;



        public Teller(Bank OBank, CancellationToken CancelToken,  BankQueue OBankqueue, Form1 form,int customerGoal,int TellerID,params Customer[] CustomerArr)
        {
            this.OBank = OBank;
            this.CancelToken = CancelToken;
            this.CustomerArr = CustomerArr;
            this.CustomerGoal = customerGoal;
            this.TellerID = TellerID;
            this.OBankQueue = OBankqueue;
            this.form = form;
            m_custGoalReached = 0;
            TellerTask = new Task(TelletTaskProc);
            TellerTask.Start();
        }

        private void TelletTaskProc()
        {
            try
            {
                while (true)
                {
                    Transaction TransactionEntry;
                    TransactionEntry = OBankQueue.Dequeue();
                    this.CancelToken.ThrowIfCancellationRequested();

                    if (null == TransactionEntry)
                    {
                        form.UpdateListBox("Null Transaction entry dequeued by TellerID : " + TellerID);
                        //do nothing, most likely simulation is stopped
                        //should we exit? TBD

                    }

                    else
                    {
                        //Check if it is withdraw
                        // If so check if customer and Bank has enough balance,

                        if (TRANSACTION_TYPE.WITHDRAW == TransactionEntry.TxnType)
                        {

                            if (TransactionEntry.OCust.AccountBalenceProperty < TransactionEntry.iTxnAmt)
                            {
                                form.UpdateListBox(string.Format("Teller ID :{0}, CustomerID :{1}, TransactionType :{2},Transaction Amount :{3}, Insufficient Balance in Customer account, Transaction FAILED !!!",
                                    TellerID, TransactionEntry.CustID, TransactionEntry.TxnType, TransactionEntry.iTxnAmt));
                                continue;
                            }

                            //Check if Bank has enough money, if so continue with withdraw
                            //Take the bault lock before proceding, as vault is shared between tellers
                            lock (OBank.VaultLock)
                            {
                                if (OBank.VaultAmountProperty < TransactionEntry.iTxnAmt)
                                {
                                    form.UpdateListBox(string.Format("Teller ID :{0}, CustomerID :{1}, TransactionType :{2},Transaction Amount :{3}, Insufficient Vault amount, Transaction FAILED, Stop Transaction !!!",
                                    TellerID, TransactionEntry.CustID, TransactionEntry.TxnType, TransactionEntry.iTxnAmt));

                                    //TBD How to stop the simulation
                                    form.CancelToken.Cancel();

                                }

                                else
                                {
                                    //Update the valut and customer balance
                                    OBank.VaultAmountProperty = OBank.VaultAmountProperty - TransactionEntry.iTxnAmt;
                                    TransactionEntry.OCust.AccountBalenceProperty = TransactionEntry.OCust.AccountBalenceProperty - TransactionEntry.iTxnAmt;
                                    form.UpdateListBox(string.Format("Teller ID :{0}, CustomerID :{1}, TransactionType :{2},Transaction Amount :{3},  Transaction SUCCESS",
                                    TellerID, TransactionEntry.CustID, TransactionEntry.TxnType, TransactionEntry.iTxnAmt));

                                    //Update the string for transaction history;

                                    TransactionEntry.OCust.AddTransactiontoHistory(string.Format("Teller ID :{0}, CustomerID :{1}, TransactionType :{2},Transaction Amount :{3},  Transaction SUCCESS",
                                    TellerID, TransactionEntry.CustID, TransactionEntry.TxnType, TransactionEntry.iTxnAmt));

                                }
                            }


                        }
                        // Below code is for deposit
                        else
                        {
                            //No need to validate the amount for deposit case
                            lock (OBank.VaultLock)
                            {
                                OBank.VaultAmountProperty = OBank.VaultAmountProperty + TransactionEntry.iTxnAmt;
                                TransactionEntry.OCust.AccountBalenceProperty =
                                    TransactionEntry.OCust.AccountBalenceProperty + TransactionEntry.iTxnAmt;

                                form.UpdateListBox(string.Format("Teller ID :{0}, CustomerID :{1}, TransactionType :{2},Transaction Amount :{3},  Transaction SUCCESS",
                                    TellerID, TransactionEntry.CustID, TransactionEntry.TxnType, TransactionEntry.iTxnAmt));
                                //Update the transaction history
                                TransactionEntry.OCust.AddTransactiontoHistory(string.Format("Teller ID :{0}, CustomerID :{1}, TransactionType :{2},Transaction Amount :{3},  Transaction SUCCESS",
                                    TellerID, TransactionEntry.CustID, TransactionEntry.TxnType, TransactionEntry.iTxnAmt));
                            }

                            // if Customer achived his goal, stop the transaction
                            if (TransactionEntry.OCust.AccountBalenceProperty >= CustomerGoal)
                            {
                                form.UpdateListBox(string.Format("Teller ID :{0}, CustomerID :{1}, Customer reached Goal !!!  Stop Simulation !!!",
                                    TellerID, TransactionEntry.CustID, TransactionEntry.TxnType, TransactionEntry.iTxnAmt));
                                
                                m_custGoalReached = TransactionEntry.CustID;
                                //TBD : is there a better way to cancel?
                                form.CancelToken.Cancel();
                                
                            }

                        }

                        //Update Customer as Free
                        TransactionEntry.OCust.IsCustomerbusy = false;

                    }

                    Thread.Sleep(30);
                }
            }//End of try

            catch(OperationCanceledException OCE )
            {
                if (0 !=m_custGoalReached)
                {
                    form.UpdateListBox("\n");// Just for butification
                    this.CustomerArr[m_custGoalReached].PrintTransactionHistory();
                    form.UpdateListBox("\n");// Just for butification
                }
                form.UpdateListBox("TellerID:" + TellerID + " task is exiting ");
                
               return;
            }
        }

    }
}
