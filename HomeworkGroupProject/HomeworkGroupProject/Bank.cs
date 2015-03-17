using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeworkGroupProject
{
    class Bank
    {

        public object VaultLock;
        private CancellationToken CancelToken;
        private int VaultAmount;        
        private int TellerCount;
        private Customer[] CustomerArr;

        public int VaultAmountProperty
        {
            get { return VaultAmount; }
            set { VaultAmount = value; }
        }
        

        public Bank(CancellationToken CancelToken, BankQueue OBankueue, Form1 form, int iInitialVaultAmount, int TellerCount, int CustomerGoal, params Customer[] CustomerArr)
        {
            VaultLock = new object();
            this.CancelToken = CancelToken;
            this.VaultAmount = iInitialVaultAmount;
            this.TellerCount = TellerCount;
            this.CustomerArr = CustomerArr;

            for (int TellerID = 0; TellerID < TellerCount; TellerID++)
            {
                Teller teller = new Teller( this, CancelToken, OBankueue, form, CustomerGoal, TellerID, CustomerArr);
            }
        }
        
        
    }
}
