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
        SqlConnection con;
        SqlCommand cmd;
        ConnectionDB db = new ConnectionDB();
        SqlDataReader dr;
        SqlDataAdapter da;

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
            cb_NamaGroupUser.SelectedValue = 1;
        }

        private void masterUser_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = uf.Select();
                dgv_Kota.DataSource = dt;

                DataTable dtg = cg.Select();

                cb_NamaGroupUser.DataSource = dtg;
                cb_NamaGroupUser.DisplayMember = "NAMAGROUPUSER";
                cb_NamaGroupUser.ValueMember = "NAMAGROUPUSER";
            }
            catch (Exception ex)
            {

            }
        }

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
                dgv_Kota.DataSource = dt;
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainHome f = new mainHome();
            f.Show();
        }
    }
}
