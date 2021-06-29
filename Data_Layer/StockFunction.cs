using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Data_Layer
{
    public class StockFunction
    {
        ConnectionDB db = new ConnectionDB();
        public string id_stock { get; set; }
        public string id_barang { get; set; }
        public string stock_min { get; set; }
        public string stock_on_hand { get; set; }

        //SELECT
        public DataTable Select()
        {
            SqlConnection con = new SqlConnection(db.GetConnection());
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM stock";
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
        public bool Insert(StockFunction sf)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(db.GetConnection());
            try
            {
                string sql = "INSERT INTO stock (ID_STOCK, ID_BARANG, STOCK_MIN, STOCK_ON_HAND) values (@id_stock, @id_barang, @stock_min, @stock_on_hand)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id_stock", sf.id_stock);
                cmd.Parameters.AddWithValue("@id_barang", sf.id_barang);
                cmd.Parameters.AddWithValue("@stock_min", sf.stock_min);
                cmd.Parameters.AddWithValue("@stock_on_hand", sf.stock_on_hand);

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

        //UPDATE STOCK BARANG
        public bool UpdateJumlahStok(StockFunction sf)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(db.GetConnection());
            try
            {
                string sql = "UPDATE stock SET STOCK_ON_HAND = @stock_on_hand WHERE ID_BARANG = @id_barang";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@stock_on_hand", sf.stock_on_hand);
                cmd.Parameters.AddWithValue("@id_barang", sf.id_barang);

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
        public bool Delete(StockFunction sf)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(db.GetConnection());
            try
            {
                string sql = "DELETE FROM stock WHERE ID_BARANG = @id_barang";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id_barang", sf.id_barang);

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
