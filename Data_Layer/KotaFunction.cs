using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using Business_Layer;
using System.Data;

namespace Data_Layer
{
    public class KotaFunction
    {
        SqlConnection con = new SqlConnection(@"Data Source =.\SQLExpress;Initial Catalog = UAS; User ID = sa; Password=surabaya123321");
        public void add(Variables_Kota obj)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO m_kota (NAMAKOTA) values (@namakota)", con);
            cmd.Parameters.AddWithValue("@namakota", obj.namaKota);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void editt(Variables_Kota obj)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE m_kota SET NAMAKOTA = @namakota", con);
            cmd.Parameters.AddWithValue("@namakota", obj.namaKota);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
