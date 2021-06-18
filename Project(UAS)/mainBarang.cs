using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Business_Layer;
using Data_Layer;

namespace Project_UAS_
{
    public partial class mainBarang : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        ConnectionDB db = new ConnectionDB();
        SqlDataAdapter da;

        public mainBarang()
        {
            InitializeComponent();
        }

        private void KodeOtomatis()
        {
            long hitung;
            string urutan;
            SqlDataReader rd;
            con = new SqlConnection(db.GetConnection());
            con.Open();
            cmd = new SqlCommand("SELECT KODE from m_barang WHERE KODE in(SELECT MAX(KODE) from m_barang) order by KODE desc", con);
            rd = cmd.ExecuteReader();
            rd.Read();

            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["KODE"].ToString().Length - 3, 3)) + 1;
                string kodeUrutan = "000" + hitung;
                urutan = "BRG" + kodeUrutan.Substring(kodeUrutan.Length - 3, 3);
            }
            else
            {
                urutan = "BRG001";
            }
            rd.Close();
            kODETextBox.Text = urutan;
            con.Close();
        }

        private void m_barangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
                this.Validate();
                this.m_barangBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.uASDataSet);
        }

        private void mainBarang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uASDataSet.m_merk' table. You can move, or remove it, as needed.
            this.m_merkTableAdapter.Fill(this.uASDataSet.m_merk);
            // TODO: This line of code loads data into the 'uASDataSet.m_barang' table. You can move, or remove it, as needed.
            this.m_barangTableAdapter.Fill(this.uASDataSet.m_barang);
            kODETextBox.Enabled = false;
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewBarang formViewBarang = new viewBarang();
            formViewBarang.ShowDialog();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            KodeOtomatis();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }
    }
}
