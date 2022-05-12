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
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            tableLayoutPanelSidebar.Hide();
            this.AcceptButton = buttonLogin;
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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login lgn = new Login();
            if (lgn.login(textBoxUsername.Text, textBoxPassword.Text))
            {
                FormBeranda form1 = new FormBeranda();
                form1.TopLevel = false;
                form1.AutoScroll = true;
                this.panelContent.Controls.Clear();
                this.panelContent.Controls.Add(form1);
                form1.Show();
                labelTitle.Text = "DASHBOARD";

                tableLayoutPanelSidebar.Show();
            }
            else
            {
                MessageBox.Show("Username atau Password salah");
            }
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
    }
}
