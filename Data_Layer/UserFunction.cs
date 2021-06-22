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
    public class UserFunction
    {
        ConnectionDB db = new ConnectionDB();
        public string user_Username { get; set; }
        public string user_Password { get; set; }
        public string user_namaGroupUser { get; set; }


        //SELECT
        public DataTable Select()
        {
            SqlConnection con = new SqlConnection(db.GetConnection());
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM m_users";
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

        //INSERT
        public bool Insert(UserFunction uf)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(db.GetConnection());
            try
            {
                string sql = "INSERT INTO m_users (USERNAME, PASSWORD, NAMAGROUPUSER) values (@username, @password, @namagroupuser)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@username", uf.user_Username);
                cmd.Parameters.AddWithValue("@password", uf.user_Password);
                cmd.Parameters.AddWithValue("@namagroupuser", uf.user_namaGroupUser);

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

        //UPDATE
        public bool Update(UserFunction uf)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(db.GetConnection());
            try
            {
                string sql = "UPDATE m_users SET PASSWORD = @password, NAMAGROUPUSER = @namagroupuser WHERE USERNAME = @username";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@username", uf.user_Username);
                cmd.Parameters.AddWithValue("@password", uf.user_Password);
                cmd.Parameters.AddWithValue("@namagroupuser", uf.user_namaGroupUser);

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

        //DELETE
        public bool Delete(UserFunction uf)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(db.GetConnection());
            try
            {
                string sql = "DELETE FROM m_users WHERE USERNAME = @username";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@username", uf.user_namaGroupUser);

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
