using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace HomeworkLab3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            ThreadStart threadDelegate = new ThreadStart(Worker.ThreadProc);
            Thread thread = new Thread(threadDelegate);
            thread.Start();
            //Calls the Join method for passing it the int timeOut parameter and returns
            //the bool value from thread.Join(int). Int 0 False and 1 is equal to 1
            Worker.Join(0);
            
        }
    }
}
