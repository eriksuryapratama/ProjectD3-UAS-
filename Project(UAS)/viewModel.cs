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
    public partial class viewModel : Form
    {
        ConnectionDB db = new ConnectionDB();

        public viewModel()
        {
            InitializeComponent();
        }

        ModelFunction bf = new ModelFunction();

        private void clear()
        {
            tb_Search.Clear();
        }

        private void viewModel_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = bf.Select();
                dgv_Model.DataSource = dt;

                dgv_Model.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_Model.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_Model.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_Model.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_Model.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {

            }
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            string keyword = tb_Search.Text;
            SqlConnection con = new SqlConnection(db.GetConnection());
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM m_model WHERE DESCRIPTION LIKE '%" + keyword + "%'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_Model.DataSource = dt;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            bf.namaModel = textBox1.Text;
            bool success = bf.Delete(bf);
            if (success == true)
            {
                MessageBox.Show("Data Model Berhasil Dihapus");

                DataTable dt = bf.Select();
                dgv_Model.DataSource = dt;
                clear();
            }
            else
            {
                MessageBox.Show("Gagal Menghapus Data Model");
            }
        }

        private void dgv_Model_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textBox1.Text = dgv_Model.Rows[rowIndex].Cells[1].Value.ToString();
        }

        private void btn_addData_Click(object sender, EventArgs e)
        {
            this.Hide();
            masterModel formModel = new masterModel();
            formModel.ShowDialog();
        }
    }
}
