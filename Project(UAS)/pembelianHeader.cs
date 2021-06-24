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
    public partial class pembelianHeader : Form
    {
        ConnectionDB db = new ConnectionDB();
        BindingSource bss = new BindingSource();
        SqlDataAdapter da;

        public pembelianHeader()
        {
            InitializeComponent();
        }

        PembelianHeaderFunction pHf = new PembelianHeaderFunction();
        SupplierFunction bf = new SupplierFunction();

        private void clear()
        {
            tb_fakturPajak.Clear();
            tb_Keterangan.Clear();
            tb_noNota.Clear();
            tb_noNPWP.Clear();
            tb_noUrut.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pembelianHeader_Load(object sender, EventArgs e)
        {
            try
            {
                //DATA PEMBELIAN HEADER
                DataTable dt = pHf.Select();
                dgv_pembelianHeader.DataSource = dt;

                //DATA COMBO BOX
                DataTable dtg = bf.Select();
                cb_Supplier.DataSource = dtg;
                cb_Supplier.DisplayMember = "P_ID";
                cb_Supplier.ValueMember = "P_ID";

                //DATA SUPPLIER
                String sql = $"SELECT * from m_supplier WHERE P_ID = '{cb_Supplier.SelectedValue}'";
                DataTable dtgs = new DataTable();
                SqlConnection conn = new SqlConnection(db.GetConnection());
                da = new SqlDataAdapter(sql, conn);
                da.Fill(dtgs);
                bss.DataSource = dtgs;

                tb_namaNPWP.DataBindings.Add(new Binding("Text", bss, "NAMA_NPWP"));
                tb_alamat.DataBindings.Add(new Binding("Text", bss, "ALAMAT_NPW"));
                tb_Kota.DataBindings.Add(new Binding("Text", bss, "KOTA"));
                tb_nomorTelepon.DataBindings.Add(new Binding("Text", bss, "EMAIL"));
                tb_NOTE.DataBindings.Add(new Binding("Text", bss, "NOTE"));
                tb_noNPWP.DataBindings.Add(new Binding("Text", bss, "NPWP"));

                tb_namaNPWP2.Text = tb_namaNPWP.Text;
                tb_alamatLengkap.Text = tb_alamat.Text + ", " + tb_Kota.Text;
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sql Server Error " + ex);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            pHf.nomor_PNW = tb_noUrut.Text;
            pHf.pembeli_ID = cb_Supplier.SelectedValue.ToString();
            pHf.nomor_NOTA = tb_noNota.Text;
            pHf.faktur_Pajak = tb_fakturPajak.Text;
            pHf.keterangan = tb_Keterangan.Text;
            //pHf.tanggal_PNW = dt_tglInvoice.Value.ToString();

            if (tb_noUrut.Text == "" || tb_noNota.Text == "")
            {
                MessageBox.Show("Harap isi nomor urut dan nomor Nota !");
            }
            else
            {
                bool success = pHf.Insert(pHf);
                if (success == true)
                {
                    MessageBox.Show("Pembelian Baru telah ditambahkan");
                    clear();
                }
                else
                {
                    MessageBox.Show("Gagal Menambah Pembelian");
                }

                DataTable dt = pHf.Select();
                dgv_pembelianHeader.DataSource = dt;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            pHf.nomor_PNW = tb_noUrut.Text;
            pHf.pembeli_ID = cb_Supplier.SelectedValue.ToString();
            pHf.nomor_NOTA = tb_noNota.Text;
            pHf.faktur_Pajak = tb_fakturPajak.Text;
            pHf.keterangan = tb_Keterangan.Text;
            //pHf.tanggal_PNW = dt_tglInvoice.Value.ToString();

            bool success = pHf.Delete(pHf);
            if (success == true)
            {
                MessageBox.Show("Data Pembelian Berhasil Dihapus");

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
            tb_noUrut.Text = dgv_pembelianHeader.Rows[rowIndex].Cells[0].Value.ToString();
            tb_noNota.Text = dgv_pembelianHeader.Rows[rowIndex].Cells[1].Value.ToString();
            cb_Supplier.SelectedValue = dgv_pembelianHeader.Rows[rowIndex].Cells[2].Value.ToString();
            tb_Keterangan.Text = dgv_pembelianHeader.Rows[rowIndex].Cells[5].Value.ToString();
            tb_fakturPajak.Text = dgv_pembelianHeader.Rows[rowIndex].Cells[6].Value.ToString();
        }
    }
}
