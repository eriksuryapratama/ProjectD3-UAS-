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
        ConnectionDB db = new ConnectionDB();
        SqlDataReader dr;
        SqlDataAdapter da;

        public viewSupplier()
        {
            InitializeComponent();

            
        }

        SupplierFunction bf = new SupplierFunction();

        private void clear()
        {
            tb_Search.Clear();
        }

        private void viewSupplier_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = bf.Select();
                dgv_Supplier.DataSource = dt;

                dgv_Supplier.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_Supplier.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_Supplier.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_Supplier.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                
            }
            catch (Exception ex)
            {

            }
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            string keyword = tb_Search.Text;
            SqlConnection con = new SqlConnection(db.GetConnection());
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM m_supplier WHERE NAMA LIKE '%" + keyword + "%'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_Supplier.DataSource = dt;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            bf.namaSupplier = textBox1.Text;
            bool success = bf.Delete(bf);
            if (success == true)
            {
                MessageBox.Show("Data Supplier Berhasil Dihapus");

                DataTable dt = bf.Select();
                dgv_Supplier.DataSource = dt;
                clear();
            }
            else
            {
                MessageBox.Show("Gagal Menghapus Data Supplier");
            }
        }

        private void dgv_Supplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textBox1.Text = dgv_Supplier.Rows[rowIndex].Cells[1].Value.ToString();
        }

        private void btn_addData_Click(object sender, EventArgs e)
        {
            this.Hide();
            masterSupplier formSupplier = new masterSupplier();
            formSupplier.ShowDialog();
        }
    }
}
