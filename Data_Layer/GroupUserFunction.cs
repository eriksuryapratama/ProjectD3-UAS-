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
    public class GroupUserFunction
    {
        ConnectionDB db = new ConnectionDB();
        public string namaGroupUser { get; set; }

        //SELECT
        public DataTable Select()
        {
            SqlConnection con = new SqlConnection(db.GetConnection());
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM m_groupuser";
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
        public bool Insert(GroupUserFunction cg)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(db.GetConnection());
            try
            {
                string sql = "INSERT INTO m_groupuser (NAMAGROUPUSER) values (@namagroupuser)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@namagroupuser", cg.namaGroupUser);

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
        public bool Update(GroupUserFunction cg)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(db.GetConnection());
            try
            {
                string sql = "UPDATE m_groupuser SET NAMAGROUPUSER = @namagroupuser";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@namagroupuser", cg.namaGroupUser);

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
        public bool Delete(GroupUserFunction cg)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(db.GetConnection());
            try
            {
                string sql = "DELETE FROM m_groupuser WHERE NAMAGROUPUSER = @namagroupuser";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@namagroupuser", cg.namaGroupUser);

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
