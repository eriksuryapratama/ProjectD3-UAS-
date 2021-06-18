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
    public partial class viewMerk : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        ConnectionDB db = new ConnectionDB();

        public viewMerk()
        {
            InitializeComponent();

            con = new SqlConnection(db.GetConnection());
            LoadRecords();
        }

        public void LoadRecords()
        {
            dgv_masterBarang.Rows.Clear();
            int i = 0;
            con.Open();
            cmd = new SqlCommand("SELECT * FROM m_merk", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgv_masterBarang.Rows.Add(i, dr["MERK_CODE"].ToString(), dr["MERK_DESC"].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void dgv_masterBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgv_masterBarang.Columns[e.ColumnIndex].Name;

            if (colName == "column_deleted")
            {
                if (MessageBox.Show("Ingin Menghapus Merk ini?", "MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM m_merk WHERE MERK_CODE = '" + dgv_masterBarang.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Merk Berhasil Dihapus !", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRecords();
                }
            }
        }

        private void btn_addData_Click(object sender, EventArgs e)
        {
            
        }
    }
}
