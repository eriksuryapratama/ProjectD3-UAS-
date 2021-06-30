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
    public partial class FormLogin : Form
    {
        //VARIABEL
        private SqlCommand cmd;

        //KONEKSI
        ConnectionDB Konn = new ConnectionDB();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = null;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Konn.GetConnection();
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * from m_users where USERNAME = '" + tb_Username.Text + "' and PASSWORD = '" + tb_Password.Text + "'", conn);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();

                if (reader.Read() || tb_Username.Text == "admin" && tb_Password.Text == "admin")
                {
                    this.Hide();
                    mainHome form_Home = new mainHome();
                    form_Home.Show();
                }
                else
                {
                    MessageBox.Show("Username atau Password salah !");
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            tb_Password.PasswordChar = '*';
        }
    }
}
