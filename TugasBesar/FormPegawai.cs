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
    public partial class FormPegawai : Form
    {
        public FormPegawai()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            labelTambah.Visible = true;
            buttonTambahCancel.Visible = true;
            buttonTambahOK.Visible = true;

            NewLine();
            NewInput();

            buttonTambah.Enabled = false;
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            labelUpdate.Visible = true;
            buttonUpdateCancel.Visible = true;
            buttonUpdateOK.Visible = true;

            buttonTambah.Enabled = false;
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;

            NewInput();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            labelDelete.Visible = true;
            buttonDeleteCancel.Visible = true;
            buttonDeleteOK.Visible = true;

            buttonTambah.Enabled = false;
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
        }

        private void buttonTambahCancel_Click(object sender, EventArgs e)
        {
            labelTambah.Visible = false;
            buttonTambahCancel.Visible = false;
            buttonTambahOK.Visible = false;

            NewLine();
            OffInput();

            buttonTambah.Enabled = true;
        }

        private void buttonTambahOK_Click(object sender, EventArgs e)
        {
            Pegawai dataPegawai = new Pegawai();
            dataPegawai.nama_pegawai = textBoxNama.Text;
            dataPegawai.tempat_lahir = textBoxTmptLahir.Text;
            dataPegawai.tanggal_lahir = dateTimePickerTglLahir.Value.ToString("yyyyMMdd");
            dataPegawai.agama = comboBoxAgama.SelectedItem.ToString();
            dataPegawai.alamat = textBoxAlamat.Text;

            String response;
            response = dataPegawai.Insert();
            if (response == null) MessageBox.Show("Input data sukses");
            else MessageBox.Show("Input data gagal " + response);

            DataLoad();
        }

        private void buttonUpdateCancel_Click(object sender, EventArgs e)
        {
            labelUpdate.Visible = false;
            buttonUpdateCancel.Visible = false;
            buttonUpdateOK.Visible = false;

            OffInput();
            NewLine();

            buttonTambah.Enabled = true;
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
        }

        private void buttonUpdateOK_Click(object sender, EventArgs e)
        {
            string response;
            Pegawai editPegawai = new Pegawai();
            editPegawai.nama_pegawai = textBoxNama.Text;
            editPegawai.tempat_lahir = textBoxTmptLahir.Text;
            editPegawai.tanggal_lahir = dateTimePickerTglLahir.Value.ToString("yyyyMMdd");
            editPegawai.agama = comboBoxAgama.SelectedItem.ToString();
            editPegawai.alamat = textBoxAlamat.Text;
            editPegawai._nama_pegawai = comboBoxSearch.Text;
            response = editPegawai.Update();
            if (response == null) MessageBox.Show("Update data sukses");
            else MessageBox.Show(response);

            DataLoad();
        }

        private void buttonDeleteCancel_Click(object sender, EventArgs e)
        {
            labelDelete.Visible = false;
            buttonDeleteCancel.Visible = false;
            buttonDeleteOK.Visible = false;

            buttonTambah.Enabled = true;
            buttonUpdate.Enabled = true;
            buttonDelete.Enabled = true;
        }

        private void buttonDeleteOK_Click(object sender, EventArgs e)
        {
            string response;
            Pegawai deletePegawai = new Pegawai();
            deletePegawai._nama_pegawai = comboBoxSearch.Text;
            response = deletePegawai.Delete();
            if (response == null) MessageBox.Show("Hapus data sukses");
            else MessageBox.Show(response);

            DataLoad();
        }

        public void Combobox()
        {
            MySqlConnection conn = Connection.conString();
            MySqlCommand cmd = new MySqlCommand("SELECT nama_pegawai, id_pegawai FROM data_pegawai", conn);
            MySqlDataReader rdr;
            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string nama = rdr.GetString(0);
                    string id = rdr.GetInt32(1).ToString();
                    comboBoxSearch.Items.Add(nama);
                    comboBoxID.Items.Add(id);
                }
            }
            catch
            {

            }
        }

        private void FormPegawai_Load(object sender, EventArgs e)
        {
            Combobox();
        }

        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = Connection.conString();
            MySqlCommand cmd = new MySqlCommand("SELECT id_pegawai " +
                "FROM data_pegawai WHERE nama_pegawai = '" + comboBoxSearch.Text + "';", conn);
            MySqlDataReader rdr;
            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string id = rdr.GetInt32(0).ToString();
                    comboBoxID.Text = id;
                }
            }
            catch
            {

            }
            buttonUpdate.Enabled = true;
            buttonDelete.Enabled = true;
        }

        private void NewLine()
        {
            comboBoxSearch.Text = null;
            textBoxNama.Text = null;
            textBoxTmptLahir.Text = null;
            dateTimePickerTglLahir.Text = null;
            comboBoxAgama.Text = "Islam";
            textBoxAlamat.Text = null;
        }

        private void NewInput()
        {
            textBoxNama.ReadOnly = false;
            textBoxTmptLahir.ReadOnly = false;
            dateTimePickerTglLahir.Enabled = true;
            comboBoxAgama.Enabled = true;
            textBoxAlamat.ReadOnly = false;
        }

        private void OffInput()
        {
            textBoxNama.ReadOnly = true;
            textBoxTmptLahir.ReadOnly = true;
            dateTimePickerTglLahir.Enabled = false;
            comboBoxAgama.Enabled = false;
            textBoxAlamat.ReadOnly = true;
        }

        private void DataLoad()
        {
            FormPegawai form2b = new FormPegawai();
            form2b.TopLevel = false;
            form2b.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(form2b);
            form2b.Show();
        }

        private void comboBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = Connection.conString();
            MySqlCommand cmd = new MySqlCommand("SELECT nama_pegawai, tempat_lahir, tanggal_lahir, agama, alamat " +
                "FROM data_pegawai WHERE id_pegawai = '" + comboBoxID.Text + "';", conn);
            MySqlDataReader rdr;
            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string nama = rdr.GetString(0);
                    string tempat = rdr.GetString(1);
                    DateTime tanggal = rdr.GetDateTime(2);
                    string agama = rdr.GetString(3);
                    string alamat = rdr.GetString(4);
                    textBoxNama.Text = nama;
                    textBoxTmptLahir.Text = tempat;
                    dateTimePickerTglLahir.Value = tanggal;
                    comboBoxAgama.Text = agama;
                    textBoxAlamat.Text = alamat;
                }
            }
            catch
            {

            }
            buttonUpdate.Enabled = true;
            buttonDelete.Enabled = true;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxAlamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTmptLahir_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxAgama_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelTambah_Click(object sender, EventArgs e)
        {

        }

        private void labelUpdate_Click(object sender, EventArgs e)
        {

        }

        private void labelDelete_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerTglLahir_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNama_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
