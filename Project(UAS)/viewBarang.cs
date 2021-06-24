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
    public partial class viewBarang : Form
    {
        ConnectionDB db = new ConnectionDB();

        public viewBarang()
        {
            InitializeComponent();
        }

        BarangFunction bf = new BarangFunction();

        private void clear()
        {
            tb_Search.Clear();
        }

        private void viewBarang_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = bf.Select();
                dgv_Barang.DataSource = dt;

                dgv_Barang.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_Barang.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_Barang.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_Barang.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_Barang.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sql Server Error " + ex);
            }
        }

        private void btn_addData_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainBarang formBarang = new mainBarang();
            formBarang.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            string keyword = tb_Search.Text;
            SqlConnection con = new SqlConnection(db.GetConnection());
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM m_barang WHERE DESCRIPTION LIKE '%" + keyword + "%'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_Barang.DataSource = dt;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            bf.namaBarang = textBox1.Text;
            bool success = bf.Delete(bf);
            if (success == true)
            {
                MessageBox.Show("Barang Berhasil Dihapus");

                DataTable dt = bf.Select();
                dgv_Barang.DataSource = dt;
                clear();
            }
            else
            {
                MessageBox.Show("Gagal Menghapus Barang");
            }
        }

        private void dgv_Barang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textBox1.Text = dgv_Barang.Rows[rowIndex].Cells[3].Value.ToString();
        }
    }
}
