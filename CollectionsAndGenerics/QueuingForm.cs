using System;
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
    public partial class QueuingForm : Form
    {

        CashierWindowQueueForm form2 = new CashierWindowQueueForm();
        private CashierClass cashier = new CashierClass();
        public QueuingForm()
        {
            InitializeComponent();
            form2.Show();
       
            GetNumberButton.BackColor = ColorTranslator.FromHtml("#3A5A40");
            GetNumberButton.ForeColor = ColorTranslator.FromHtml("#DFE6DA");

            label1.ForeColor = ColorTranslator.FromHtml("#000907");
            QueueNumberLabel.ForeColor = ColorTranslator.FromHtml("#222021");
        }

        private void QueuingForm_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#F3F3F3");
        }

        private void GetNumberButton_Click(object sender, EventArgs e)
        {

            QueueNumberLabel.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = QueueNumberLabel.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);

            form2.timer1.Start();
        }
    }
}
