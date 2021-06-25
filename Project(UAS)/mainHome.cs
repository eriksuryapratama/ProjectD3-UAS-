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

        private void btn_mGroupuser_Click(object sender, EventArgs e)
        {
            this.Hide();
            masterGroupUser form_Group = new masterGroupUser();
            form_Group.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_mModel_Click(object sender, EventArgs e)
        {
            this.Hide();
            masterModel form_Group = new masterModel();
            form_Group.Show();
        }

        private void btn_mUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            masterUser form_User = new masterUser();
            form_User.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin form_Login = new FormLogin();
            form_Login.Show();
        }

        private void btn_mMerk_Click(object sender, EventArgs e)
        {
            this.Hide();
            masterMerk2 form_Group = new masterMerk2();
            form_Group.Show();
        }

        private void btn_mHakaksesgroupuser_Click(object sender, EventArgs e)
        {
            this.Hide();
            masterHakAksesGroup form_Group = new masterHakAksesGroup();
            form_Group.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pembelian form_Group = new Pembelian();
            form_Group.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Penawaran form_Group = new Penawaran();
            form_Group.Show();
        }
    }
}
