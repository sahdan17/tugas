
namespace TugasBesar
{
    partial class FormPenjualan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonTambah = new System.Windows.Forms.Button();
            this.dateTimePickerTanggal = new System.Windows.Forms.DateTimePicker();
            this.textBoxHarga = new System.Windows.Forms.TextBox();
            this.textBoxIDJual = new System.Windows.Forms.TextBox();
            this.comboBoxBarang = new System.Windows.Forms.ComboBox();
            this.comboBoxKode = new System.Windows.Forms.ComboBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.dataGridViewDaftar = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxHargaTot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKuantitas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftar)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonTambah
            // 
            this.buttonTambah.Enabled = false;
            this.buttonTambah.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.Location = new System.Drawing.Point(474, 196);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(75, 22);
            this.buttonTambah.TabIndex = 10;
            this.buttonTambah.Text = "Add";
            this.buttonTambah.UseVisualStyleBackColor = true;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // dateTimePickerTanggal
            // 
            this.dateTimePickerTanggal.Enabled = false;
            this.dateTimePickerTanggal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTanggal.Location = new System.Drawing.Point(439, 9);
            this.dateTimePickerTanggal.Name = "dateTimePickerTanggal";
            this.dateTimePickerTanggal.Size = new System.Drawing.Size(233, 22);
            this.dateTimePickerTanggal.TabIndex = 9;
            // 
            // textBoxHarga
            // 
            this.textBoxHarga.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHarga.Location = new System.Drawing.Point(214, 87);
            this.textBoxHarga.Name = "textBoxHarga";
            this.textBoxHarga.ReadOnly = true;
            this.textBoxHarga.Size = new System.Drawing.Size(358, 22);
            this.textBoxHarga.TabIndex = 8;
            // 
            // textBoxIDJual
            // 
            this.textBoxIDJual.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIDJual.Location = new System.Drawing.Point(142, 9);
            this.textBoxIDJual.Name = "textBoxIDJual";
            this.textBoxIDJual.ReadOnly = true;
            this.textBoxIDJual.Size = new System.Drawing.Size(197, 22);
            this.textBoxIDJual.TabIndex = 7;
            // 
            // comboBoxBarang
            // 
            this.comboBoxBarang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxBarang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxBarang.Enabled = false;
            this.comboBoxBarang.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBarang.FormattingEnabled = true;
            this.comboBoxBarang.Location = new System.Drawing.Point(214, 31);
            this.comboBoxBarang.Name = "comboBoxBarang";
            this.comboBoxBarang.Size = new System.Drawing.Size(358, 23);
            this.comboBoxBarang.TabIndex = 6;
            this.comboBoxBarang.SelectedIndexChanged += new System.EventHandler(this.comboBoxBarang_SelectedIndexChanged);
            // 
            // comboBoxKode
            // 
            this.comboBoxKode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxKode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxKode.Enabled = false;
            this.comboBoxKode.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxKode.FormattingEnabled = true;
            this.comboBoxKode.Location = new System.Drawing.Point(214, 3);
            this.comboBoxKode.Name = "comboBoxKode";
            this.comboBoxKode.Size = new System.Drawing.Size(358, 23);
            this.comboBoxKode.TabIndex = 11;
            this.comboBoxKode.SelectedIndexChanged += new System.EventHandler(this.comboBoxKode_SelectedIndexChanged);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Enabled = false;
            this.buttonSubmit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(555, 196);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 22);
            this.buttonSubmit.TabIndex = 12;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNew.Location = new System.Drawing.Point(12, 8);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(124, 22);
            this.buttonNew.TabIndex = 13;
            this.buttonNew.Text = "New Transaksi";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // dataGridViewDaftar
            // 
            this.dataGridViewDaftar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaftar.Location = new System.Drawing.Point(13, 224);
            this.dataGridViewDaftar.Name = "dataGridViewDaftar";
            this.dataGridViewDaftar.Size = new System.Drawing.Size(659, 163);
            this.dataGridViewDaftar.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.86956F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.13044F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxKode, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxBarang, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxHargaTot, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxKuantitas, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxHarga, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(55, 47);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(575, 143);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Harga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nama Barang";
            // 
            // textBoxHargaTot
            // 
            this.textBoxHargaTot.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHargaTot.Location = new System.Drawing.Point(214, 115);
            this.textBoxHargaTot.Name = "textBoxHargaTot";
            this.textBoxHargaTot.ReadOnly = true;
            this.textBoxHargaTot.Size = new System.Drawing.Size(358, 22);
            this.textBoxHargaTot.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Kode Barang";
            // 
            // textBoxKuantitas
            // 
            this.textBoxKuantitas.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKuantitas.Location = new System.Drawing.Point(214, 59);
            this.textBoxKuantitas.Name = "textBoxKuantitas";
            this.textBoxKuantitas.ReadOnly = true;
            this.textBoxKuantitas.Size = new System.Drawing.Size(358, 22);
            this.textBoxKuantitas.TabIndex = 12;
            this.textBoxKuantitas.TextChanged += new System.EventHandler(this.textBoxKuantitas_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Kuantitas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Harga per Unit";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotal.Location = new System.Drawing.Point(269, 196);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(199, 22);
            this.textBoxTotal.TabIndex = 16;
            // 
            // FormPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 399);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridViewDaftar);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.dateTimePickerTanggal);
            this.Controls.Add(this.textBoxIDJual);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPenjualan";
            this.Text = "FormPenjualan";
            this.Load += new System.EventHandler(this.FormPenjualan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftar)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.DateTimePicker dateTimePickerTanggal;
        private System.Windows.Forms.TextBox textBoxHarga;
        private System.Windows.Forms.TextBox textBoxIDJual;
        private System.Windows.Forms.ComboBox comboBoxBarang;
        private System.Windows.Forms.ComboBox comboBoxKode;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.DataGridView dataGridViewDaftar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxHargaTot;
        private System.Windows.Forms.TextBox textBoxKuantitas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTotal;
    }
}