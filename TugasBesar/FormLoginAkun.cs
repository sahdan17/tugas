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
    public partial class FormLoginAkun : Form
    {
        protected String conString = ConfigurationManager.ConnectionStrings["inventaris"].ConnectionString;
        public FormLoginAkun()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string response;
            Akun akun = new Akun();
            akun.username = textBoxUsername.Text;
            response = akun.Login();
            if (textBoxUsername.Text == akun.username && textBoxPassword.Text == akun.password)
            {
                FormDashboard form1 = new FormDashboard(akun);
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau password salah");
                textBoxUsername.Text = null;
                textBoxPassword.Text = null;
            }
        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
