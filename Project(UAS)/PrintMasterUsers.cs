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
    public partial class PrintMasterUsers : Form
    {
        public PrintMasterUsers()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            //CRUser printusers = new CRUser();
            //crystalReportViewer1.ReportSource = printusers;
        }
    }
}
