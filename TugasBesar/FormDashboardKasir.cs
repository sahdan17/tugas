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
    public partial class FormDashboardKasir : Form
    {
        public FormDashboardKasir()
        {
            InitializeComponent();
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

        private void pictureBoxProfil_Click(object sender, EventArgs e)
        {
            FormProfil formProfil = new FormProfil();
            formProfil.TopLevel = false;
            formProfil.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(formProfil);
            formProfil.Show();
            labelTitle.Text = "";
        }

        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {
            FormLoginAkun formlogout = new FormLoginAkun();
            formlogout.Show();
            this.Hide();
        }

        private void FormDashboardKasir_Load(object sender, EventArgs e)
        {
            FormTransaksi formProfil = new FormTransaksi();
            formProfil.TopLevel = false;
            formProfil.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(formProfil);
            formProfil.Show();
        }
    }
}
