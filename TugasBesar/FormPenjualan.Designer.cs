
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
            this.SuspendLayout();
            // 
            // buttonTambah
            // 
            this.buttonTambah.Location = new System.Drawing.Point(403, 180);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(75, 23);
            this.buttonTambah.TabIndex = 10;
            this.buttonTambah.Text = "Add";
            this.buttonTambah.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerTanggal
            // 
            this.dateTimePickerTanggal.Location = new System.Drawing.Point(314, 51);
            this.dateTimePickerTanggal.Name = "dateTimePickerTanggal";
            this.dateTimePickerTanggal.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTanggal.TabIndex = 9;
            // 
            // textBoxHarga
            // 
            this.textBoxHarga.Location = new System.Drawing.Point(109, 180);
            this.textBoxHarga.Name = "textBoxHarga";
            this.textBoxHarga.Size = new System.Drawing.Size(100, 20);
            this.textBoxHarga.TabIndex = 8;
            // 
            // textBoxIDJual
            // 
            this.textBoxIDJual.Location = new System.Drawing.Point(109, 51);
            this.textBoxIDJual.Name = "textBoxIDJual";
            this.textBoxIDJual.Size = new System.Drawing.Size(100, 20);
            this.textBoxIDJual.TabIndex = 7;
            // 
            // comboBoxBarang
            // 
            this.comboBoxBarang.FormattingEnabled = true;
            this.comboBoxBarang.Location = new System.Drawing.Point(109, 139);
            this.comboBoxBarang.Name = "comboBoxBarang";
            this.comboBoxBarang.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBarang.TabIndex = 6;
            // 
            // FormPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 399);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.dateTimePickerTanggal);
            this.Controls.Add(this.textBoxHarga);
            this.Controls.Add(this.textBoxIDJual);
            this.Controls.Add(this.comboBoxBarang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPenjualan";
            this.Text = "FormPenjualan";
            this.Load += new System.EventHandler(this.FormPenjualan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.DateTimePicker dateTimePickerTanggal;
        private System.Windows.Forms.TextBox textBoxHarga;
        private System.Windows.Forms.TextBox textBoxIDJual;
        private System.Windows.Forms.ComboBox comboBoxBarang;
    }
}