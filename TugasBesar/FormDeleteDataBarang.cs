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
    public partial class FormDeleteDataBarang : Form
    {
        int _id_barang;
        public FormDeleteDataBarang()
        {
            InitializeComponent();
        }

        private void FormDeleteDataBarang_Load(object sender, EventArgs e)
        {
            ReadData();
        }

        private void ReadData()
        {
            Barang tabelBarang = new Barang();
            DataTable dt = new DataTable();
            dt = tabelBarang.Read();
            dataGridViewBarang.DataSource = dt;
            dataGridViewBarang.Show();
        }

        private void dataGridViewBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridViewBarang.SelectedCells[0].RowIndex;
            DataGridViewRow selected = dataGridViewBarang.Rows[index];
            _id_barang = Convert.ToInt32(selected.Cells["id_barang"].Value);
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string response;
            Barang deleteBarang = new Barang();
            deleteBarang.id_barang = _id_barang;
            response = deleteBarang.Delete();
            if (response == null) MessageBox.Show("Hapus data sukses");
            else MessageBox.Show(response);
            ReadData();
        }
    }
}
