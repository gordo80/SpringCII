using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeworkGroupProject
{
    enum TRANSACTION_TYPE
    {
        WITHDRAW = 0,
        DEPOSIT = 1
    };
    
    public partial class Form1 : Form
    {

        // private variables to store the UI entries
        private int iTellerCount;
        private int iCustomerCount;
        private int iInitialVaultAmount;

        private int iMaxTransactionAmount;
        private int iInitialCustomerBalence;
        private int iCustomerGoalAmount;
        private SynchronizationContext syncContext;
        private SynchronizationContext syncContext1;
        public CancellationTokenSource CancelToken;

        private TransactionGenerator m_TransactionGenerator;
        private Bank m_Bank;

        private BankQueue OBankQueue;


        public int InitialVaultAmount
        {
            get { return iInitialVaultAmount; }
            set { iInitialVaultAmount = value; }
        }


        public Form1()
        {
            InitializeComponent();

            //Disable the Stop button;
            btnStop.Enabled = false;
/*
            //create a Task exit cancellation token
            CancelToken = new CancellationTokenSource();

            //Create a bank queue
            OBankQueue = new BankQueue(CancelToken.Token);

            syncContext = WindowsFormsSynchronizationContext.Current;
*/
        }


        public void UpdateListBox(string msg)
        {
            syncContext.Send(o =>
            {
                this.ListBox.Items.Add(msg);
                this.ListBox.SelectedIndex = -1;
            }, msg);

        }


        private void btnStart_Click(object sender, EventArgs e)
        {

            // Disable the start buttong and the fields
            btnStart.Enabled = false;
            txtCustomers.Enabled = false;
            txtCustGoalAmount.Enabled = false;
            txtCustInitialAmount.Enabled = false;
            txtMaxTxnAmout.Enabled = false;
            txtTellers.Enabled = false;
            txtInitVaultAmt.Enabled = false;

            //Validate the Input
            //If failure do not start simulation.. just return from here
            bool bFailure = ValidateUIInput();

            if(true == bFailure)
            {
                ListBox.Items.Add("!!! Invalid input please correct it !!!");
                // Enable the start button and the text fields
                btnStart.Enabled = true;
                txtCustomers.Enabled = true;
                txtCustGoalAmount.Enabled = true;
                txtCustInitialAmount.Enabled = true;
                txtMaxTxnAmout.Enabled = true;
                txtTellers.Enabled = true;
                txtInitVaultAmt.Enabled = true;

                return;
            }

            
            //Done with error checks.. start to allocate the resources.
            //Customer count, teller count, max amoun are fetched from UI, and resources are allocated base on that

            //create a Task exit cancellation token
            CancelToken = new CancellationTokenSource();

            //Create a bank queue
            OBankQueue = new BankQueue(CancelToken.Token);

            syncContext = WindowsFormsSynchronizationContext.Current;
            syncContext1 = WindowsFormsSynchronizationContext.Current;

            //Create array of customers, and istanciate each customer and store the object in array.
            Customer[] CustomerArr = new Customer[iCustomerCount];

            for (int iCustID = 0; iCustID < iCustomerCount; iCustID++)
            {
                CustomerArr[iCustID] = new Customer(iCustID, iInitialCustomerBalence, iCustomerGoalAmount, CancelToken.Token,this);
            }



            //Create a transaction generatr
            m_TransactionGenerator = new TransactionGenerator(CancelToken.Token, OBankQueue, this, iMaxTransactionAmount, CustomerArr);

            //Instanciate the Bank
            m_Bank = new Bank(CancelToken.Token, OBankQueue, this, iInitialVaultAmount, iTellerCount, iCustomerGoalAmount, CustomerArr);

            //Last step
            btnStop.Enabled = true;
        }

        private bool ValidateUIInput()
        {
            bool bRetVal = true;
            bool bFailure = false;

            // Gather the entries from UI. use try parse to avoid crash
            bRetVal = int.TryParse(txtTellers.Text, out iTellerCount);

            if ((!bRetVal) || (iTellerCount > ClassDefines.MAX_TELLER_COUNT) || (iTellerCount <= 0))
            {
                bFailure = true;
                ListBox.Items.Add("Invalid Teller count, please enter valid count less then :" + ClassDefines.MAX_TELLER_COUNT);
            }


            bRetVal = int.TryParse(txtCustomers.Text, out iCustomerCount);
            if ((!bRetVal) || (iCustomerCount > ClassDefines.MSX_CUSTOMER_COUNT) || (iCustomerCount <= 0))
            {
                bFailure = true;
                ListBox.Items.Add("Invalid customer count, please enter valid count less then :" + ClassDefines.MSX_CUSTOMER_COUNT);
            }


            bRetVal = int.TryParse(txtInitVaultAmt.Text, out iInitialVaultAmount);
            if ((!bRetVal) || (iInitialVaultAmount <= 0))
            {
                bFailure = true;
                ListBox.Items.Add("Invalid initial Vault Amount, please enter valid amount");
            }

            bRetVal = int.TryParse(txtCustInitialAmount.Text, out iInitialCustomerBalence);
            if ((!bRetVal) || (iInitialCustomerBalence < 0))
            {
                bFailure = true;
                ListBox.Items.Add("Invalid initial customer Amount, please enter valid amount");
            }

            // initial vault amount > (customer amount * customer count)
            // if not break execution

            if (iInitialVaultAmount < (iCustomerCount * iInitialCustomerBalence))
            {
                bFailure = true;
                ListBox.Items.Add("Invalid entries, initial vault amount > (initial customer amount * customer count)");
            }

            bRetVal = int.TryParse(txtMaxTxnAmout.Text, out iMaxTransactionAmount);
            if ((!bRetVal) || (iMaxTransactionAmount < 0))
            {
                bFailure = true;
                ListBox.Items.Add("Invalid Max Transaction Amount, max transaction amount should be greater than 0 ");
            }

            bRetVal = int.TryParse(txtCustGoalAmount.Text, out iCustomerGoalAmount);
            if ((!bRetVal) || (iCustomerGoalAmount < 0))
            {
                bFailure = true;
                ListBox.Items.Add("Invalid goal amount, amount should be greater than 0 ");
            }

            return bFailure;

        }

        private void btnStop_Click(object sender, EventArgs e)
        {

            //stop the threads
            this.CancelToken.Cancel();
            EnableUIControlsOnStop();

            // Enable the start button and the text fields
            btnStart.Enabled = true;
            txtCustomers.Enabled = true;
            txtCustGoalAmount.Enabled = true;
            txtCustInitialAmount.Enabled = true;
            txtMaxTxnAmout.Enabled = true;
            txtTellers.Enabled = true;
            txtInitVaultAmt.Enabled = true;

            btnStop.Enabled = false;

            Thread.Sleep(1000);
            

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ListBox.Items.Clear();
        }

        public void EnableUIControlsOnStop()
        {
            
            syncContext1.Send(o =>
            {
                // Enable the start button and the text fields
                btnStart.Enabled = true;
                txtCustomers.Enabled = true;
                txtCustGoalAmount.Enabled = true;
                txtCustInitialAmount.Enabled = true;
                txtMaxTxnAmout.Enabled = true;
                txtTellers.Enabled = true;
                txtInitVaultAmt.Enabled = true;

                btnStop.Enabled = false;
            },"");
        }
    }
}
