using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_UAS_
{
    public partial class Penawaran : Form
    {
        SqlConnection con;
        public Penawaran()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=UAS;Integrated Security=True");
        }

        private void t_penawaran_headerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_penawaran_headerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uASDataSet);

        }

        private void Penawaran_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uASDataSet.t_penawaran_header' table. You can move, or remove it, as needed.
            this.t_penawaran_headerTableAdapter.Fill(this.uASDataSet.t_penawaran_header);

        }
    }
}
