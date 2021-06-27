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
    public partial class Print_Master_Pelanggan : Form
    {
        public Print_Master_Pelanggan()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CRPelanggan printpelanggan = new CRPelanggan();
            crystalReportViewer1.ReportSource = printpelanggan;
        }
    }
}
