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
using Data_Layer;

namespace Project_UAS_
{
    public partial class Pembelian : Form
    {
        SqlConnection con;

        public Pembelian()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=UAS;Integrated Security=True");
        }

        private void t_pembelian_headerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_pembelian_headerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uASDataSet);
        }

        private void Pembelian_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uASDataSet.m_barang' table. You can move, or remove it, as needed.
            this.m_barangTableAdapter.Fill(this.uASDataSet.m_barang);
            // TODO: This line of code loads data into the 'uASDataSet.m_supplier' table. You can move, or remove it, as needed.
            this.m_supplierTableAdapter.Fill(this.uASDataSet.m_supplier);
            // TODO: This line of code loads data into the 'uASDataSet.t_pembelian_header' table. You can move, or remove it, as needed.
            this.t_pembelian_headerTableAdapter.Fill(this.uASDataSet.t_pembelian_header);

            //tb_NPWP2.Text = nAMA_NPWPTextBox.Text;
            tb_Alamat.Text = aLAMAT_NPWTextBox.Text + ", " + kOTATextBox.Text;

            data_beli();
        }

        public void data_beli()
        {
            con.Open();

            DataSet ds = new DataSet();
            String query = $"SELECT mb.kode as KODE,mb.part_no AS 'PART NO',mb.description AS DESCRIPTION,mb.unit AS UNIT ,mb.merk1 AS MERK,td.qty AS QUANTITY ,FORMAT(mb.unit_price,'C', 'id-ID') AS PRICE,FORMAT((td.qty*mb.unit_price),'C', 'id-ID') as Amount " +
                           $"FROM m_barang mb,t_pembelian_detail td,t_pembelian_header th " +
                           $"where th.no_pnw = td.no_pnw " +
                           $"and mb.kode = td.kode " +
                           $"and th.no_nota = td.no_nota " +
                           $"and th.no_nota = '{nO_NOTATextBox.Text}' ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
            dgv_databeli.DataSource = ds.Tables[0];

            con.Close();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void nO_NOTATextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            data_beli();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            data_beli();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            data_beli();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            data_beli();
        }

        private void btn_tmbhitem_Click(object sender, EventArgs e)
        {
            con.Open();

            //KODE BARANG
            String DataBrg = $"SELECT kode FROM m_barang WHERE id = '{cb_nmbarang.SelectedValue}'";
            SqlCommand comm = new SqlCommand(DataBrg, con);
            String kode = comm.ExecuteScalar().ToString();

            //PART NOMOR BARANG
            String DataBrg2 = $"SELECT part_no FROM m_barang WHERE id = '{cb_nmbarang.SelectedValue}'";
            SqlCommand comm2 = new SqlCommand(DataBrg2, con);
            String part_no = comm2.ExecuteScalar().ToString();

            //DESCRIPTION BARANG
            String DataBrg3 = $"SELECT description FROM m_barang WHERE id = '{cb_nmbarang.SelectedValue}'";
            SqlCommand comm3 = new SqlCommand(DataBrg3, con);
            String description = comm3.ExecuteScalar().ToString();

            //UNIT BARANG
            String DataBrg4 = $"SELECT unit FROM m_barang WHERE id = '{cb_nmbarang.SelectedValue}'";
            SqlCommand comm4 = new SqlCommand(DataBrg4, con);
            String unit = comm4.ExecuteScalar().ToString();

            //UNIT PRICE BARANG
            String DataBrg5 = $"SELECT unit_price FROM m_barang WHERE id = '{cb_nmbarang.SelectedValue}'";
            SqlCommand comm5 = new SqlCommand(DataBrg5, con);
            String unit_price = comm5.ExecuteScalar().ToString();

            //MERK BARANG
            String DataBrg6 = $"SELECT merk1 FROM m_barang WHERE id = '{cb_nmbarang.SelectedValue}'";
            SqlCommand comm6 = new SqlCommand(DataBrg6, con);
            String merk = comm6.ExecuteScalar().ToString();

            //PENGECEKAN & INPUT DATA
            String cek = tb_qty.Text;
            int num = -1;
            if (!int.TryParse(cek, out num))
            {
                MessageBox.Show("Data Qty Harus Angka !");
            }
            else
            {
                String query = $"Insert into t_pembelian_detail(no_pnw, no_nota, kode, part_no, descriptio, unit, merk, qty, unit_price) values('{nO_PNWTextBox.Text}', '{nO_NOTATextBox.Text}', '{kode}', '{part_no}', '{description}', '{unit}', '{merk}', '{Convert.ToInt32(tb_qty.Text)}', '{unit_price}')";
                comm = new SqlCommand(query, con);
                comm.ExecuteNonQuery();
            }
            con.Close();
            data_beli();
        }

        private void btn_hpsitem_Click(object sender, EventArgs e)
        {
            con.Open();

            //KODE BARANG
            String DataBrg = $"SELECT kode FROM m_barang WHERE id = '{cb_nmbarang.SelectedValue}'";
            SqlCommand comm = new SqlCommand(DataBrg, con);
            String kode = comm.ExecuteScalar().ToString();

            //PART NOMOR BARANG
            String DataBrg2 = $"SELECT part_no FROM m_barang WHERE id = '{cb_nmbarang.SelectedValue}'";
            SqlCommand comm2 = new SqlCommand(DataBrg2, con);
            String part_no = comm2.ExecuteScalar().ToString();

            //DESCRIPTION BARANG
            String DataBrg3 = $"SELECT description FROM m_barang WHERE id = '{cb_nmbarang.SelectedValue}'";
            SqlCommand comm3 = new SqlCommand(DataBrg3, con);
            String description = comm3.ExecuteScalar().ToString();

            //UNIT BARANG
            String DataBrg4 = $"SELECT unit FROM m_barang WHERE id = '{cb_nmbarang.SelectedValue}'";
            SqlCommand comm4 = new SqlCommand(DataBrg4, con);
            String unit = comm4.ExecuteScalar().ToString();

            //UNIT PRICE BARANG
            String DataBrg5 = $"SELECT unit_price FROM m_barang WHERE id = '{cb_nmbarang.SelectedValue}'";
            SqlCommand comm5 = new SqlCommand(DataBrg5, con);
            String unit_price = comm5.ExecuteScalar().ToString();

            //MERK BARANG
            String DataBrg6 = $"SELECT merk1 FROM m_barang WHERE id = '{cb_nmbarang.SelectedValue}'";
            SqlCommand comm6 = new SqlCommand(DataBrg6, con);
            String merk = comm6.ExecuteScalar().ToString();

            //DELETE BARANG
            String query = $"DELETE FROM t_pembelian_detail WHERE KODE = '{tb_Kode.Text}' AND NO_NOTA = '{nO_NOTATextBox.Text}'";
            comm = new SqlCommand(query, con);
            comm.ExecuteNonQuery();
            con.Close();
            data_beli();
        }

        private void dgv_databeli_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            tb_Kode.Text = dgv_databeli.Rows[rowIndex].Cells[0].Value.ToString();
        }
    }
}
