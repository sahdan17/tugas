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
    public partial class FormUpdateDataBarang : Form
    {
        int _id_barang;
        public FormUpdateDataBarang()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string response;
            Barang dataBarang = new Barang();
            dataBarang.kode_barang = textBoxIDBarang.Text;
            dataBarang.nama_barang = textBoxNamaBarang.Text;
            dataBarang.harga_beli = Convert.ToInt32(textBoxHargaBeli.Text);
            dataBarang.harga_jual = Convert.ToInt32(textBoxHargaJual.Text);
            dataBarang.kuantitas_barang = Convert.ToInt32(textBoxKuantitasBarang.Text);
            dataBarang.satuan_barang = comboBoxSatuanBarang.SelectedItem.ToString();
            dataBarang.id_barang = _id_barang;

            response = dataBarang.Update();
            if (response == null) MessageBox.Show("Update data sukses");
            else MessageBox.Show(response);

            ReadData();

            textBoxIDBarang.Text = null;
            textBoxNamaBarang.Text = null;
            textBoxHargaBeli.Text = null;
            textBoxHargaJual.Text = null;
            textBoxKuantitasBarang.Text = null;
        }

        private void ReadData()
        {
            Barang tabelBarang = new Barang();
            DataTable dt = new DataTable();
            dt = tabelBarang.Read();
            dataGridViewUpdate.DataSource = dt;
            dataGridViewUpdate.Show();
        }

        private void FormUpdateDataBarang_Load(object sender, EventArgs e)
        {
            ReadData();
        }

        private void dataGridViewUpdate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridViewUpdate.SelectedCells[0].RowIndex;
            DataGridViewRow selected = dataGridViewUpdate.Rows[index];

            textBoxIDBarang.Text = Convert.ToString(selected.Cells["kode_barang"].Value);
            textBoxNamaBarang.Text = Convert.ToString(selected.Cells["nama_barang"].Value);
            textBoxHargaBeli.Text = Convert.ToString(selected.Cells["harga_beli"].Value);
            textBoxHargaJual.Text = Convert.ToString(selected.Cells["harga_jual"].Value);            
            textBoxKuantitasBarang.Text = Convert.ToString(selected.Cells["kuantitas_barang"].Value);
            comboBoxSatuanBarang.Text = Convert.ToString(selected.Cells["satuan_barang"].Value);
            _id_barang = Convert.ToInt32(selected.Cells["id_barang"].Value);
        }
    }
}
