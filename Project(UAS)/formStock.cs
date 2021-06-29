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
    public partial class formStock : Form
    {
        ConnectionDB db = new ConnectionDB();

        public formStock()
        {
            InitializeComponent();
        }

        StockFunction sf = new StockFunction();
        BarangFunction bf = new BarangFunction();

        private void clear()
        {
            tb_idStock.Clear();
            tb_stockMin.Clear();
            tb_stockOnHand.Clear();
        }

        private void formStock_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = sf.Select();
                dgv_Stock.DataSource = dt;

                DataTable dtg = bf.Select();

                cb_IDBarang.DataSource = dtg;
                cb_IDBarang.DisplayMember = "KODE";
                cb_IDBarang.ValueMember = "ID";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sql Server Error " + ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sf.id_stock = tb_idStock.Text;
            sf.id_barang = cb_IDBarang.SelectedValue.ToString();
            sf.stock_min = tb_stockMin.Text;
            sf.stock_on_hand = tb_stockOnHand.Text;

            if (tb_idStock.Text == "" || tb_stockMin.Text == "" || tb_stockOnHand.Text == "")
            {
                MessageBox.Show("Harap isi semua data terlebih dahulu !");
            }
            else
            {
                bool success = sf.Insert(sf);
                if (success == true)
                {
                    MessageBox.Show("Stock Baru telah ditambahkan");
                    clear();
                }
                else
                {
                    MessageBox.Show("Gagal Menambah Stock");
                }

                DataTable dt = sf.Select();
                dgv_Stock.DataSource = dt;
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            sf.id_stock = tb_idStock.Text;
            sf.id_barang = cb_IDBarang.SelectedValue.ToString();
            sf.stock_min = tb_stockMin.Text;
            sf.stock_on_hand = tb_stockOnHand.Text;

            bool success = sf.UpdateJumlahStok(sf);
            if (success == true)
            {
                MessageBox.Show("Data Stock berhasil Diupdate");
                clear();
                DataTable dt = sf.Select();
                dgv_Stock.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Data Stock gagal Diupdate");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sf.id_stock = tb_idStock.Text;
            sf.id_barang = cb_IDBarang.SelectedValue.ToString();
            sf.stock_min = tb_stockMin.Text;
            sf.stock_on_hand = tb_stockOnHand.Text;

            bool success = sf.Delete(sf);
            if (success == true)
            {
                MessageBox.Show("Data Stock Berhasil Dihapus");

                DataTable dt = sf.Select();
                dgv_Stock.DataSource = dt;
                clear();
            }
            else
            {
                MessageBox.Show("Gagal Menghapus Stock");
            }
        }

        private void dgv_Stock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            tb_idStock.Text = dgv_Stock.Rows[rowIndex].Cells[0].Value.ToString();
            cb_IDBarang.SelectedValue = dgv_Stock.Rows[rowIndex].Cells[1].Value.ToString();
            tb_stockMin.Text = dgv_Stock.Rows[rowIndex].Cells[2].Value.ToString();
            tb_stockOnHand.Text = dgv_Stock.Rows[rowIndex].Cells[3].Value.ToString();
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            string keyword = tb_Search.Text;
            SqlConnection con = new SqlConnection(db.GetConnection());
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM stock WHERE ID_BARANG LIKE '%" + keyword + "%'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_Stock.DataSource = dt;
        }
    }
}
