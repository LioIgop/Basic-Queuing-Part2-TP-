using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Basic_Queuing_Part2__TP_
{
    public partial class CustomerView : Form
    {
        public CustomerView()
        {
            InitializeComponent();
        }

        private void CustomerView_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = (1 * 100);
            timer.Tick += new EventHandler(btnRefresh);
            timer.Start();
        }
        private void btnRefresh(object sender, EventArgs e)
        {
                lblCustomer.Text = CashierClass.CashierQueue.Peek();
        }
    }
}
