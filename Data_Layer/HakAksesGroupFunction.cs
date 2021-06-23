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
    public class HakAksesGroupFunction
    {
        ConnectionDB db = new ConnectionDB();

        public string HAG_namaGroupUser { get; set; }
        public string HAG_NamaMenu { get; set; }

        public DataTable Select()
        {
            SqlConnection con = new SqlConnection(db.GetConnection());
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM m_hakaksesgroupuser";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public bool Insert(HakAksesGroupFunction hf)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(db.GetConnection());
            try
            {
                string sql = "INSERT INTO m_hakaksesgroupuser (NAMAGROUPUSER, NAMAMENU) values (@namagroupuser, @namamenu)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@namagroupuser", hf.HAG_namaGroupUser);
                
                cmd.Parameters.AddWithValue("@namamenu", hf.HAG_NamaMenu);

                con.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }

        public bool Update(HakAksesGroupFunction hf)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(db.GetConnection());
            try
            {
                string sql = "UPDATE m_hakaksesgroupuser SET NAMAGROUPUSER = @namagroupuser, NAMAMENU = @namamenu WHERE NAMAGROUPUSER = @namagroupuser";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@namagroupuser", hf.HAG_namaGroupUser);

                cmd.Parameters.AddWithValue("@namamenu", hf.HAG_NamaMenu);

                con.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }

        public bool Delete(HakAksesGroupFunction hf)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(db.GetConnection());
            try
            {
                string sql = "DELETE FROM m_hakaksesgroupuser WHERE NAMAGROUPUSER = @namagroupuser";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@namagroupuser", hf.HAG_namaGroupUser);

                cmd.Parameters.AddWithValue("@namamenu", hf.HAG_NamaMenu);

                con.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }

    }
}
