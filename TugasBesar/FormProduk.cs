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
    public partial class FormProduk : Form
    {
        int qty_awal;
        int qty_beli;
        int qty_akhir;

        public FormProduk()
        {
            InitializeComponent();
        }

        private void buttonTambahStok_Click(object sender, EventArgs e)
        {
            labelTambahStok.Visible = true;
            buttonStokCancel.Visible = true;
            buttonStokOK.Visible = true;
            textBoxKuantitas.ReadOnly = false;
            textBoxKuantitas.Text = null;
            buttonDelete.Enabled = false;
            buttonUpdate.Enabled = false;
            buttonTambahStok.Enabled = false;
            buttonTambahData.Enabled = false;
            labelKuantitas.Text = "Kuantitas Tambah";
        }

        private void buttonTambahData_Click(object sender, EventArgs e)
        {
            labelTambah.Visible = true;
            buttonTambahOK.Visible = true;
            buttonTambahCancel.Visible = true;
            buttonTambahData.Enabled = false;
            NewInput();
            NewLine();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            labelUpdate.Visible = true;
            buttonUpdateCancel.Visible = true;
            buttonUpdateOK.Visible = true;
            NewInput();
            buttonTambahData.Enabled = false;
            buttonTambahStok.Enabled = false;
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            labelDelete.Visible = true;
            buttonDeleteCancel.Visible = true;
            buttonDeleteOK.Visible = true;
            buttonTambahData.Enabled = false;
            buttonTambahStok.Enabled = false;
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
        }

        private void buttonStokOK_Click(object sender, EventArgs e)
        {
            Tambah();
            Barang dataBarang = new Barang();
            dataBarang.kuantitas_barang = qty_akhir;
            dataBarang.tambah = comboBoxID.Text;

            String response;
            response = dataBarang.Tambah();
            if (response == null) MessageBox.Show("Input data sukses");
            else MessageBox.Show("Input data gagal " + response);

            NewLine();
            OffInput();
            DataLoad();
            ReadData();
            buttonDelete.Enabled = false;
            buttonUpdate.Enabled = false;
            buttonTambahStok.Enabled = false;
            buttonTambahData.Enabled = true;
            buttonTambahData.Enabled = true;
            labelKuantitas.Text = "Kuantitas Barang";
            labelTambahStok.Visible = false;
            buttonStokCancel.Visible = false;
            buttonStokOK.Visible = false;
        }

        private void buttonStokCancel_Click(object sender, EventArgs e)
        {
            NewLine();
            OffInput();
            buttonDelete.Enabled = false;
            buttonUpdate.Enabled = false;
            buttonTambahStok.Enabled = false;
            buttonTambahData.Enabled = true;
            labelKuantitas.Text = "Kuantitas Barang";
            labelTambahStok.Visible = false;
            buttonStokCancel.Visible = false;
            buttonStokOK.Visible = false;
        }

        private void buttonTambahOK_Click(object sender, EventArgs e)
        {
            Barang dataBarang = new Barang();
            dataBarang.kode_barang = textBoxKode.Text;
            dataBarang.nama_barang = textBoxNama.Text;
            dataBarang.harga_beli = Convert.ToInt32(textBoxHargaBeli.Text);
            dataBarang.harga_jual = Convert.ToInt32(textBoxHargaJual.Text);
            dataBarang.kuantitas_barang = Convert.ToInt32(textBoxKuantitas.Text);
            dataBarang.satuan_barang = comboBoxSatuan.Text;

            String response;
            response = dataBarang.Insert();
            if (response == null) MessageBox.Show("Input data sukses");
            else MessageBox.Show("Input data gagal " + response);

            DataLoad();
            ReadData();
            OffInput();
            NewLine();
            labelTambah.Visible = false;
            buttonTambahOK.Visible = false;
            buttonTambahCancel.Visible = false;
            buttonTambahData.Enabled = true;
        }

        private void buttonTambahCancel_Click(object sender, EventArgs e)
        {
            NewLine();
            OffInput();
            labelTambah.Visible = false;
            buttonTambahOK.Visible = false;
            buttonTambahCancel.Visible = false;
            buttonTambahData.Enabled = true;
        }

        private void buttonUpdateOK_Click(object sender, EventArgs e)
        {
            Barang dataBarang = new Barang();
            dataBarang.kode_barang = textBoxKode.Text;
            dataBarang.nama_barang = textBoxNama.Text;
            dataBarang.harga_beli = Convert.ToInt32(textBoxHargaBeli.Text);
            dataBarang.harga_jual = Convert.ToInt32(textBoxHargaJual.Text);
            dataBarang.kuantitas_barang = Convert.ToInt32(textBoxKuantitas.Text);
            dataBarang.satuan_barang = comboBoxSatuan.Text;
            dataBarang.tambah = comboBoxID.Text;

            String response;
            response = dataBarang.Update();
            if (response == null) MessageBox.Show("Input data sukses");
            else MessageBox.Show("Input data gagal " + response);

            DataLoad();
            ReadData();
            NewLine();
            OffInput();
            labelUpdate.Visible = false;
            buttonUpdateOK.Visible = false;
            buttonUpdateCancel.Visible = false;
            buttonTambahData.Enabled = true;
            buttonTambahStok.Enabled = false;
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
        }

        private void buttonUpdateCancel_Click(object sender, EventArgs e)
        {
            NewLine();
            OffInput();
            labelUpdate.Visible = false;
            buttonUpdateOK.Visible = false;
            buttonUpdateCancel.Visible = false;
            buttonTambahData.Enabled = true;
            buttonTambahStok.Enabled = false;
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
        }

        private void buttonDeleteOK_Click(object sender, EventArgs e)
        {
            Barang dataBarang = new Barang();
            dataBarang.tambah = comboBoxID.Text;

            String response;
            response = dataBarang.Delete();
            if (response == null) MessageBox.Show("Input data sukses");
            else MessageBox.Show("Input data gagal " + response);

            DataLoad();
            ReadData();
            NewLine();
            OffInput();
            labelDelete.Visible = false;
            buttonDeleteOK.Visible = false;
            buttonDeleteCancel.Visible = false;
            buttonTambahData.Enabled = true;
            buttonTambahStok.Enabled = false;
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
        }

        private void buttonDeleteCancel_Click(object sender, EventArgs e)
        {
            NewLine();
            OffInput();
            labelDelete.Visible = false;
            buttonDeleteOK.Visible = false;
            buttonDeleteCancel.Visible = false;
            buttonTambahData.Enabled = true;
            buttonTambahStok.Enabled = false;
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
        }

        public void Combobox()
        {
            MySqlConnection conn = Connection.conString();
            MySqlCommand cmd = new MySqlCommand("SELECT nama_barang, kode_barang, id_barang FROM data_barang", conn);
            MySqlDataReader rdr;
            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string nama = rdr.GetString(0);
                    string kode = rdr.GetString(1);
                    string id = rdr.GetInt32(2).ToString();
                    comboBoxSearch.Items.Add(nama);
                    comboBoxKode.Items.Add(kode);
                    comboBoxID.Items.Add(id);
                }
            }
            catch
            {

            }
        }

        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = Connection.conString();
            MySqlCommand cmd = new MySqlCommand("SELECT id_barang, kode_barang " +
                "FROM data_barang WHERE nama_barang = '" + comboBoxSearch.Text + "';", conn);
            MySqlDataReader rdr;
            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string id = rdr.GetInt32(0).ToString();
                    string kode = rdr.GetString(1);
                    comboBoxID.Text = id;
                    comboBoxKode.Text = kode;
                }
            }
            catch
            {

            }
        }

        private void comboBoxKode_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = Connection.conString();
            MySqlCommand cmd = new MySqlCommand("SELECT nama_barang, id_barang " +
                "FROM data_barang WHERE kode_barang = '" + comboBoxKode.Text + "';", conn);
            MySqlDataReader rdr;
            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string id = rdr.GetInt32(1).ToString();
                    string nama = rdr.GetString(0);
                    comboBoxID.Text = id;
                    comboBoxSearch.Text = nama;
                }
            }
            catch
            {

            }
        }

        private void comboBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = Connection.conString();
            MySqlCommand cmd = new MySqlCommand("SELECT kode_barang, nama_barang, harga_beli, harga_jual, kuantitas_barang, satuan_barang " +
                "FROM data_barang WHERE id_barang = '" + comboBoxID.Text + "';", conn);
            MySqlDataReader rdr;
            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string kode = rdr.GetString(0);
                    string nama = rdr.GetString(1);
                    string beli = rdr.GetInt32(2).ToString();
                    string jual = rdr.GetInt32(3).ToString();
                    string qty = rdr.GetInt32(4).ToString();
                    string satuan = rdr.GetString(5);
                    textBoxKode.Text = kode;
                    textBoxNama.Text = nama;
                    textBoxHargaBeli.Text = beli;
                    textBoxHargaJual.Text = jual;
                    textBoxKuantitas.Text = qty;
                    comboBoxSatuan.Text = satuan;
                }
            }
            catch
            {

            }
            buttonDelete.Enabled = true;
            buttonUpdate.Enabled = true;
            buttonTambahStok.Enabled = true;
        }

        private void FormProduk_Load(object sender, EventArgs e)
        {
            Combobox();
            ReadData();
        }

        private void NewInput()
        {
            textBoxKode.ReadOnly = false;
            textBoxNama.ReadOnly = false;
            textBoxHargaBeli.ReadOnly = false;
            textBoxHargaJual.ReadOnly = false;
            textBoxKuantitas.ReadOnly = false;
            comboBoxSatuan.Enabled = true;
        }

        private void OffInput()
        {
            textBoxKode.ReadOnly = true;
            textBoxNama.ReadOnly = true;
            textBoxHargaBeli.ReadOnly = true;
            textBoxHargaJual.ReadOnly = true;
            textBoxKuantitas.ReadOnly = true;
            comboBoxSatuan.Enabled = false;
        }

        private void NewLine()
        {
            textBoxKode.Text = null;
            textBoxNama.Text = null;
            textBoxHargaBeli.Text = null;
            textBoxHargaJual.Text = null;
            textBoxKuantitas.Text = null;
            comboBoxSatuan.Text = null;
            comboBoxID.Text = null;
            comboBoxKode.Text = null;
            comboBoxSearch.Text = null;
        }

        private void Tambah()
        {
            MySqlConnection conn = Connection.conString();
            MySqlCommand cmd = new MySqlCommand("SELECT kuantitas_barang FROM data_barang WHERE id_barang = '" + comboBoxID.Text + "';", conn);
            MySqlDataReader rdr;
            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string qty = rdr.GetInt32(0).ToString();
                    qty_awal = Convert.ToInt32(qty);
                }
            }
            catch
            {

            }

            qty_beli = Convert.ToInt32(textBoxKuantitas.Text);
            qty_akhir = qty_awal + qty_beli;
        }

        private void DataLoad()
        {
            FormProduk form2b = new FormProduk();
            form2b.TopLevel = false;
            form2b.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(form2b);
            form2b.Show();
        }

        private void ReadData()
        {
            Barang tabelStruk = new Barang();
            DataTable dt = new DataTable();
            dt = tabelStruk.Read();
            dataGridViewDaftar.DataSource = dt;
            dataGridViewDaftar.Show();
        }
    }
}
