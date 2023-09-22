using System;
using System.Collections;
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
    public partial class CashierWindowQueue : Form
    {
        public CashierWindowQueue()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = (1 * 100);
            timer.Tick += new EventHandler(Timer1_tick);
            timer.Start();
        }
        Boolean openform = false;
        CustomerView cusview = new CustomerView();
        FormCollection allForms = Application.OpenForms;
        Form openedForm = new Form();
        private void Timer1_tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }
        public delegate void PassControl(object sender);
        public PassControl passControl;

        public void CashierWindow()
        {
            if (openform == false)
            {
                CashierWindowQueue cashierWindow = new CashierWindowQueue();
                cashierWindow.Visible = true;
                openform = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            CustomerView customerView = new CustomerView();
            foreach (Form form in allForms)
            {
                if (form.Name == "CustomerView")
                {
                    openedForm = form;
                    openform = true;
                }
            }
            if (openform == true)
            {
                if (passControl != null)
                    customerView.lblCustomer.Text = CashierClass.CashierQueue.Peek();
                CashierClass.CashierQueue.Dequeue();
                passControl(customerView.lblCustomer);
            }
            else
            {
                customerView.ShowDialog();
                customerView.lblCustomer.Text = CashierClass.CashierQueue.Peek();
                CashierClass.CashierQueue.Dequeue();
            
            }
        }
    }
}