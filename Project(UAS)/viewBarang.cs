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
    public partial class viewBarang : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        ConnectionDB db = new ConnectionDB();

        public viewBarang()
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
            cmd = new SqlCommand("SELECT * FROM m_barang", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgv_masterBarang.Rows.Add(i, dr["KODE"].ToString(), dr["PART_NO"].ToString(), dr["DESCRIPTION"].ToString(), dr["UNIT_PRICE"].ToString(), dr["UNIT"].ToString(), dr["STAMPING"].ToString(), dr["DATA_FISIK"].ToString(), dr["PERSAMAAN"].ToString(), dr["PN1"].ToString(), dr["MERK1"].ToString(), dr["MERK2"].ToString(), dr["MERK3"].ToString(), dr["KETERANGAN"].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void m_barangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.m_barangBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uASDataSet);

        }

        private void viewBarang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uASDataSet.m_barang' table. You can move, or remove it, as needed.
            this.m_barangTableAdapter.Fill(this.uASDataSet.m_barang);

        }

        private void btn_addData_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainBarang formBarang = new mainBarang();
            formBarang.ShowDialog();
        }

        private void dgv_masterBarang_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgv_masterBarang.Columns[e.ColumnIndex].Name;

            if (colName == "column_deleted")
            {
                if (MessageBox.Show("Ingin Menghapus Barang ini?", "MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM m_barang WHERE KODE = '" + dgv_masterBarang.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Barang Berhasil Dihapus !", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRecords();
                }
            }
        }
    }
}
