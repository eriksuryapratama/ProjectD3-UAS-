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
    public class BarangFunction
    {
        ConnectionDB db = new ConnectionDB();
        public string namaBarang { get; set; }

        //SELECT
        public DataTable Select()
        {
            SqlConnection con = new SqlConnection(db.GetConnection());
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM m_barang";
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
        public bool Insert(BarangFunction bf)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(db.GetConnection());
            try
            {
                string sql = "INSERT INTO m_barang (KODE, PART_NO, DESCRIPTION, UNIT_PRICE, UNIT, STAMPING, DATA_FISIK, PERSAMAAN, PN1, MERK1, MERK2, MERK3, KETERANGAN) values (@kode, @part_no, @description, @unit_price, @unit, @stamping, @data_fisik, @persamaan, @pn1, @merk1, @merk2, @merk3, @keterangan)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@description", bf.namaBarang);

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
        public bool Update(BarangFunction bf)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(db.GetConnection());
            try
            {
                string sql = "UPDATE m_barang SET PART_NO = @part_no, DESCRIPTION = @description, UNIT_PRICE = @unit_price, UNIT = @unit, STAMPING = @stamping, DATA_FISIK = @data_fisik, PERSAMAAN = @persamaan, PN1 = @pn1, MERK1 = @merk1, MERK2 = @merk2, MERK3 = @merk3, KETERANGAN = @keterangan WHERE KODE = @kode";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@namakota", bf.namaBarang);

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
        public bool Delete(BarangFunction bf)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(db.GetConnection());
            try
            {
                string sql = "DELETE FROM m_barang WHERE DESCRIPTION = @description";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@description", bf.namaBarang);

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
