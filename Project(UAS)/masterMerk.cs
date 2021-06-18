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
using Business_Layer;
using Data_Layer;

namespace Project_UAS_
{
    public partial class masterMerk : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        ConnectionDB db = new ConnectionDB();
        SqlDataAdapter da;
        viewMerk f;

        public masterMerk()
        {
            InitializeComponent();

            con = new SqlConnection(db.GetConnection());
        }
        

        private void btn_Add_Click(object sender, EventArgs e)
        {
            
        }

        private void masterMerk_Load(object sender, EventArgs e)
        {

        }
    }
}
