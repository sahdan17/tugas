﻿using System;
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
    public partial class FormLoginAkun : Form
    {
        public FormLoginAkun()
        {
            InitializeComponent();
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
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password salah");
            }
        }
    }
}