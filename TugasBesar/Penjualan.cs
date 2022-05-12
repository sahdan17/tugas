using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasBesar
{
    class Penjualan : Connection
    {
        public int id_jual { set; get; }
        public String tgl_jual { set; get; }
        public int total { set; get; }
        public String kode_barang { set; get; }
        public String nama_barang { set; get; }
        public int harga_jual { set; get; }

        MySqlConnection conn = Connection.conString();
        MySqlCommand cmd;

        public Penjualan()
        {
            MySqlConnection conn = Connection.conString();
            cmd = new MySqlCommand();
        }

        public String Insert()
        {
            String error = null;
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO penjualan (id_jual, tgl_jual, total) VALUES (@id_jual, @tgl_jual, @total)";
            cmd.Parameters.AddWithValue("@id_jual", this.id_jual);
            cmd.Parameters.AddWithValue("@tgl_jual", this.tgl_jual);
            cmd.Parameters.AddWithValue("@total", this.total);

            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                error = e.Message;
            }
            return error;
        }

        public String ComboBox()
        {
            String error = null;
            //cmd = conn.CreateCommand();
            //cmd.CommandText = "SELECT kode_barang, nama_barang, harga_jual FROM data_barang";
            /*MySqlDataReader rdr;
            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string name = rdr.GetString(1);
                    string name1 = rdr.GetString(2);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }*/
            return error;
        }
    }
}
