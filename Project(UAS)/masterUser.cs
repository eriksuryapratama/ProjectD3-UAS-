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
    public partial class masterUser : Form
    {
        ConnectionDB db = new ConnectionDB();

        public masterUser()
        {
            InitializeComponent();
        }

        UserFunction uf = new UserFunction();
        GroupUserFunction cg = new GroupUserFunction();

        private void clear()
        {
            tb_Username.Clear();
            tb_Password.Clear();
        }

        private void masterUser_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = uf.Select();
                dgv_User.DataSource = dt;

                DataTable dtg = cg.Select();

                cb_NamaGroupUser.DataSource = dtg;
                cb_NamaGroupUser.DisplayMember = "NAMAGROUPUSER";
                cb_NamaGroupUser.ValueMember = "NAMAGROUPUSER";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sql Server Error " + ex);
            }
        }

        //BUTTON ADD
        private void btn_Add_Click(object sender, EventArgs e)
        {
            uf.user_Username = tb_Username.Text;
            uf.user_Password = tb_Password.Text;
            uf.user_namaGroupUser = cb_NamaGroupUser.SelectedValue.ToString();

            if (tb_Username.Text == "" || tb_Password.Text == "")
            {
                MessageBox.Show("Tidak ada User yang ditambahkan !");
            }
            else
            {
                bool success = uf.Insert(uf);
                if (success = true)
                {
                    MessageBox.Show("User Baru telah ditambahkan");
                    clear();
                }
                else
                {
                    MessageBox.Show("Gagal Menambah User");
                }

                DataTable dt = uf.Select();
                dgv_User.DataSource = dt;
            }
        }

        //BUTTON EXIT
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainHome f = new mainHome();
            f.Show();
        }

        //BUTTON EDIT
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            uf.user_Username = tb_Username.Text;
            uf.user_Password = tb_Password.Text;
            uf.user_namaGroupUser = cb_NamaGroupUser.SelectedValue.ToString();

            bool success = uf.Update(uf);
            if (success == true)
            {
                MessageBox.Show("Data user berhasil Diupdate");

                DataTable dt = uf.Select();
                dgv_User.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Data user gagal Diupdate");
            }
        }

        //FUNGSI SEARCH
        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            string keyword = tb_Search.Text;
            SqlConnection con = new SqlConnection(db.GetConnection());
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM m_users WHERE USERNAME LIKE '%" + keyword + "%'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_User.DataSource = dt;
        }

        //BUTTON DELETE
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            uf.user_Username = tb_Username.Text;
            uf.user_Password = tb_Password.Text;
            uf.user_namaGroupUser = cb_NamaGroupUser.SelectedValue.ToString();

            bool success = uf.Delete(uf);
            if (success == true)
            {
                MessageBox.Show("Data user Berhasil Dihapus");

                DataTable dt = uf.Select();
                dgv_User.DataSource = dt;
                clear();
            }
            else
            {
                MessageBox.Show("Gagal Menghapus User");
            }
        }

        private void dgv_User_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            tb_Username.Text = dgv_User.Rows[rowIndex].Cells[0].Value.ToString();
            tb_Password.Text = dgv_User.Rows[rowIndex].Cells[1].Value.ToString();
            cb_NamaGroupUser.SelectedValue = dgv_User.Rows[rowIndex].Cells[2].Value.ToString();
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {

        }
    }
}
