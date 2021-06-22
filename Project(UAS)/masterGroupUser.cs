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
    public partial class masterGroupUser : Form
    {
        ConnectionDB db = new ConnectionDB();

        public masterGroupUser()
        {
            InitializeComponent();
        }

        GroupUserFunction cg = new GroupUserFunction();

        private void clear()
        {
            tb_Groupuser.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            cg.namaGroupUser = tb_Groupuser.Text;
            if (tb_Groupuser.Text == "")
            {
                MessageBox.Show("Tidak ada group yang ditambahkan !");
            }
            else
            {
                bool success = cg.Insert(cg);
                if (success = true)
                {
                    MessageBox.Show("Group Baru telah ditambahkan");
                    clear();
                }
                else
                {
                    MessageBox.Show("Gagal Menambah Group");
                }

                DataTable dt = cg.Select();
                dgv_Group.DataSource = dt;
            }

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            cg.namaGroupUser = tb_Groupuser.Text;

            bool success = cg.Update(cg);
            if (success == true)
            {
                MessageBox.Show("Group berhasil Diupdate");

                DataTable dt = cg.Select();
                dgv_Group.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Group gagal Diupdate");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            cg.namaGroupUser = tb_Groupuser.Text;
            bool success = cg.Delete(cg);
            if (success == true)
            {
                MessageBox.Show("Group Berhasil Dihapus");

                DataTable dt = cg.Select();
                dgv_Group.DataSource = dt;
                clear();
            }
            else
            {
                MessageBox.Show("Gagal Menghapus Group");
            }
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            string keyword = tb_Search.Text;
            SqlConnection con = new SqlConnection(db.GetConnection());
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM m_groupuser WHERE NAMAGROUPUSER LIKE '%" + keyword + "%'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_Group.DataSource = dt;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainHome form_Menu = new mainHome();
            form_Menu.Show();
        }

        private void masterGroupUser_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = cg.Select();
                dgv_Group.DataSource = dt;
            }
            catch (Exception ex)
            {

            }
        }

        private void dgv_Group_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            tb_Groupuser.Text = dgv_Group.Rows[rowIndex].Cells[0].Value.ToString();
        }
    }
}
