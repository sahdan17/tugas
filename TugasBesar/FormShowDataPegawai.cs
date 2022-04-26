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
    public partial class FormShowDataPegawai : Form
    {
        public FormShowDataPegawai()
        {
            InitializeComponent();
        }

        private void FormShowDataPegawai_Load(object sender, EventArgs e)
        {
            Pegawai tabelPegawai = new Pegawai();
            DataTable dt = new DataTable();
            dt = tabelPegawai.Read();
            dataGridViewPegawai.DataSource = dt;
            dataGridViewPegawai.Show();
        }
    }
}
