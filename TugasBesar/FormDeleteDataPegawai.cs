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
    public partial class FormDeleteDataPegawai : Form
    {
        int _id_pegawai;
        public FormDeleteDataPegawai()
        {
            InitializeComponent();
        }

        private void FormDeleteDataPegawai_Load(object sender, EventArgs e)
        {            
            ReadData();
        }

        private void ReadData()
        {
            Pegawai tabelPegawai = new Pegawai();
            DataTable dt = new DataTable();
            dt = tabelPegawai.Read();
            dataGridViewPegawai.DataSource = dt;
            dataGridViewPegawai.Show();
        }

        private void dataGridViewPegawai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridViewPegawai.SelectedCells[0].RowIndex;
            DataGridViewRow selected = dataGridViewPegawai.Rows[index];
            _id_pegawai = Convert.ToInt32(selected.Cells["id_pegawai"].Value);
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string response;
            Pegawai deletePegawai = new Pegawai();
            deletePegawai.id_pegawai = _id_pegawai;
            response = deletePegawai.Delete();
            if (response == null) MessageBox.Show("Hapus data sukses");
            else MessageBox.Show(response);
            ReadData();
        }
    }
}
