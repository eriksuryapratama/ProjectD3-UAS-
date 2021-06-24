using Data_Layer;
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
    public partial class viewMerk2 : Form
    {
        ConnectionDB db = new ConnectionDB();

        public viewMerk2()
        {
            InitializeComponent();
        }
        Merk2Function bf = new Merk2Function();

        private void clear()
        {
            tb_Search.Clear();
        }

        private void viewMerk2_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = bf.Select();
                dgv_Merk2.DataSource = dt;

                dgv_Merk2.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_Merk2.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_Merk2.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_Merk2.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_Merk2.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {

            }
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            string keyword = tb_Search.Text;
            SqlConnection con = new SqlConnection(db.GetConnection());
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM m_merk WHERE MERK_DESC LIKE '%" + keyword + "%'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_Merk2.DataSource = dt;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            bf.namaMerk = textBox1.Text;
            bool success = bf.Delete(bf);
            if (success == true)
            {
                MessageBox.Show("Data Merk Berhasil Dihapus");

                DataTable dt = bf.Select();
                dgv_Merk2.DataSource = dt;
                clear();
            }
            else
            {
                MessageBox.Show("Gagal Menghapus Data Merk");
            }
        }

        private void dgv_Merk2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textBox1.Text = dgv_Merk2.Rows[rowIndex].Cells[2].Value.ToString();
        }

        private void btn_addData_Click(object sender, EventArgs e)
        {
            this.Hide();
            masterMerk2 formPelanggan = new masterMerk2();
            formPelanggan.ShowDialog();
        }
    }
}
