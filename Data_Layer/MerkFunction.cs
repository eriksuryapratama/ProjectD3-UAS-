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
    public class MerkFunction
    {
        SqlConnection con = new SqlConnection(@"Data Source =.\SQLExpress;Initial Catalog = UAS; User ID = sa; Password=surabaya123321");
        public void add(Variables_Merk obj)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO m_merk (ID, MERK_CODE, MERK_DESC) values (@id, @merk_code, @merk_desc)", con);
            cmd.Parameters.AddWithValue("@id", obj.merkID);
            cmd.Parameters.AddWithValue("@merk_code", obj.merkCode);
            cmd.Parameters.AddWithValue("@merk_desc", obj.merkDesc);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void editt(Variables_Merk obj)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE m_merk SET MERK_CODE = @merk_code, MERK_DESC = @merk_desc WHERE ID = @id", con);
            cmd.Parameters.AddWithValue("@id", obj.merkID);
            cmd.Parameters.AddWithValue("@merk_code", obj.merkCode);
            cmd.Parameters.AddWithValue("@merk_desc", obj.merkDesc);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
