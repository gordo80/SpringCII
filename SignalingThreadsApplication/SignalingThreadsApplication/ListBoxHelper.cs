using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignalingThreadsApplication
{
    class ListBoxHelper
    {
        ListBox listbox;
        //delegate
        private delegate void AddListBoxItem(string message);
        public ListBoxHelper(ListBox listbox)
        {
            this.listbox = listbox;
        }
        public void AddString(string message)
        {
            if (this.listbox.InvokeRequired)
            {
                AddListBoxItem boxItem = AddString;
                this.listbox.Invoke(boxItem, message);
            }
            else
            {
                this.listbox.Items.Add(message);
            }
        }
    }
}
