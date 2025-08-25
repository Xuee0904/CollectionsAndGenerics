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
    public partial class CustomerView : Form
    {
        
        public CustomerView()
        {
            InitializeComponent();

            label1.ForeColor = ColorTranslator.FromHtml("#000907");
            ServingQueueLabel.ForeColor = ColorTranslator.FromHtml("#222021");
        }

        private void CustomerView_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#F3F3F3");
        }

        public string ServingQueueLabelText
        {
            set
            {
                ServingQueueLabel.Text = value;
            }
        }
    }
}
