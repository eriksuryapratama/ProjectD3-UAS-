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
    public partial class viewPelanggan : Form
    {
        ConnectionDB db = new ConnectionDB();

        public viewPelanggan()
        {
            InitializeComponent();

        }

        PelangganFunction bf = new PelangganFunction();

        private void clear()
        {
            tb_Search.Clear();
        }
        

        private void viewPelanggan_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = bf.Select();
                dgv_Pelanggan.DataSource = dt;

                dgv_Pelanggan.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_Pelanggan.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_Pelanggan.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_Pelanggan.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_Pelanggan.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sql Server Error " + ex);
            }
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            string keyword = tb_Search.Text;
            SqlConnection con = new SqlConnection(db.GetConnection());
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM m_pelanggan WHERE NAMA LIKE '%" + keyword + "%'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_Pelanggan.DataSource = dt;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            bf.namaPelanggan = textBox1.Text;
            bool success = bf.Delete(bf);
            if (success == true)
            {
                MessageBox.Show("Data Pelanggan Berhasil Dihapus");

                DataTable dt = bf.Select();
                dgv_Pelanggan.DataSource = dt;
                clear();
            }
            else
            {
                MessageBox.Show("Gagal Menghapus Data Pelanggan");
            }
        }

        private void dgv_Pelanggan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowIndex = e.RowIndex;
            textBox1.Text = dgv_Pelanggan.Rows[rowIndex].Cells[2].Value.ToString();
        }

        private void btn_addData_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            masterPelanggan formPelanggan = new masterPelanggan();
            formPelanggan.ShowDialog();
        }
    }
}
