﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasBesar
{
    class Barang : Connection
    {
        public int id_barang { set; get; }
        public String kode_barang { set; get; }
        public String nama_barang { set; get; }
        public int harga_beli { set; get; }
        public int harga_jual { get; set; }
        public int kuantitas_barang { get; set; }
        public String satuan_barang { set; get; }

        MySqlConnection conn = Connection.conString();
        MySqlCommand cmd;

        public Barang()
        {
            MySqlConnection conn = Connection.conString();
            cmd = new MySqlCommand();
        }

        public String Insert()
        {
            String error = null;
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO data_barang (id_barang, kode_barang, nama_barang, harga_beli, " +
                "harga_jual, kuantitas_barang, satuan_barang) VALUES (@id_barang, @kode_barang, @nama_barang, @harga_beli, " +
                "@harga_jual, @kuantitas_barang, @satuan_barang)";
            cmd.Parameters.AddWithValue("@id_barang", this.id_barang);
            cmd.Parameters.AddWithValue("@kode_barang", this.kode_barang);
            cmd.Parameters.AddWithValue("@nama_barang", this.nama_barang);
            cmd.Parameters.AddWithValue("@harga_beli", this.harga_beli);
            cmd.Parameters.AddWithValue("@harga_jual", this.harga_jual);
            cmd.Parameters.AddWithValue("@kuantitas_barang", this.kuantitas_barang);
            cmd.Parameters.AddWithValue("@satuan_barang", this.satuan_barang);

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

        public DataTable Read()
        {
            DataTable dt = new DataTable();
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM data_barang";
            {
                try
                {
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    dt.Load(rdr);
                }
                catch (Exception e) { }
            }
            return dt;
        }

        public String Delete()
        {
            String result = null;
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand("DELETE FROM data_barang WHERE id_barang = @id_barang", conn))
            {
                cmd.Parameters.AddWithValue("@id_barang", this.id_barang);
                try
                {
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception e)
                {
                    return e.Message;
                }
            }
            return result;
        }

        public String Update()
        {
            string result = null;
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE data_barang set id_barang = @id_barang, kode_barang = @kode_barang, nama_barang = @nama_barang, " +
                "harga_beli = @harga_beli, harga_jual = @harga_jual, kuantitas_barang = @kuantitas_barang," +
                " satuan_barang = @satuan_barang WHERE id_barang = @id_barang";
            cmd.Parameters.AddWithValue("@id_barang", this.id_barang);
            cmd.Parameters.AddWithValue("@kode_barang", this.kode_barang);
            cmd.Parameters.AddWithValue("@nama_barang", this.nama_barang);
            cmd.Parameters.AddWithValue("@harga_beli", this.harga_beli);
            cmd.Parameters.AddWithValue("@harga_jual", this.harga_jual);
            cmd.Parameters.AddWithValue("@kuantitas_barang", this.kuantitas_barang);
            cmd.Parameters.AddWithValue("@satuan_barang", this.satuan_barang);

            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return result;
        }
    }
}