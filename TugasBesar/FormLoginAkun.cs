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
        String conString = ConfigurationManager.ConnectionStrings["inventaris"].ConnectionString;
        public FormLoginAkun()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            /*MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand("SELECT username, password FROM user WHERE username = '"+textBoxUsername.Text+"'", conn);
            MySqlDataReader rdr;
            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string user = rdr.GetString(0);
                    string pw = rdr.GetString(1);
                    if(textBoxUsername.Text == user && textBoxPassword.Text == pw)
                    {
                        FormDashboard form1 = new FormDashboard();
                        form1.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Username atau password salah");
                    }
                }
            }
            catch
            {
                
            }*/
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand("SELECT username, password, role FROM akun " +
                "WHERE username = '" + textBoxUsername.Text + "'", conn);
            MySqlDataReader rdr;
            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string user = rdr.GetString(0);
                    string pw = rdr.GetString(1);
                    string role = rdr.GetString(2);
                    if (textBoxUsername.Text == user && textBoxPassword.Text == pw)
                    {
                        if(role == "1")
                        {
                            FormDashboard form1 = new FormDashboard();
                            form1.Show();
                            this.Hide();
                        }
                        else if(role == "2")
                        {
                            FormDashboardKasir form1 = new FormDashboardKasir();
                            form1.Show();
                            this.Hide();                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username atau password salah");
                    }
                }
            }
            catch
            {

            }
        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
