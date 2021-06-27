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
    public partial class mainBarang : Form
    {

        public mainBarang()
        {
            InitializeComponent();
        }

        private void m_barangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if(kODETextBox.TextLength == 0 || dESCRIPTIONTextBox.TextLength == 0 || pART_NOTextBox.TextLength == 0 || uNIT_PRICETextBox.TextLength == 0 || uNITTextBox.TextLength == 0)
            {
                MessageBox.Show("Kode Barang, Nama Barang, Part Nomor, Unit, Harga satuan tidak boleh kosong !");
            }
            else
            {
                this.Validate();
                this.m_barangBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.uASDataSet);
                MessageBox.Show("Data barang berhasil ditambahkan");
            }
        }

        private void mainBarang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uASDataSet.m_merk' table. You can move, or remove it, as needed.
            this.m_merkTableAdapter.Fill(this.uASDataSet.m_merk);
            // TODO: This line of code loads data into the 'uASDataSet.m_barang' table. You can move, or remove it, as needed.
            this.m_barangTableAdapter.Fill(this.uASDataSet.m_barang);
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewBarang formViewBarang = new viewBarang();
            formViewBarang.ShowDialog();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            this.Hide();
            Print_Master_Barang form_PrintBarang = new Print_Master_Barang();
            form_PrintBarang.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainHome form_Home = new mainHome();
            form_Home.Show();
        }
    }
}
