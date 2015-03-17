using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Signaling_task
{
    class Master
    {
        private Task t;
       private  CancellationToken CancelToken;
        private SharedData shared;
        private Form1 form;
        private AutoResetEvent AREvent;

        public Master(CancellationToken cancelToken, SharedData shared, Form1 form, AutoResetEvent AREvent)
        {
            this.CancelToken = cancelToken;
            this.shared = shared;
            this.form = form;
            this.AREvent = AREvent;

            t = new Task(TaskProc);
            t.Start();

        }

        private void TaskProc()
        {
            this.form.UpdateList(("Master.TaskProc started on thread :" + t.Id));

            Random rand = new Random();

            try
            {
                while (true)
                {
                    this.AREvent.WaitOne();
                    this.shared.Enqueue(rand.Next());
                    this.CancelToken.ThrowIfCancellationRequested();

                    Thread.Sleep(1);
                }
            }

            finally
            {
                form.UpdateList("Master.TaskProc ending on thread : " + t.Id);

            }

            //return;
        }
    }
}
