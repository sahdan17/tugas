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
    public partial class FormUpdateDataPegawai : Form
    {
        int _id_pegawai;
        public FormUpdateDataPegawai()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string response;
            Pegawai editPegawai = new Pegawai();
            editPegawai.nama_pegawai = textBoxNama.Text;
            editPegawai.tempat_lahir = textBoxTmptLahir.Text;
            editPegawai.tanggal_lahir = dateTimePickerTglLahir.Value.ToString("yyyyMMdd");
            editPegawai.agama = comboBoxAgama.SelectedItem.ToString();
            editPegawai.alamat = textBoxAlamat.Text;
            editPegawai.id_pegawai = _id_pegawai;
            response = editPegawai.Update();
            if (response == null) MessageBox.Show("Update data sukses");
            else MessageBox.Show(response);

            ReadData();

            textBoxNama.Text = null;
            textBoxTmptLahir.Text = null;
            textBoxAlamat.Text = null;
        }

        private void dataGridViewUpdate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridViewUpdate.SelectedCells[0].RowIndex;
            DataGridViewRow selected = dataGridViewUpdate.Rows[index];

            textBoxNama.Text = Convert.ToString(selected.Cells["nama_pegawai"].Value);
            textBoxTmptLahir.Text = Convert.ToString(selected.Cells["tempat_lahir"].Value);
            dateTimePickerTglLahir.Value = Convert.ToDateTime(selected.Cells["tanggal_lahir"].Value);
            comboBoxAgama.Text = Convert.ToString(selected.Cells["agama"].Value);
            textBoxAlamat.Text = Convert.ToString(selected.Cells["alamat"].Value);
            _id_pegawai = Convert.ToInt32(selected.Cells["id_pegawai"].Value);
        }

        private void ReadData()
        {
            Pegawai tabelPegawai = new Pegawai();
            DataTable dt = new DataTable();
            dt = tabelPegawai.Read();
            dataGridViewUpdate.DataSource = dt;
            dataGridViewUpdate.Show();
        }

        private void FormUpdateDataPegawai_Load(object sender, EventArgs e)
        {
            ReadData();
        }
    }
}
