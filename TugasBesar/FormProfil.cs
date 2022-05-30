using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasBesar
{
    public partial class FormProfil : Form
    {
        Akun akun;
        Pegawai pegawai;
        protected String conString = ConfigurationManager.ConnectionStrings["inventaris"].ConnectionString;
        static MySqlConnection conn;
        static MySqlCommand cmd;

        String pw, pwBaru;
        int role;
        public FormProfil(Akun akun)
        {
            InitializeComponent();
            this.akun = akun;
            conn = new MySqlConnection(conString);
            cmd = new MySqlCommand();
        }

        private void FormProfil_Load(object sender, EventArgs e)
        {
            pegawai = new Pegawai();
            pegawai = Pegawai.Select(akun.id_pegawai);
            textBoxNama.Text = pegawai.nama_pegawai;
            textBoxUsername.Text = pegawai.username;
            textBoxPassword.Text = pegawai.password;
            if (pegawai.role == 2)
            {
                labelBuat.Visible = false;
            }
            ComboBox();
        }

        private void labelUbah_Click(object sender, EventArgs e)
        {
            labelUbahUser.Visible = false;
            textBoxPasswordLama.Visible = true;
            buttonOKLama.Visible = true;
            buttonCancel.Visible = true;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxPasswordBaru.Text == textBoxPasswordKonfirmasi.Text)
            {
                string response = null;
                Akun editPw = new Akun();
                editPw.username = textBoxUsername.Text;
                editPw.password = textBoxPasswordBaru.Text;
                response = editPw.Update();
                if (response == null) 
                {
                    MessageBox.Show("Update data sukses");
                    LoadData();
                } 
                else MessageBox.Show(response);
            }
        }

        private void buttonOKLama_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == textBoxPasswordLama.Text)
            {
                textBoxPasswordBaru.Visible = true;
                textBoxPasswordKonfirmasi.Visible = true;
                buttonCancel.Visible = true;
                buttonOK.Visible = true;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void labelBuat_Click(object sender, EventArgs e)
        {
            textBoxUsernameBaru.Visible = true;
            comboBoxRole.Visible = true;
            textBoxPWBaru.Visible = true;
            textBoxPWKonfirmasi.Visible = true;
            comboBoxNama.Visible = true;
            buttonOKBuat.Visible = true;
            buttonCancelBuat.Visible = true;
        }

        private void buttonOKBuat_Click(object sender, EventArgs e)
        {
            string response;
            pw = textBoxPWBaru.Text;
            pwBaru = textBoxPWKonfirmasi.Text;
            if (pw == pwBaru) pw = textBoxPWKonfirmasi.Text;
            else pw = null;
            if (comboBoxRole.Text == "Admin") role = 1;
            else if (comboBoxRole.Text == "Kasir") role = 2;
            Akun akun = new Akun();
            akun.username = textBoxUsernameBaru.Text;
            akun.password = pw;
            akun.role = role;
            akun.id_pegawai = Convert.ToInt32(comboBoxID.Text);
            response = akun.Insert();
            if (response == null)
            {
                MessageBox.Show("Insert data sukses");
                LoadData();
            }
            else MessageBox.Show(response);
        }

        private void ComboBox()
        {
            conn = new MySqlConnection(conString);
            cmd = new MySqlCommand("SELECT nama_pegawai, id_pegawai FROM data_pegawai", conn);
            MySqlDataReader rdr;
            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string nama = rdr.GetString(0);
                    comboBoxNama.Items.Add(nama);
                }
            }
            catch
            {

            }
        }

        private void buttonCancelBuat_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void labelKelola_Click(object sender, EventArgs e)
        {
            labelUbah.Visible = true;
            labelUbahUser.Visible = true;
        }

        private void labelUbahUser_Click(object sender, EventArgs e)
        {
            labelUbah.Visible = false;
            textBoxUbahUsername.Visible = true;
            buttonOKUsername.Visible = true;
            buttonCancelUsername.Visible = true;
        }

        private void buttonOKUsername_Click(object sender, EventArgs e)
        {
            string response;
            Akun akun = new Akun();
            akun.username = textBoxUsername.Text;
            akun.usernamebaru = textBoxUbahUsername.Text;
            response = akun.UbahUsername();
            if (response == null) MessageBox.Show("Update username berhasil");
            else MessageBox.Show(response);
            LoadData();
        }

        private void comboBoxNama_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new MySqlConnection(conString);
            cmd = new MySqlCommand("SELECT nama_pegawai, id_pegawai FROM data_pegawai WHERE nama_pegawai = '"+comboBoxNama.Text+"'", conn);
            MySqlDataReader rdr;
            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string id = rdr.GetInt32(1).ToString();
                    comboBoxID.Text = id;
                }
            }
            catch
            {

            }
        }

        private void buttonCancelUsername_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            FormProfil formProfil = new FormProfil(akun);
            formProfil.TopLevel = false;
            formProfil.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(formProfil);
            formProfil.Show();
        }
    }
}
