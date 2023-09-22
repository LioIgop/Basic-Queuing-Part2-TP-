namespace Basic_Queuing_Part2__TP_
{
    public partial class QueuingForm : Form
    {
        CashierClass cashier = new CashierClass();
        public QueuingForm()
        {
            InitializeComponent();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P -");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CashierWindowQueue CashierWindow = new CashierWindowQueue();
            CashierWindow.CashierWindow();
        }

        private void QueuingForm_Load(object sender, EventArgs e)
        {

        }
    }
}