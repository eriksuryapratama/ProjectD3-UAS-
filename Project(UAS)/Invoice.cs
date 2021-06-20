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
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }

        private void t_invoiceppn_headerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_invoiceppn_headerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uASDataSet);

        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uASDataSet.t_invoiceppn_header' table. You can move, or remove it, as needed.
            this.t_invoiceppn_headerTableAdapter.Fill(this.uASDataSet.t_invoiceppn_header);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
