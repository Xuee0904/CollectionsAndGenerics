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

namespace CollectionsAndGenerics
{
    public partial class CashierWindowQueueForm : Form
    {

        CustomerView form3 = new CustomerView();

        public CashierWindowQueueForm()
        {
            InitializeComponent();

            form3.Show();

            AutoRefresh();

            RefreshButton.BackColor = ColorTranslator.FromHtml("#D9DDDC");
            RefreshButton.ForeColor = ColorTranslator.FromHtml("#222021");
            NextButton.BackColor = ColorTranslator.FromHtml("#3A5A40");
            NextButton.ForeColor = ColorTranslator.FromHtml("#DFE6DA");
        }

        private void CashierWindowQueueForm_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#F3F3F3");
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            QueueList.Items.Clear();
            foreach (Object obj in CashierList)
            {
                QueueList.Items.Add(obj.ToString());
            }
        }

        private void AutoRefresh()
        {
            Timer timer = new Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(timer1_Tick);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            CashierClass.CashierQueue.Dequeue();

            DisplayCashierQueue(CashierClass.CashierQueue);

            form3.ServingQueueLabelText = CashierClass.CashierQueue.Peek();
        }
    }
}
