using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer
{
    public class PelangganFunction
    {
        ConnectionDB db = new ConnectionDB();
        public string namaPelanggan { get; set; }

        public DataTable Select()
        {
            SqlConnection con = new SqlConnection(db.GetConnection());
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM m_pelanggan";
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

        public bool Insert(PelangganFunction bf)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(db.GetConnection());
            try
            {
                string sql = "INSERT INTO m_pelanggan (P_CODE, NAMA, ALAMAT, KOTA, TELP, NPWP, NAMA_NPWP, ALAMAT_NPWP, NAMA1, ALAMAT1, KOTA1, HP, KETERANGAN) values (@p_code, @nama, @alamat, @kota, @telp, @npwp, @nama_npwp, @alamat_npwp, @nama1, @alamat1, @kota1, @hp, @keterangan)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nama", bf.namaPelanggan);

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

        public bool Update(PelangganFunction bf)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(db.GetConnection());
            try
            {
                string sql = "UPDATE m_pelanggan SET NAMA = @nama, ALAMAT = @alamat, KOTA = @kota, TELP = @telp, NPWP = @npwp, NAMA_NPWP = @nama_npwp, ALAMAT_NPWP = @alamat_npwp, NAMA1 = @nama1, ALAMAT1 = @alamat1, KOTA1 = @kota1, HP = @hp, KETERANGAN = @keterangan WHERE P_CODE = @p_code";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nama", bf.namaPelanggan);

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

        public bool Delete(PelangganFunction bf)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(db.GetConnection());
            try
            {
                string sql = "DELETE FROM m_pelanggan WHERE NAMA = @nama";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nama", bf.namaPelanggan);

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
