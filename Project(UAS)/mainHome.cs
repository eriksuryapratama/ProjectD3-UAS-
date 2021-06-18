using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_UAS_
{
    public partial class mainHome : Form
    {
        public mainHome()
        {
            InitializeComponent();
        }

        private void btn_mBarang_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainBarang form_Barang = new mainBarang();
            form_Barang.Show();
        }

        private void btn_mPelanggan_Click(object sender, EventArgs e)
        {
            this.Hide();
            masterPelanggan form_Pelanggan = new masterPelanggan();
            form_Pelanggan.Show();
        }

        private void btn_mSupplier_Click(object sender, EventArgs e)
        {
            this.Hide();
            masterSupplier form_Supplier = new masterSupplier();
            form_Supplier.Show();
        }

        private void btn_mKota_Click(object sender, EventArgs e)
        {
            this.Hide();
            masterKota form_Kota = new masterKota();
            form_Kota.Show();
        }
    }
}
