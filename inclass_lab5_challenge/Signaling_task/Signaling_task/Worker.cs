using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Signaling_task
{
    class Worker
    {
        private Task t;
        CancellationToken CancelToken;
        private SharedData shared;
        Form1 form;

        public Worker(CancellationToken cancelToken, SharedData shared, Form1 form)
        {
            this.CancelToken = cancelToken;
            this.shared = shared;
            this.form = form;

            t = new Task(TaskProc);
            t.Start();

        }


        private void TaskProc()
        {
            this.form.UpdateList(("Worker.TaskProc started on thread :" + t.Id));
            try
            {
                while (true)
                {
                    int? val = this.shared.Dequeue();
                    this.CancelToken.ThrowIfCancellationRequested();

                    this.form.UpdateList(("Worker.TaskProc :" + t.Id + "dequeued :" + val));
                    Thread.Sleep(1);

                }
            }
            finally
            {
                form.UpdateList("Master.TaskProc ending on thread : " + t.Id);
            }
        }
    }
}
