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
    public partial class FormDataPegawai : Form
    {
        public FormDataPegawai()
        {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            FormShowDataPegawai form3a = new FormShowDataPegawai();
            form3a.TopLevel = false;
            form3a.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(form3a);
            form3a.Show();
            labelTitle.Text = "Data Pegawai";
        }

        private void FormDataPegawai_Load(object sender, EventArgs e)
        {
            FormShowDataPegawai form3a = new FormShowDataPegawai();
            form3a.TopLevel = false;
            form3a.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(form3a);
            form3a.Show();
            labelTitle.Text = "Data Pegawai";
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            FormInputDataPegawai form3b = new FormInputDataPegawai();
            form3b.TopLevel = false;
            form3b.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(form3b);
            form3b.Show();
            labelTitle.Text = "Input Data Pegawai";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            FormDeleteDataPegawai form3d = new FormDeleteDataPegawai();
            form3d.TopLevel = false;
            form3d.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(form3d);
            form3d.Show();
            labelTitle.Text = "Delete Data Pegawai";
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            FormUpdateDataPegawai form3c = new FormUpdateDataPegawai();
            form3c.TopLevel = false;
            form3c.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(form3c);
            form3c.Show();
            labelTitle.Text = "Update Data Pegawai";
        }
    }
}
