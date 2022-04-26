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
    public partial class FormDataBarang : Form
    {
        public FormDataBarang()
        {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            FormShowDataBarang form2a = new FormShowDataBarang();
            form2a.TopLevel = false;
            form2a.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(form2a);
            form2a.Show();
            labelTitle.Text = "Data Produk";
        }

        private void FormDataBarang_Load(object sender, EventArgs e)
        {
            FormShowDataBarang form2a = new FormShowDataBarang();
            form2a.TopLevel = false;
            form2a.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(form2a);
            form2a.Show();
            labelTitle.Text = "Data Produk";
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            FormInputDataBarang form2b = new FormInputDataBarang();
            form2b.TopLevel = false;
            form2b.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(form2b);
            form2b.Show();
            labelTitle.Text = "Input Data Produk";
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            FormUpdateDataBarang form2c = new FormUpdateDataBarang();
            form2c.TopLevel = false;
            form2c.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(form2c);
            form2c.Show();
            labelTitle.Text = "Update Data Produk";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            FormDeleteDataBarang form2d = new FormDeleteDataBarang();
            form2d.TopLevel = false;
            form2d.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(form2d);
            form2d.Show();
            labelTitle.Text = "Delete Data Produk";
        }
    }
}
