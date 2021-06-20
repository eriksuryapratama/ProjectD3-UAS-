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
    public partial class Form1 : Form
    {
        SqlConnection con;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=UAS;Integrated Security=True");
            refreshSupplier();
        }

        public void refreshSupplier()
        {
            con.Open();

            //NAMA
            String temp = $"SELECT nama " +
                         $"FROM m_supplier " +
                         $"WHERE p_id = '{tb_customer.Text}'";
            SqlCommand comm = new SqlCommand(temp, con);
            tb_nmperusahaan.Text = comm.ExecuteScalar().ToString();

            //ALAMAT
            String alamat = $"SELECT alamat " +
                         $"FROM m_supplier " +
                         $"WHERE p_id = '{tb_customer.Text}'";
            SqlCommand commAlamat = new SqlCommand(alamat, con);
            tb_alamat.Text = commAlamat.ExecuteScalar().ToString();


            //NPWP
            String npwp = $"SELECT npwp " +
                         $"FROM m_supplier " +
                         $"WHERE p_id = '{tb_customer.Text}'";
            SqlCommand commNpwp = new SqlCommand(npwp, con);
            textBox6.Text = commNpwp.ExecuteScalar().ToString();


            //NAMANPWP
            String namanpwp = $"SELECT nama_npwp " +
                         $"FROM m_supplier " +
                         $"WHERE p_id = '{tb_customer.Text}'";
            SqlCommand commnamaNpwp = new SqlCommand(namanpwp, con);
            tb_namNpwp.Text = commnamaNpwp.ExecuteScalar().ToString();

            //KOTA
            String kota = $"SELECT kota " +
                         $"FROM m_supplier " +
                         $"WHERE p_id = '{tb_customer.Text}'";
            SqlCommand commKota = new SqlCommand(kota, con);
            tb_kota.Text = commKota.ExecuteScalar().ToString();

            //EMAIL
            String email = $"SELECT EMAIL " +
                        $"FROM m_supplier " +
                        $"WHERE p_id = '{tb_customer.Text}'";
            SqlCommand commEmail = new SqlCommand(email, con);
            tb_email.Text = commKota.ExecuteScalar().ToString();

            //NOTE
            String note = $"SELECT note " +
                        $"FROM m_supplier " +
                        $"WHERE p_id = '{tb_customer.Text}'";
            SqlCommand commNote = new SqlCommand(note, con);
            tb_note.Text = commNote.ExecuteScalar().ToString();


            DataSet ds = new DataSet();
            String query = $"SELECT mb.kode as KODE,mb.part_no AS 'PART NO',mb.description AS DESCRIPTION,mb.unit AS UNIT ,mb.merk1 AS MERK,td.qty AS QUANTITY ,FORMAT(mb.unit_price,'C') AS PRICE,FORMAT((td.qty*mb.unit_price),'C') as Amount " +
                           $"FROM m_barang mb,t_pembelian_detail td,t_pembelian_header th " +
                           $"where mb.kode = td.kode " +
                           $"and th.p_id = '{tb_customer.Text}'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
            dgv_data.DataSource = ds.Tables[0];

            con.Close();
        }

        private void t_invoice_headerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_invoice_headerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uASDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uASDataSet.t_invoice_header' table. You can move, or remove it, as needed.
            this.t_invoice_headerTableAdapter.Fill(this.uASDataSet.t_invoice_header);

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            refreshSupplier();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            refreshSupplier();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            refreshSupplier();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            refreshSupplier();
        }
    }
}
