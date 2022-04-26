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
    public partial class FormInputDataBarang : Form
    {
        public FormInputDataBarang()
        {
            InitializeComponent();
        }

        private void FormInputDataBarang_Load(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Barang dataBarang = new Barang();
            dataBarang.kode_barang = textBoxIDBarang.Text;
            dataBarang.nama_barang = textBoxNamaBarang.Text;
            dataBarang.harga_beli = Convert.ToInt32(textBoxHargaBeli.Text);
            dataBarang.harga_jual = Convert.ToInt32(textBoxHargaJual.Text);
            dataBarang.kuantitas_barang = Convert.ToInt32(textBoxKuantitasBarang.Text);
            dataBarang.satuan_barang = comboBoxSatuanBarang.SelectedItem.ToString();

            String response;
            response = dataBarang.Insert();
            if (response == null) MessageBox.Show("Input data sukses");
            else MessageBox.Show("Input data gagal " + response);
        }
    }
}
