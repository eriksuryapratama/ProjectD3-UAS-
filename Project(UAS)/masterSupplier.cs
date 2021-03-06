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
    public partial class masterSupplier : Form
    {
        public masterSupplier()
        {
            InitializeComponent();
        }

        private void m_supplierBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (p_IDTextBox.TextLength == 0 || nAMATextBox.TextLength == 0 || aLAMATTextBox.TextLength == 0 || tELP_HPTextBox.TextLength == 0)
            {
                MessageBox.Show("Data Supplier Tidak boleh kosong !");
            }
            else 
            {
                this.Validate();
                this.m_supplierBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.uASDataSet);
                MessageBox.Show("Data supplier berhasil ditambahkan");
            }
        }

        private void masterSupplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uASDataSet.m_kota' table. You can move, or remove it, as needed.
            this.m_kotaTableAdapter.Fill(this.uASDataSet.m_kota);
            // TODO: This line of code loads data into the 'uASDataSet.m_supplier' table. You can move, or remove it, as needed.
            this.m_supplierTableAdapter.Fill(this.uASDataSet.m_supplier);

        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewSupplier formViewSupplier = new viewSupplier();
            formViewSupplier.ShowDialog();
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
            PrintSupplier form_printsupplier = new PrintSupplier();
            form_printsupplier.Show();
        }
    }
}
