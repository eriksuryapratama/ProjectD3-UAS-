using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_UAS_
{
    public partial class Print_Invoice : Form
    {
        public Print_Invoice()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CRInvoice printinvoice = new CRInvoice();
            crystalReportViewer1.ReportSource = printinvoice;
        }
    }
}
