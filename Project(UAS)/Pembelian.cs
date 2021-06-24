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
    public partial class Pembelian : Form
    {
        PembelianHeaderFunction pHf = new PembelianHeaderFunction();

        public Pembelian()
        {
            InitializeComponent();
        }

        private void t_pembelian_headerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_pembelian_headerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uASDataSet);

            try
            {
                DataTable dt = pHf.Select();
                dgv_pembelianHeader.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sql Server Error " + ex);
            }
        }

        private void Pembelian_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uASDataSet.m_supplier' table. You can move, or remove it, as needed.
            this.m_supplierTableAdapter.Fill(this.uASDataSet.m_supplier);
            // TODO: This line of code loads data into the 'uASDataSet.t_pembelian_header' table. You can move, or remove it, as needed.
            this.t_pembelian_headerTableAdapter.Fill(this.uASDataSet.t_pembelian_header);

            tb_NPWP2.Text = nAMA_NPWPTextBox.Text;
            tb_Alamat.Text = aLAMAT_NPWTextBox.Text + ", " + kOTATextBox.Text;

            try
            {
                DataTable dt = pHf.Select();
                dgv_pembelianHeader.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sql Server Error " + ex);
            }
        }

        private void clear()
        {
            nO_PNWTextBox.Clear();
            nO_NOTATextBox.Clear();
            nPWPTextBox.Clear();
            fAKTUR_PAJTextBox.Clear();
            nAMA_NPWPTextBox.Clear();
            aLAMAT_NPWTextBox.Clear();
            kOTATextBox.Clear();
            nOTETextBox.Clear();
            tb_NPWP2.Clear();
            tb_Alamat.Clear();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            pHf.nomor_PNW = nO_PNWTextBox.Text;
            bool success = pHf.Delete(pHf);
            if (success == true)
            {
                MessageBox.Show("Pembelian Berhasil Dihapus");

                DataTable dt = pHf.Select();
                dgv_pembelianHeader.DataSource = dt;
                clear();
            }
            else
            {
                MessageBox.Show("Gagal Menghapus Pembelian");
            }
        }

        private void dgv_pembelianHeader_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            nO_PNWTextBox.Text = dgv_pembelianHeader.Rows[rowIndex].Cells[0].Value.ToString();
            nO_NOTATextBox.Text = dgv_pembelianHeader.Rows[rowIndex].Cells[1].Value.ToString();
            nPWPTextBox.Text = dgv_pembelianHeader.Rows[rowIndex].Cells[2].Value.ToString();
            tGL_PNWDateTimePicker.Text = dgv_pembelianHeader.Rows[rowIndex].Cells[3].Value.ToString();

            kETERANGANTextBox.Text = dgv_pembelianHeader.Rows[rowIndex].Cells[5].Value.ToString();
            fAKTUR_PAJTextBox.Text = dgv_pembelianHeader.Rows[rowIndex].Cells[6].Value.ToString();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void nO_NOTATextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
