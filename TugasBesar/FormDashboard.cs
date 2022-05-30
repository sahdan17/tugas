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
    public partial class FormDashboard : Form
    {
        Akun akun;
        Pegawai pegawai;
        protected String conString = ConfigurationManager.ConnectionStrings["inventaris"].ConnectionString;
        static MySqlConnection conn;
        static MySqlCommand cmd;
        public FormDashboard(Akun akun)
        {
            InitializeComponent();
            this.akun = akun;
            conn = new MySqlConnection(conString);
            cmd = new MySqlCommand();
        }

        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {
            FormLoginAkun formlogout = new FormLoginAkun();
            formlogout.Show();
            this.Hide();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            pegawai = new Pegawai();
            pegawai = Pegawai.Select(akun.id_pegawai);
            labelUser.Text = pegawai.nama_pegawai;
            if (pegawai.role == 1)
            {
                labelPosisi.Text = "Admin";
            }
            else if (pegawai.role == 2)
            {
                labelPosisi.Text = "Kasir";
                buttonDashboard.Visible = false;
                buttonInternal.Visible = false;
                buttonLaporan.Visible = false;
            }
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            FormBeranda form1 = new FormBeranda();
            form1.TopLevel = false;
            form1.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(form1);
            form1.Show();
            labelTitle.Text = "DASHBOARD";
        }

        private void buttonInternal_Click(object sender, EventArgs e)
        {
            FormInternal form2 = new FormInternal();
            form2.TopLevel = false;
            form2.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(form2);
            form2.Show();
            labelTitle.Text = "INTERNAL";
        }

        private void buttonTransaksi_Click(object sender, EventArgs e)
        {
            FormTransaksi form3 = new FormTransaksi();
            form3.TopLevel = false;
            form3.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(form3);
            form3.Show();
            labelTitle.Text = "TRANSAKSI";
        }

        private void buttonLaporan_Click(object sender, EventArgs e)
        {
            FormLaporan form4 = new FormLaporan();
            form4.TopLevel = false;
            form4.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(form4);
            form4.Show();
            labelTitle.Text = "LAPORAN";
        }

        private void pictureBoxProfil_Click(object sender, EventArgs e)
        {
            FormProfil formProfil = new FormProfil(akun);
            formProfil.TopLevel = false;
            formProfil.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(formProfil);
            formProfil.Show();
            labelTitle.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
