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
    public partial class PrintSupplier : Form
    {
        public PrintSupplier()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CRSupplier printsupplier = new CRSupplier();
            crystalReportViewer1.ReportSource = printsupplier;
        }
    }
}
