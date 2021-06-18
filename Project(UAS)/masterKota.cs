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
        SqlConnection con;
        SqlCommand cmd;
        ConnectionDB db = new ConnectionDB();
        SqlDataReader dr;
        SqlDataAdapter da;

        public masterKota()
        {
            InitializeComponent();
            con = new SqlConnection(db.GetConnection());
            LoadRecords();

        }

        private void clear()
        {
            tb_kota.Clear();
        }

        public void LoadRecords()
        {
            dgv_masterKota.Rows.Clear();
            int i = 0;
            con.Open();
            cmd = new SqlCommand("SELECT * FROM m_kota", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgv_masterKota.Rows.Add(i, dr["NAMAKOTA"].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                Variables_Kota obj = new Variables_Kota();

                if (tb_kota.Text == obj.namaKota)
                {
                    MessageBox.Show("KOTA TELAH TERSEDIA", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                
                obj.namaKota = tb_kota.Text;

                KotaFunction kf = new KotaFunction();
                kf.add(obj);

                MessageBox.Show("Data Kota Berhasil Disimpan", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadRecords();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgv_masterKota_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgv_masterKota.Columns[e.ColumnIndex].Name;
            tb_kota.Text = dgv_masterKota.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void masterKota_Load(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainHome f = new mainHome();
            f.Show();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                Variables_Kota obj = new Variables_Kota();

                if (tb_kota.Text == obj.namaKota)
                {
                    MessageBox.Show("KOTA TELAH TERSEDIA", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                obj.namaKota = tb_kota.Text;

                KotaFunction kf = new KotaFunction();
                kf.editt(obj);

                MessageBox.Show("Data Kota Berhasil Diupdate", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadRecords();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            String query_kota = $"SELECT NAMAKOTA " +
                                $"FROM m_kota " +
                                $"WHERE NAMAKOTA = NAMAKOTA " +
                                $"AND NAMAKOTA like '%{tb_kota.Text}%' ";
            SqlCommand sql_kota = new SqlCommand(query_kota, con);
            SqlDataAdapter adapter = new SqlDataAdapter(sql_kota);
            adapter.Fill(dt);
            dgv_masterKota.DataSource = dt;
            dgv_masterKota.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            con.Close();
        }

        private void tb_kota_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
