using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Lab5Challenge
{
    public partial class Form1 : Form
    {
        private System.Threading.CancellationTokenSource cancelTokenSource;
        private System.Threading.SynchronizationContext syncContext;
        public Form1()
        {
            InitializeComponent();
            this.shared = new SharedData(cts.Token);
            
        }
    }
}
