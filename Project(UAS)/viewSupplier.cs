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
    public partial class viewSupplier : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        ConnectionDB db = new ConnectionDB();

        public viewSupplier()
        {
            InitializeComponent();

            con = new SqlConnection(db.GetConnection());
            LoadRecords();
        }

        public void LoadRecords()
        {
            dgv_masterSupplier.Rows.Clear();
            int i = 0;
            con.Open();
            cmd = new SqlCommand("SELECT * FROM m_supplier", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgv_masterSupplier.Rows.Add(i, dr["P_ID"].ToString(), dr["NAMA"].ToString(), dr["ALAMAT"].ToString(), dr["KOTA"].ToString(), dr["TELP_HP"].ToString(), dr["NPWP"].ToString(), dr["NAMA_NPWP"].ToString(), dr["ALAMAT_NPW"].ToString(), dr["EMAIL"].ToString(), dr["BANK"].ToString(), dr["NOTE"].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void btn_addData_Click(object sender, EventArgs e)
        {
            this.Hide();
            masterSupplier formSupplier = new masterSupplier();
            formSupplier.ShowDialog();
        }

        private void dgv_masterSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgv_masterSupplier.Columns[e.ColumnIndex].Name;

            if (colName == "column_deleted")
            {
                if (MessageBox.Show("Ingin Menghapus Data Pelanggan ini?", "MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM m_supplier WHERE P_ID = '" + dgv_masterSupplier.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data Pelanggan Berhasil Dihapus !", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRecords();
                }
            }
        }
    }
}
