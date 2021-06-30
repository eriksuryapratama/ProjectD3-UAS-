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
    public partial class Invoice : Form
    {
        SqlConnection con;

        public Invoice()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=UAS;Integrated Security=True");
        }

        private void t_invoice_headerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_invoice_headerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uASDataSet);

        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uASDataSet.t_penawaran_header' table. You can move, or remove it, as needed.
            this.t_penawaran_headerTableAdapter.Fill(this.uASDataSet.t_penawaran_header);
            // TODO: This line of code loads data into the 'uASDataSet.m_barang' table. You can move, or remove it, as needed.
            this.m_barangTableAdapter.Fill(this.uASDataSet.m_barang);
            // TODO: This line of code loads data into the 'uASDataSet.m_pelanggan' table. You can move, or remove it, as needed.
            this.m_pelangganTableAdapter.Fill(this.uASDataSet.m_pelanggan);
            // TODO: This line of code loads data into the 'uASDataSet.t_invoice_header' table. You can move, or remove it, as needed.
            this.t_invoice_headerTableAdapter.Fill(this.uASDataSet.t_invoice_header);

            tb_alamatLengkap.Text = tb_alamatNPWP.Text + ", " + tb_kotaCustomer.Text;

            data_invoice();
        }
        public void data_invoice()
        {
            con.Open();

            //DATA GRID
            DataSet ds = new DataSet();
            String query = $"SELECT pd.kode as KODE, pd.part_no AS 'PART NO', pd.descriptio AS DESCRIPTION, pd.qty AS QTY , FORMAT(pd.unit_price,'C', 'id-ID') AS 'HARGA BELI', FORMAT(pd.unit_pric2,'C', 'id-ID') AS 'HARGA JUAL', FORMAT((pd.qty * pd.unit_pric2),'C', 'id-ID') as Amount " +
                           $"FROM t_penawaran_detail pd, t_invoice_detail td, t_invoice_header th " +
                           $"where th.no_inv = td.no_inv " +
                           $"and pd.no_pnw = '{nO_PNWComboBox.SelectedValue}' " +
                           $"and th.no_inv = '{tb_noINV.Text}'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
            dgv_dataInvoice.DataSource = ds.Tables[0];

            //Hitung Total
            String HitungTotal = $"SELECT format(sum(pd.qty * pd.unit_pric2), 'C', 'id-ID') " +
                                 $"FROM t_penawaran_detail pd, t_invoice_detail td, t_invoice_header th " +
                                 $"where th.no_inv = td.no_inv " +
                                 $"and pd.no_pnw = '{nO_PNWComboBox.SelectedValue}' " +
                                 $"and th.no_inv = '{tb_noINV.Text}' ";
            SqlCommand commSum1 = new SqlCommand(HitungTotal, con);
            String totalHarga = commSum1.ExecuteScalar().ToString();

            //Hitung Discount
            String Disc = $"SELECT format(sum(td.qty * td.unit_pric2 * 10 / 100), 'C', 'id-ID') " +
                          $"FROM t_penawaran_detail pd, t_invoice_detail td, t_invoice_header th " +
                          $"where th.no_inv = td.no_inv " +
                          $"and pd.no_pnw = '{nO_PNWComboBox.SelectedValue}' " +
                          $"and th.no_inv = '{tb_noINV.Text}' ";
            SqlCommand commSum2 = new SqlCommand(Disc, con);
            String discHarga = commSum2.ExecuteScalar().ToString();

            //Hitung PPN
            String ppN = $"SELECT format(sum(td.qty * td.unit_pric2 * 5 / 100), 'C', 'id-ID') " +
                         $"FROM t_penawaran_detail pd, t_invoice_detail td, t_invoice_header th " +
                         $"where th.no_inv = td.no_inv " +
                         $"and pd.no_pnw = '{nO_PNWComboBox.SelectedValue}' " +
                         $"and th.no_inv = '{tb_noINV.Text}' ";
            SqlCommand commSum3 = new SqlCommand(ppN, con);
            String ppnHarga = commSum3.ExecuteScalar().ToString();

            tb_Discount.Text = discHarga;
            tb_PPN.Text = ppnHarga;
            tb_totalBeli.Text = totalHarga;
            tb_grandTotal.Text = totalHarga;

            con.Close();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            data_invoice();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            data_invoice();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            data_invoice();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            data_invoice();
        }

        private void btn_tmbhitem_Click(object sender, EventArgs e)
        {
            con.Open();

            this.Validate();
            this.t_invoice_headerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uASDataSet);

            //KODE BARANG
            String DataBrg = $"SELECT kode FROM t_penawaran_detail WHERE no_pnw = '{nO_PNWComboBox.SelectedValue}'";
            SqlCommand comm = new SqlCommand(DataBrg, con);
            String kode = comm.ExecuteScalar().ToString();

            //PART NOMOR BARANG
            String DataBrg2 = $"SELECT part_no FROM t_penawaran_detail WHERE no_pnw = '{nO_PNWComboBox.SelectedValue}'";
            SqlCommand comm2 = new SqlCommand(DataBrg2, con);
            String part_no = comm2.ExecuteScalar().ToString();

            //DESCRIPTION BARANG
            String DataBrg3 = $"SELECT descriptio FROM t_penawaran_detail WHERE no_pnw = '{nO_PNWComboBox.SelectedValue}'";
            SqlCommand comm3 = new SqlCommand(DataBrg3, con);
            String description = comm3.ExecuteScalar().ToString();

            //UNIT BARANG
            String DataBrg4 = $"SELECT qty FROM t_penawaran_detail WHERE no_pnw = '{nO_PNWComboBox.SelectedValue}'";
            SqlCommand comm4 = new SqlCommand(DataBrg4, con);
            String qty = comm4.ExecuteScalar().ToString();

            //UNIT PRICE BARANG
            String DataBrg5 = $"SELECT unit_price FROM t_penawaran_detail WHERE no_pnw = '{nO_PNWComboBox.SelectedValue}'";
            SqlCommand comm5 = new SqlCommand(DataBrg5, con);
            String unit_price = comm5.ExecuteScalar().ToString();

            //MERK BARANG
            String DataBrg6 = $"SELECT unit_pric2 FROM t_penawaran_detail WHERE no_pnw = '{nO_PNWComboBox.SelectedValue}'";
            SqlCommand comm6 = new SqlCommand(DataBrg6, con);
            String unit_pric2 = comm6.ExecuteScalar().ToString();

            //INSERT
            String query = $"Insert into t_invoice_detail(no_inv, kode, part_no, descriptio, qty, unit_price, unit_pric2) values('{tb_noINV.Text}','{kode}','{part_no}','{description}','{qty}',{unit_price}, {unit_pric2})";
            comm = new SqlCommand(query, con);
            comm.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Berhasil ditambahkan");
            data_invoice();
        }

        private void btn_hpsitem_Click(object sender, EventArgs e)
        {
            con.Open();

            //KODE BARANG
            String DataBrg = $"SELECT kode FROM t_penawaran_detail WHERE no_pnw = '{nO_PNWComboBox.SelectedValue}'";
            SqlCommand comm = new SqlCommand(DataBrg, con);
            String kode = comm.ExecuteScalar().ToString();

            //PART NOMOR BARANG
            String DataBrg2 = $"SELECT part_no FROM t_penawaran_detail WHERE no_pnw = '{nO_PNWComboBox.SelectedValue}'";
            SqlCommand comm2 = new SqlCommand(DataBrg2, con);
            String part_no = comm2.ExecuteScalar().ToString();

            //DESCRIPTION BARANG
            String DataBrg3 = $"SELECT descriptio FROM t_penawaran_detail WHERE no_pnw = '{nO_PNWComboBox.SelectedValue}'";
            SqlCommand comm3 = new SqlCommand(DataBrg3, con);
            String description = comm3.ExecuteScalar().ToString();

            //UNIT BARANG
            String DataBrg4 = $"SELECT qty FROM t_penawaran_detail WHERE no_pnw = '{nO_PNWComboBox.SelectedValue}'";
            SqlCommand comm4 = new SqlCommand(DataBrg4, con);
            String qty = comm4.ExecuteScalar().ToString();

            //UNIT PRICE BARANG
            String DataBrg5 = $"SELECT unit_price FROM t_penawaran_detail WHERE no_pnw = '{nO_PNWComboBox.SelectedValue}'";
            SqlCommand comm5 = new SqlCommand(DataBrg5, con);
            String unit_price = comm5.ExecuteScalar().ToString();

            //MERK BARANG
            String DataBrg6 = $"SELECT unit_pric2 FROM t_penawaran_detail WHERE no_pnw = '{nO_PNWComboBox.SelectedValue}'";
            SqlCommand comm6 = new SqlCommand(DataBrg6, con);
            String unit_pric2 = comm6.ExecuteScalar().ToString();

            //DELETE BARANG
            String query = $"DELETE FROM t_invoice_detail WHERE no_inv = '{tb_noINV.Text}'";
            comm = new SqlCommand(query, con);
            comm.ExecuteNonQuery();

            con.Close();
            data_invoice();
        }

        private void dgv_dataInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tb_grandTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void pPNTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dISCOUNTTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pPNLabel_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dISCOUNTLabel_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tb_Kode_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_totalBeli_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cb_nmbarang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tb_qty_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainHome form_Home = new mainHome();
            form_Home.Show();
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            this.Hide();
            Print_Invoice form_PrintInvoice = new Print_Invoice();
            form_PrintInvoice.Show();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            dgv_dataInvoice.Columns.Clear();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_invoice_headerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uASDataSet);
        }
    }
}
