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
    public partial class masterPelanggan : Form
    {
        public masterPelanggan()
        {
            InitializeComponent();
        }

        private void m_pelangganBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.m_pelangganBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uASDataSet);

        }

        private void masterPelanggan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uASDataSet.m_kota' table. You can move, or remove it, as needed.
            this.m_kotaTableAdapter.Fill(this.uASDataSet.m_kota);
            // TODO: This line of code loads data into the 'uASDataSet.m_pelanggan' table. You can move, or remove it, as needed.
            this.m_pelangganTableAdapter.Fill(this.uASDataSet.m_pelanggan);

        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewPelanggan formViewPelanggan = new viewPelanggan();
            formViewPelanggan.ShowDialog();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void nAMALabel_Click(object sender, EventArgs e)
        {

        }

        private void aLAMATLabel_Click(object sender, EventArgs e)
        {

        }

        private void nAMA1Label_Click(object sender, EventArgs e)
        {

        }

        private void aLAMAT1Label_Click(object sender, EventArgs e)
        {

        }

        private void hPLabel_Click(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainHome form_Home = new mainHome();
            form_Home.Show();
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            this.Hide();
            Print_Master_Pelanggan form_PrintPelanggan = new Print_Master_Pelanggan();
            form_PrintPelanggan.Show();
        }
    }
}
