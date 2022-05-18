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
    public partial class FormShowDataBarang : Form
    {
        public FormShowDataBarang()
        {
            InitializeComponent();
        }

        private void FormShowDataBarang_Load(object sender, EventArgs e)
        {
            Barang tabelBarang = new Barang();
            DataTable dt = new DataTable();
            dt = tabelBarang.Read();
            dataGridViewBarang.DataSource = dt;
            dataGridViewBarang.Show();
        }

        private void dataGridViewBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
