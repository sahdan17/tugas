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
    public partial class FormTransaksi : Form
    {
        public FormTransaksi()
        {
            InitializeComponent();
        }

        private void buttonPenjualan_Click(object sender, EventArgs e)
        {
            FormPenjualan form31 = new FormPenjualan();
            form31.TopLevel = false;
            form31.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(form31);
            form31.Show();
            labelTitle.Text = "Penjualan";
        }
    }
}