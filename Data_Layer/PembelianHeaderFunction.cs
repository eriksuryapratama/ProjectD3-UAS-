using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Data_Layer
{
    public class PembelianHeaderFunction
    {
        ConnectionDB db = new ConnectionDB();
        public string nomor_PNW { get; set; }
        public string nomor_NOTA { get; set; }
        public string pembeli_ID { get; set; }
        public string tanggal_PNW { get; set; }
        public string part_Charge { get; set; }
        public string keterangan { get; set; }
        public string faktur_Pajak { get; set; }
        public string Discount { get; set; }
        public string PPN { get; set; }

        //SELECT
        public DataTable Select()
        {
            SqlConnection con = new SqlConnection(db.GetConnection());
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM t_pembelian_header";
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
        public bool Insert(PembelianHeaderFunction pHf)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(db.GetConnection());
            try
            {
                string sql = "INSERT INTO t_pembelian_header (NO_PNW, NO_NOTA, P_ID, TGL_PNW, PART_CHARG, KETERANGAN, FAKTUR_PAJ, DISCOUNT, PPN) values (@no_pnw, @no_nota, @p_id, @tgl_pnw, @part_charg, @keterangan, @faktur_paj, @discount, @ppn)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@no_pnw", pHf.nomor_NOTA);
                cmd.Parameters.AddWithValue("@no_nota", pHf.nomor_NOTA);
                cmd.Parameters.AddWithValue("@p_id", pHf.pembeli_ID);
                cmd.Parameters.AddWithValue("@tgl_pnw", pHf.tanggal_PNW);
                cmd.Parameters.AddWithValue("@part_charg", pHf.part_Charge);
                cmd.Parameters.AddWithValue("@keterangan", pHf.keterangan);
                cmd.Parameters.AddWithValue("@faktur_paj", pHf.faktur_Pajak);
                cmd.Parameters.AddWithValue("@discount", pHf.Discount);
                cmd.Parameters.AddWithValue("@ppn", pHf.PPN);

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
        public bool Update(PembelianHeaderFunction pHf)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(db.GetConnection());
            try
            {
                string sql = "UPDATE t_pembelian_header SET NO_PNW = @no_pnw, NO_NOTA = @no_nota, P_ID = @p_id, TGL_PNW = @tgl_pnw, PART_CHARG = @part_charg, KETERANGAN = @keterangan, FAKTUR_PAJ = @faktur_paj, DISCOUNT = @discount, PPN = @ppn";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@no_pnw", pHf.nomor_NOTA);
                cmd.Parameters.AddWithValue("@no_nota", pHf.nomor_NOTA);
                cmd.Parameters.AddWithValue("@p_id", pHf.pembeli_ID);
                cmd.Parameters.AddWithValue("@tgl_pnw", pHf.tanggal_PNW);
                cmd.Parameters.AddWithValue("@part_charg", pHf.part_Charge);
                cmd.Parameters.AddWithValue("@keterangan", pHf.keterangan);
                cmd.Parameters.AddWithValue("@faktur_paj", pHf.faktur_Pajak);
                cmd.Parameters.AddWithValue("@discount", pHf.Discount);
                cmd.Parameters.AddWithValue("@ppn", pHf.PPN);

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
        public bool Delete(PembelianHeaderFunction pHf)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(db.GetConnection());
            try
            {
                string sql = "DELETE FROM t_pembelian_header WHERE NO_PNW = @no_pnw";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@no_pnw", pHf.nomor_PNW);

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
