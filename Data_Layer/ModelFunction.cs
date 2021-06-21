using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer
{

    public class ModelFunction
    {
        ConnectionDB db = new ConnectionDB();

        public string namaModel { get; set; }

        public DataTable Select()
        {
            SqlConnection con = new SqlConnection(db.GetConnection());
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM m_model";
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

        public bool Insert(ModelFunction bf)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(db.GetConnection());
            try
            {
                string sql = "INSERT INTO m_model (DESCRIPTION) values (@description)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@description", bf.namaModel);

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

        public bool Update(ModelFunction bf)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(db.GetConnection());
            try
            {
                string sql = "UPDATE m_model SET DESCRIPTION = @description WHERE MODEL_ID = @model_id";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@description", bf.namaModel);

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

        public bool Delete(ModelFunction bf)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(db.GetConnection());
            try
            {
                string sql = "DELETE FROM m_model WHERE DESCRIPTION = @description";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@description", bf.namaModel);

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
