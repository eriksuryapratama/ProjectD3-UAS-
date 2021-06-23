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
    public partial class masterKota : Form
    {
        ConnectionDB db = new ConnectionDB();

        public masterKota()
        {
            InitializeComponent();
        }

        KotaFunction c = new KotaFunction();

        private void clear()
        {
            tb_Kota.Clear();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            c.namaKota = tb_Kota.Text;
            if(tb_Kota.Text == "")
            {
                MessageBox.Show("Tidak ada kota yang ditambahkan !");
            }
            else
            {
                bool success = c.Insert(c);
                if (success = true)
                {
                    MessageBox.Show("Kota Baru telah ditambahkan");
                    clear();
                }
                else
                {
                    MessageBox.Show("Gagal Menambah Kota");
                }

                DataTable dt = c.Select();
                dgv_Kota.DataSource = dt;
            }
           
        }

        private void masterKota_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = c.Select();
                dgv_Kota.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sql Server Error " + ex);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainHome f = new mainHome();
            f.Show();
        }

        //private void btn_Edit_Click(object sender, EventArgs e)
        //{
        //    c.namaKota = tb_Kota.Text;

        //    bool success = c.Update(c);
        //    if(success == true)
        //    {
        //        MessageBox.Show("Kota berhasil Diupdate");

        //        DataTable dt = c.Select();
        //        dgv_Kota.DataSource = dt;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Kota gagal Diupdate");
        //    }

        //}

        private void dgv_Kota_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            tb_Kota.Text = dgv_Kota.Rows[rowIndex].Cells[0].Value.ToString();
        }

        private void dgv_Kota_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            tb_Kota.Text = dgv_Kota.Rows[rowIndex].Cells[0].Value.ToString();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            c.namaKota = tb_Kota.Text;
            bool success = c.Delete(c);
            if(success == true)
            {
                MessageBox.Show("Kota Berhasil Dihapus");

                DataTable dt = c.Select();
                dgv_Kota.DataSource = dt;
                clear();
            }
            else
            {
                MessageBox.Show("Gagal Menghapus Kota");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string keyword = tb_Search.Text;
            SqlConnection con = new SqlConnection(db.GetConnection());
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM m_kota WHERE NAMAKOTA LIKE '%"+keyword+"%'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_Kota.DataSource = dt;
        }

        private void tb_Kota_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
