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
    public partial class masterHakAksesGroup : Form
    {
        ConnectionDB db = new ConnectionDB();

        public masterHakAksesGroup()
        {
            InitializeComponent();
        }

        HakAksesGroupFunction hf = new HakAksesGroupFunction();
        GroupUserFunction cg = new GroupUserFunction();

        private void masterHakAksesGroup_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = hf.Select();
                dgv_HAG.DataSource = dt;

                DataTable dtg = cg.Select();

                cb_gu.DataSource = dtg;
                cb_gu.DisplayMember = "NAMAGROUPUSER";
                cb_gu.ValueMember = "NAMAGROUPUSER";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sql Server Error " + ex);
            }
        }

        private void clear()
        {
            tb_nm.Clear();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            hf.HAG_namaGroupUser = cb_gu.SelectedValue.ToString();

            hf.HAG_NamaMenu = tb_nm.Text;


            if (tb_nm.Text == "")
            {
                MessageBox.Show("Tidak ada Hak Akses Group yang ditambahkan !");
            }
            else
            {
                bool success = hf.Insert(hf);
                if (success = true)
                {
                    MessageBox.Show("Hak Akses Group telah ditambahkan");
                    clear();
                }
                else
                {
                    MessageBox.Show("Gagal Menambah Hak Akses Group");
                }

                DataTable dt = hf.Select();
                dgv_HAG.DataSource = dt;
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            hf.HAG_namaGroupUser = cb_gu.SelectedValue.ToString();

            hf.HAG_NamaMenu = tb_nm.Text;
            
            bool success = hf.Update(hf);
            if (success == true)
            {
                MessageBox.Show("Data Hak Akses Group berhasil Diupdate");

                DataTable dt = hf.Select();
                dgv_HAG.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Data Hak Akses Group gagal Diupdate");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            hf.HAG_namaGroupUser = cb_gu.SelectedValue.ToString();

            hf.HAG_NamaMenu = tb_nm.Text;

            bool success = hf.Delete(hf);
            if (success == true)
            {
                MessageBox.Show("Data Hak Akses Group Berhasil Dihapus");

                DataTable dt = hf.Select();
                dgv_HAG.DataSource = dt;
                clear();
            }
            else
            {
                MessageBox.Show("Gagal Menghapus Hak Akses Group");
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainHome f = new mainHome();
            f.Show();
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            string keyword = tb_Search.Text;
            SqlConnection con = new SqlConnection(db.GetConnection());
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM m_hakaksesgroupuser WHERE NAMAGROUPUSER LIKE '%" + keyword + "%'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_HAG.DataSource = dt;
        }

        private void dgv_HAG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            cb_gu.SelectedValue = dgv_HAG.Rows[rowIndex].Cells[0].Value.ToString();
            tb_nm.Text = dgv_HAG.Rows[rowIndex].Cells[1].Value.ToString();
            
        }
    }
}
