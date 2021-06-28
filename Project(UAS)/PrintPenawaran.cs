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
    public partial class PrintPenawaran : Form
    {
        public PrintPenawaran()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CRPenawaran printpenawaran = new CRPenawaran();
            crystalReportViewer1.ReportSource = printpenawaran;
        }
    }
}
