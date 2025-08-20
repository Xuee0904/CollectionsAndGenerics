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
    public partial class CashierWindowQueueForm : Form
    {
        public CashierWindowQueueForm()
        {
            InitializeComponent();

            RefreshButton.BackColor = ColorTranslator.FromHtml("#D9DDDC");
            RefreshButton.ForeColor = ColorTranslator.FromHtml("#222021");
            NextButton.BackColor = ColorTranslator.FromHtml("#3A5A40");
            NextButton.ForeColor = ColorTranslator.FromHtml("#DFE6DA");
        }

        private void CashierWindowQueueForm_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#F3F3F3");
        }
    }
}
