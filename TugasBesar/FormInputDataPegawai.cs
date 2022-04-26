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
    public partial class FormInputDataPegawai : Form
    {
        public FormInputDataPegawai()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Pegawai dataPegawai = new Pegawai();
            dataPegawai.nama_pegawai = textBoxNama.Text;
            dataPegawai.tempat_lahir = textBoxTmptLahir.Text;
            dataPegawai.tanggal_lahir = dateTimePickerTglLahir.Value.ToString("yyyyMMdd");
            dataPegawai.agama = comboBoxAgama.SelectedItem.ToString();
            dataPegawai.alamat = textBoxAlamat.Text;

            String response;
            response = dataPegawai.Insert();
            if (response == null) MessageBox.Show("Input data sukses");
            else MessageBox.Show("Input data gagal " + response);
        }
    }
}
