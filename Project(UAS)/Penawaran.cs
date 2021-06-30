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
            // TODO: This line of code loads data into the 'uASDataSet.m_model' table. You can move, or remove it, as needed.
            this.m_modelTableAdapter.Fill(this.uASDataSet.m_model);
            // TODO: This line of code loads data into the 'uASDataSet.t_pembelian_header' table. You can move, or remove it, as needed.
            this.t_pembelian_headerTableAdapter.Fill(this.uASDataSet.t_pembelian_header);
            // TODO: This line of code loads data into the 'uASDataSet.m_barang' table. You can move, or remove it, as needed.
            this.m_barangTableAdapter.Fill(this.uASDataSet.m_barang);
            // TODO: This line of code loads data into the 'uASDataSet.m_supplier' table. You can move, or remove it, as needed.
            this.m_supplierTableAdapter.Fill(this.uASDataSet.m_supplier);
            // TODO: This line of code loads data into the 'uASDataSet.m_pelanggan' table. You can move, or remove it, as needed.
            this.m_pelangganTableAdapter.Fill(this.uASDataSet.m_pelanggan);
            // TODO: This line of code loads data into the 'uASDataSet.t_penawaran_header' table. You can move, or remove it, as needed.
            this.t_penawaran_headerTableAdapter.Fill(this.uASDataSet.t_penawaran_header);
            data_invoice();
        }

        public void data_invoice()
        {
            con.Open();

            //DATA GRID
            DataSet ds = new DataSet();
            String query = $"SELECT mb.kode as KODE,mb.part_no AS 'PART NO',mb.description AS DESCRIPTION,mb.merk1 AS MERK,td.qty AS QUANTITY ,FORMAT(mb.unit_price,'C' , 'id-ID') AS 'BUY PRICE',FORMAT(td.unit_pric2,'C' , 'id-ID') AS 'SELL PRICE',FORMAT((td.qty*td.unit_pric2),'C', 'id-ID') as Amount " +
                           $"FROM m_barang mb,t_penawaran_detail td,t_penawaran_header th " +
                           $"where th.no_pnw = td.no_pnw " +
                           $"and mb.kode = td.kode " +
                           $"and th.no_pnw = '{nO_PNWTextBox.Text}'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
            dgv_penawaran.DataSource = ds.Tables[0];

            //Hitung Total
            String HitungTotal = $"SELECT format(sum(td.qty * td.unit_pric2), 'C', 'id-ID') " +
                                 $"FROM m_barang mb,t_penawaran_detail td,t_penawaran_header th " +
                                 $"where th.no_pnw = td.no_pnw " +
                                 $"and mb.kode = td.kode " +
                                 $"and th.no_pnw = '{nO_PNWTextBox.Text}'";
            SqlCommand commSum1 = new SqlCommand(HitungTotal, con);
            String totalHarga = commSum1.ExecuteScalar().ToString();

            //Hitung Discount
            String Disc = $"SELECT format(sum(td.qty * td.unit_pric2 * 10 / 100), 'C', 'id-ID') " +
                                 $"FROM m_barang mb,t_penawaran_detail td,t_penawaran_header th " +
                                 $"where th.no_pnw = td.no_pnw " +
                                 $"and mb.kode = td.kode " +
                                 $"and th.no_pnw = '{nO_PNWTextBox.Text}'";
            SqlCommand commSum2 = new SqlCommand(Disc, con);
            String discHarga = commSum2.ExecuteScalar().ToString();

            //Hitung PPN
            String ppN = $"SELECT format(sum(td.qty * td.unit_pric2 * 5 / 100), 'C', 'id-ID') " +
                                $"FROM m_barang mb,t_penawaran_detail td,t_penawaran_header th " +
                                $"where th.no_pnw = td.no_pnw " +
                                $"and mb.kode = td.kode " +
                                $"and th.no_pnw = '{nO_PNWTextBox.Text}'";
            SqlCommand commSum3 = new SqlCommand(ppN, con);
            String ppnHarga = commSum3.ExecuteScalar().ToString();

            tb_Discount.Text = discHarga;
            tb_PPN.Text = ppnHarga;
            tb_totalBeli.Text = totalHarga;
            tb_grandTotal.Text = totalHarga;

            con.Close();
        }

        private void btn_tmbhitem_Click(object sender, EventArgs e)
        {
            con.Open();

            this.Validate();
            this.t_penawaran_headerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uASDataSet);

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

            //UNIT PRICE BARANG
            String DataBrg5 = $"SELECT unit_price FROM m_barang WHERE id = '{cb_nmbarang.SelectedValue}'";
            SqlCommand comm5 = new SqlCommand(DataBrg5, con);
            String unit_price = comm5.ExecuteScalar().ToString();

            //QTY
            String Dataz = $"SELECT stock_on_hand FROM stock WHERE id_barang = '{kode}'";
            SqlCommand commz = new SqlCommand(Dataz, con);
            String qtz = commz.ExecuteScalar().ToString();

            //Hitung Total Qty
            String HitungQty = $"SELECT (s.stock_on_hand - {tb_qty.Text}) " +
                                $"FROM stock s, t_penawaran_detail td " +
                                $"where s.id_barang = '{kode}' ";
            SqlCommand commQty = new SqlCommand(HitungQty, con);
            String qtyAkhir = commQty.ExecuteScalar().ToString();

            //PENGECEKAN & INPUT DATA
            String cek = tb_qty.Text;
            int num = -1;
            if (!int.TryParse(cek, out num))
            {
                MessageBox.Show("Data Qty Harus Angka !");
            }
            else
            {
                String DataBrg7 = $"SELECT COUNT(*) FROM t_penawaran_detail WHERE kode = '{kode}' and no_pnw = '{nO_PNWTextBox.Text}'";
                SqlCommand comm7 = new SqlCommand(DataBrg7, con);
                String cekBarang = comm7.ExecuteScalar().ToString();

                int qty = Convert.ToInt32(tb_qty.Text);
                if (qty <= 0)
                {
                    MessageBox.Show("JUMLAH HARUS LEBIH DARI 0");
                    con.Close();
                }
                else
                {
                    if (Convert.ToInt32(cekBarang) > 0)
                    {
                        if (Convert.ToInt32(tb_qty.Text) > Convert.ToInt32(qtz))
                        {
                            MessageBox.Show("Stock Barang Tidak Cukup !");
                        }
                        else
                        {
                            //SELECT
                            String jmlhBarang = $"SELECT qty FROM t_penawaran_detail WHERE kode = '{kode}' and no_pnw = '{nO_PNWTextBox.Text}'";
                            SqlCommand comm8 = new SqlCommand(jmlhBarang, con);
                            String qtyAwal = comm8.ExecuteScalar().ToString();
                            
                            int tambahQTY = qty + Convert.ToInt32(qtyAwal);

                            //UPDATE
                            String queryQ = $"UPDATE stock SET stock_on_hand = {qtyAkhir} where id_barang = '{kode}'";
                            commQty = new SqlCommand(queryQ, con);
                            commQty.ExecuteNonQuery();

                            //UPDATE
                            String query = $"UPDATE t_penawaran_detail SET qty = {tambahQTY} where kode = '{kode}' and no_pnw = '{nO_PNWTextBox.Text}'";
                            comm = new SqlCommand(query, con);
                            comm.ExecuteNonQuery();

                            MessageBox.Show("Berhasil ditambahkan");
                        }
                        con.Close();
                        data_invoice();
                    }
                    else
                    {
                        if (Convert.ToInt32(tb_qty.Text) > Convert.ToInt32(qtz))
                        {
                            MessageBox.Show("Stock Barang Tidak Cukup !");
                        }
                        else
                        {
                            //INSERT
                            String query = $"Insert into t_penawaran_detail(no_pnw, kode, part_no, descriptio, qty, unit_price, unit_pric2) values('{nO_PNWTextBox.Text}','{kode}','{part_no}','{description}','{qty}',{unit_price}, '{tb_hargaJual.Text}')";
                            comm = new SqlCommand(query, con);
                            comm.ExecuteNonQuery();

                            //UPDATE
                            String queryQ = $"UPDATE stock SET stock_on_hand = {qtyAkhir} where id_barang = '{kode}'";
                            commQty = new SqlCommand(queryQ, con);
                            commQty.ExecuteNonQuery();
                            MessageBox.Show("Berhasil ditambahkan");
                        }
                        con.Close();
                        data_invoice();
                    }
                }
            }
            con.Close();
            data_invoice();
        }

        private void dgv_penawaran_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            tb_Kode.Text = dgv_penawaran.Rows[rowIndex].Cells[0].Value.ToString();
        }

        private void btn_hpsitem_Click(object sender, EventArgs e)
        {
            con.Open();

            //KODE BARANG
            String DataBrg = $"SELECT kode FROM m_barang WHERE id = '{cb_nmbarang.SelectedValue}'";
            SqlCommand comm = new SqlCommand(DataBrg, con);
            String kode = comm.ExecuteScalar().ToString();

            //DELETE BARANG
            String query = $"DELETE FROM t_penawaran_detail WHERE KODE = '{tb_Kode.Text}'";
            comm = new SqlCommand(query, con);
            comm.ExecuteNonQuery();

            con.Close();
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

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            data_invoice();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            data_invoice();
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
            PrintPenawaran form_printpenawaran = new PrintPenawaran();
            form_printpenawaran.Show();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_penawaran_headerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uASDataSet);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            dgv_penawaran.Columns.Clear();
        }
    }
}
