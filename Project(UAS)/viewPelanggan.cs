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
        SqlConnection con;
        SqlCommand cmd;
        ConnectionDB db = new ConnectionDB();
        SqlDataReader dr;
        SqlDataAdapter da;

        public viewPelanggan()
        {
            InitializeComponent();

        }

        PelangganFunction bf = new PelangganFunction();

        private void clear()
        {
            tb_Search.Clear();
        }

        public void LoadRecords()
        {
            dgv_Pelanggan.Rows.Clear();
            int i = 0;
            con.Open();
            cmd = new SqlCommand("SELECT * FROM m_pelanggan", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgv_Pelanggan.Rows.Add(i, dr["P_CODE"].ToString(), dr["NAMA"].ToString(), dr["ALAMAT"].ToString(), dr["KOTA"].ToString(), dr["TELP"].ToString(), dr["NPWP"].ToString(), dr["NAMA_NPWP"].ToString(), dr["ALAMAT_NPWP"].ToString(), dr["NAMA1"].ToString(), dr["ALAMAT1"].ToString(), dr["KOTA1"].ToString(), dr["HP"].ToString(), dr["KETERANGAN"].ToString());
            }
            dr.Close();
            con.Close();
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
            catch (Exception ex)
            {

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
