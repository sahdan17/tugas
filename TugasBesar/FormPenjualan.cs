using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasBesar
{
    public partial class FormPenjualan : Form
    {
        public FormPenjualan()
        {
            InitializeComponent();
        }

        private void FormPenjualan_Load(object sender, EventArgs e)
        {
            Combobox();
        }

        public void Combobox()
        {
            Penjualan jual = new Penjualan();
            MySqlConnection conn = Connection.conString();
            MySqlCommand cmd = new MySqlCommand("SELECT kode_barang, nama_barang, harga_jual FROM data_barang", conn);
            MySqlDataReader rdr;
            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string name = rdr.GetString(1);
                    string name1 = rdr.GetString(0);
                    comboBoxBarang.Items.Add(name1 + " - " + name);
                }
            }
            catch
            {

            }
        }
    }
}
