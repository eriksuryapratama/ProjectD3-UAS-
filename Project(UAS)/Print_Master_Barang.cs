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
    public partial class Print_Master_Barang : Form
    {
        public Print_Master_Barang()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CRBarang printbarang = new CRBarang();
            crystalReportViewer1.ReportSource = printbarang;
        }
    }
}
