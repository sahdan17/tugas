
namespace TugasBesar
{
    partial class FormProfil
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
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPasswordBaru = new System.Windows.Forms.TextBox();
            this.textBoxPasswordKonfirmasi = new System.Windows.Forms.TextBox();
            this.labelUbah = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxPasswordLama = new System.Windows.Forms.TextBox();
            this.buttonOKLama = new System.Windows.Forms.Button();
            this.labelBuat = new System.Windows.Forms.Label();
            this.textBoxUsernameBaru = new System.Windows.Forms.TextBox();
            this.textBoxPWBaru = new System.Windows.Forms.TextBox();
            this.textBoxPWKonfirmasi = new System.Windows.Forms.TextBox();
            this.buttonCancelBuat = new System.Windows.Forms.Button();
            this.buttonOKBuat = new System.Windows.Forms.Button();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.comboBoxID = new System.Windows.Forms.ComboBox();
            this.comboBoxNama = new System.Windows.Forms.ComboBox();
            this.panelContent = new System.Windows.Forms.Panel();
            this.labelKelola = new System.Windows.Forms.Label();
            this.labelUbahUser = new System.Windows.Forms.Label();
            this.textBoxUbahUsername = new System.Windows.Forms.TextBox();
            this.buttonOKUsername = new System.Windows.Forms.Button();
            this.buttonCancelUsername = new System.Windows.Forms.Button();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNama
            // 
            this.textBoxNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNama.Location = new System.Drawing.Point(3, 66);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.ReadOnly = true;
            this.textBoxNama.Size = new System.Drawing.Size(164, 26);
            this.textBoxNama.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(3, 104);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.ReadOnly = true;
            this.textBoxPassword.Size = new System.Drawing.Size(164, 26);
            this.textBoxPassword.TabIndex = 1;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(3, 26);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.ReadOnly = true;
            this.textBoxUsername.Size = new System.Drawing.Size(164, 26);
            this.textBoxUsername.TabIndex = 2;
            // 
            // textBoxPasswordBaru
            // 
            this.textBoxPasswordBaru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordBaru.Location = new System.Drawing.Point(3, 231);
            this.textBoxPasswordBaru.Name = "textBoxPasswordBaru";
            this.textBoxPasswordBaru.PasswordChar = '*';
            this.textBoxPasswordBaru.Size = new System.Drawing.Size(164, 26);
            this.textBoxPasswordBaru.TabIndex = 3;
            this.textBoxPasswordBaru.Visible = false;
            // 
            // textBoxPasswordKonfirmasi
            // 
            this.textBoxPasswordKonfirmasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordKonfirmasi.Location = new System.Drawing.Point(3, 275);
            this.textBoxPasswordKonfirmasi.Name = "textBoxPasswordKonfirmasi";
            this.textBoxPasswordKonfirmasi.PasswordChar = '*';
            this.textBoxPasswordKonfirmasi.Size = new System.Drawing.Size(164, 26);
            this.textBoxPasswordKonfirmasi.TabIndex = 4;
            this.textBoxPasswordKonfirmasi.Visible = false;
            // 
            // labelUbah
            // 
            this.labelUbah.AutoSize = true;
            this.labelUbah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelUbah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUbah.Location = new System.Drawing.Point(0, 150);
            this.labelUbah.Name = "labelUbah";
            this.labelUbah.Size = new System.Drawing.Size(103, 16);
            this.labelUbah.TabIndex = 5;
            this.labelUbah.Text = "Ubah password";
            this.labelUbah.Visible = false;
            this.labelUbah.Click += new System.EventHandler(this.labelUbah_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(91, 308);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Visible = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(10, 308);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxPasswordLama
            // 
            this.textBoxPasswordLama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordLama.Location = new System.Drawing.Point(3, 188);
            this.textBoxPasswordLama.Name = "textBoxPasswordLama";
            this.textBoxPasswordLama.PasswordChar = '*';
            this.textBoxPasswordLama.Size = new System.Drawing.Size(164, 26);
            this.textBoxPasswordLama.TabIndex = 8;
            this.textBoxPasswordLama.Visible = false;
            // 
            // buttonOKLama
            // 
            this.buttonOKLama.Location = new System.Drawing.Point(173, 188);
            this.buttonOKLama.Name = "buttonOKLama";
            this.buttonOKLama.Size = new System.Drawing.Size(75, 23);
            this.buttonOKLama.TabIndex = 9;
            this.buttonOKLama.Text = "OK";
            this.buttonOKLama.UseVisualStyleBackColor = true;
            this.buttonOKLama.Visible = false;
            this.buttonOKLama.Click += new System.EventHandler(this.buttonOKLama_Click);
            // 
            // labelBuat
            // 
            this.labelBuat.AutoSize = true;
            this.labelBuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelBuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuat.Location = new System.Drawing.Point(109, 133);
            this.labelBuat.Name = "labelBuat";
            this.labelBuat.Size = new System.Drawing.Size(97, 16);
            this.labelBuat.TabIndex = 10;
            this.labelBuat.Text = "Buat akun baru";
            this.labelBuat.Click += new System.EventHandler(this.labelBuat_Click);
            // 
            // textBoxUsernameBaru
            // 
            this.textBoxUsernameBaru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsernameBaru.Location = new System.Drawing.Point(337, 124);
            this.textBoxUsernameBaru.Name = "textBoxUsernameBaru";
            this.textBoxUsernameBaru.Size = new System.Drawing.Size(164, 26);
            this.textBoxUsernameBaru.TabIndex = 11;
            this.textBoxUsernameBaru.Visible = false;
            // 
            // textBoxPWBaru
            // 
            this.textBoxPWBaru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPWBaru.Location = new System.Drawing.Point(337, 202);
            this.textBoxPWBaru.Name = "textBoxPWBaru";
            this.textBoxPWBaru.Size = new System.Drawing.Size(164, 26);
            this.textBoxPWBaru.TabIndex = 13;
            this.textBoxPWBaru.Visible = false;
            // 
            // textBoxPWKonfirmasi
            // 
            this.textBoxPWKonfirmasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPWKonfirmasi.Location = new System.Drawing.Point(337, 245);
            this.textBoxPWKonfirmasi.Name = "textBoxPWKonfirmasi";
            this.textBoxPWKonfirmasi.Size = new System.Drawing.Size(164, 26);
            this.textBoxPWKonfirmasi.TabIndex = 14;
            this.textBoxPWKonfirmasi.Visible = false;
            // 
            // buttonCancelBuat
            // 
            this.buttonCancelBuat.Location = new System.Drawing.Point(337, 277);
            this.buttonCancelBuat.Name = "buttonCancelBuat";
            this.buttonCancelBuat.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelBuat.TabIndex = 16;
            this.buttonCancelBuat.Text = "Cancel";
            this.buttonCancelBuat.UseVisualStyleBackColor = true;
            this.buttonCancelBuat.Visible = false;
            this.buttonCancelBuat.Click += new System.EventHandler(this.buttonCancelBuat_Click);
            // 
            // buttonOKBuat
            // 
            this.buttonOKBuat.Location = new System.Drawing.Point(418, 277);
            this.buttonOKBuat.Name = "buttonOKBuat";
            this.buttonOKBuat.Size = new System.Drawing.Size(75, 23);
            this.buttonOKBuat.TabIndex = 15;
            this.buttonOKBuat.Text = "OK";
            this.buttonOKBuat.UseVisualStyleBackColor = true;
            this.buttonOKBuat.Visible = false;
            this.buttonOKBuat.Click += new System.EventHandler(this.buttonOKBuat_Click);
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "Admin",
            "Kasir"});
            this.comboBoxRole.Location = new System.Drawing.Point(337, 164);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(164, 28);
            this.comboBoxRole.TabIndex = 17;
            this.comboBoxRole.Visible = false;
            // 
            // comboBoxID
            // 
            this.comboBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxID.FormattingEnabled = true;
            this.comboBoxID.Location = new System.Drawing.Point(337, 38);
            this.comboBoxID.Name = "comboBoxID";
            this.comboBoxID.Size = new System.Drawing.Size(164, 28);
            this.comboBoxID.TabIndex = 18;
            this.comboBoxID.Visible = false;
            // 
            // comboBoxNama
            // 
            this.comboBoxNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNama.FormattingEnabled = true;
            this.comboBoxNama.Location = new System.Drawing.Point(337, 81);
            this.comboBoxNama.Name = "comboBoxNama";
            this.comboBoxNama.Size = new System.Drawing.Size(164, 28);
            this.comboBoxNama.TabIndex = 19;
            this.comboBoxNama.Visible = false;
            this.comboBoxNama.SelectedIndexChanged += new System.EventHandler(this.comboBoxNama_SelectedIndexChanged);
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.buttonOKUsername);
            this.panelContent.Controls.Add(this.buttonCancelUsername);
            this.panelContent.Controls.Add(this.textBoxUbahUsername);
            this.panelContent.Controls.Add(this.labelUbahUser);
            this.panelContent.Controls.Add(this.labelKelola);
            this.panelContent.Controls.Add(this.textBoxPasswordLama);
            this.panelContent.Controls.Add(this.comboBoxNama);
            this.panelContent.Controls.Add(this.textBoxNama);
            this.panelContent.Controls.Add(this.comboBoxID);
            this.panelContent.Controls.Add(this.textBoxPassword);
            this.panelContent.Controls.Add(this.comboBoxRole);
            this.panelContent.Controls.Add(this.textBoxUsername);
            this.panelContent.Controls.Add(this.buttonCancelBuat);
            this.panelContent.Controls.Add(this.textBoxPasswordBaru);
            this.panelContent.Controls.Add(this.buttonOKBuat);
            this.panelContent.Controls.Add(this.textBoxPasswordKonfirmasi);
            this.panelContent.Controls.Add(this.textBoxPWKonfirmasi);
            this.panelContent.Controls.Add(this.labelUbah);
            this.panelContent.Controls.Add(this.textBoxPWBaru);
            this.panelContent.Controls.Add(this.textBoxUsernameBaru);
            this.panelContent.Controls.Add(this.buttonOK);
            this.panelContent.Controls.Add(this.buttonCancel);
            this.panelContent.Controls.Add(this.labelBuat);
            this.panelContent.Controls.Add(this.buttonOKLama);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(684, 487);
            this.panelContent.TabIndex = 20;
            // 
            // labelKelola
            // 
            this.labelKelola.AutoSize = true;
            this.labelKelola.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelKelola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKelola.Location = new System.Drawing.Point(3, 133);
            this.labelKelola.Name = "labelKelola";
            this.labelKelola.Size = new System.Drawing.Size(78, 16);
            this.labelKelola.TabIndex = 20;
            this.labelKelola.Text = "Kelola akun";
            this.labelKelola.Click += new System.EventHandler(this.labelKelola_Click);
            // 
            // labelUbahUser
            // 
            this.labelUbahUser.AutoSize = true;
            this.labelUbahUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelUbahUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUbahUser.Location = new System.Drawing.Point(3, 169);
            this.labelUbahUser.Name = "labelUbahUser";
            this.labelUbahUser.Size = new System.Drawing.Size(104, 16);
            this.labelUbahUser.TabIndex = 21;
            this.labelUbahUser.Text = "Ubah username";
            this.labelUbahUser.Visible = false;
            this.labelUbahUser.Click += new System.EventHandler(this.labelUbahUser_Click);
            // 
            // textBoxUbahUsername
            // 
            this.textBoxUbahUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUbahUsername.Location = new System.Drawing.Point(3, 346);
            this.textBoxUbahUsername.Name = "textBoxUbahUsername";
            this.textBoxUbahUsername.Size = new System.Drawing.Size(164, 26);
            this.textBoxUbahUsername.TabIndex = 22;
            this.textBoxUbahUsername.Visible = false;
            // 
            // buttonOKUsername
            // 
            this.buttonOKUsername.Location = new System.Drawing.Point(93, 378);
            this.buttonOKUsername.Name = "buttonOKUsername";
            this.buttonOKUsername.Size = new System.Drawing.Size(75, 23);
            this.buttonOKUsername.TabIndex = 23;
            this.buttonOKUsername.Text = "OK";
            this.buttonOKUsername.UseVisualStyleBackColor = true;
            this.buttonOKUsername.Visible = false;
            this.buttonOKUsername.Click += new System.EventHandler(this.buttonOKUsername_Click);
            // 
            // buttonCancelUsername
            // 
            this.buttonCancelUsername.Location = new System.Drawing.Point(12, 378);
            this.buttonCancelUsername.Name = "buttonCancelUsername";
            this.buttonCancelUsername.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelUsername.TabIndex = 24;
            this.buttonCancelUsername.Text = "Cancel";
            this.buttonCancelUsername.UseVisualStyleBackColor = true;
            this.buttonCancelUsername.Visible = false;
            this.buttonCancelUsername.Click += new System.EventHandler(this.buttonCancelUsername_Click);
            // 
            // FormProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 487);
            this.Controls.Add(this.panelContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProfil";
            this.Text = "FormProfil";
            this.Load += new System.EventHandler(this.FormProfil_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPasswordBaru;
        private System.Windows.Forms.TextBox textBoxPasswordKonfirmasi;
        private System.Windows.Forms.Label labelUbah;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxPasswordLama;
        private System.Windows.Forms.Button buttonOKLama;
        private System.Windows.Forms.Label labelBuat;
        private System.Windows.Forms.TextBox textBoxUsernameBaru;
        private System.Windows.Forms.TextBox textBoxPWBaru;
        private System.Windows.Forms.TextBox textBoxPWKonfirmasi;
        private System.Windows.Forms.Button buttonCancelBuat;
        private System.Windows.Forms.Button buttonOKBuat;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.ComboBox comboBoxID;
        private System.Windows.Forms.ComboBox comboBoxNama;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label labelUbahUser;
        private System.Windows.Forms.Label labelKelola;
        private System.Windows.Forms.Button buttonOKUsername;
        private System.Windows.Forms.Button buttonCancelUsername;
        private System.Windows.Forms.TextBox textBoxUbahUsername;
    }
}