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
        private Random rand;
        private Task task;
        private  CancellationToken cancelToken;
        private Form1 form;
        private AutoResetEvent resetEvent;
        private BankQueue bankqueue;

        public TransactionGenerator(CancellationToken cancelToken, BankQueue bankqueue, Form1 form, AutoResetEvent resetEvent)
        {
            this.cancelToken = cancelToken;
            this.form = form;
            this.resetEvent = resetEvent;
            
            task = new Task(TaskProc);
            task.Start();
        }

        private void TaskProc()
        {
            //TODO: From the Form1 Class
            this.form.UpdateList(("Master.TaskProc started on thread :" + task.Id));

            Random rand = new Random();
        }

        
    }
}
