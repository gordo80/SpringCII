using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab5Challenge
{
    class Master
    {
        private SharedData shared;
        Form1 form;
        private CancellationToken canceltoken;
        private Task task;

        public Master(CancellationToken canceltoken, SharedData sharedData, Form1 form, Task task)
        {
            this.canceltoken = canceltoken; this.shared = sharedData; this.form = form; this.task = task;
            task = new Task(ThreadProc);
            task.Start();
        }

        private void ThreadProc()
        { 
            
        }
    }
}
