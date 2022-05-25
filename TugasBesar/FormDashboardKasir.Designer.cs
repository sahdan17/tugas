
namespace TugasBesar
{
    partial class FormDashboardKasir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboardKasir));
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanelSidebar = new System.Windows.Forms.TableLayoutPanel();
            this.buttonTransaksi = new System.Windows.Forms.Button();
            this.pictureBoxProfil = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogout = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.tableLayoutPanelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogout)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.tableLayoutPanelSidebar);
            this.panel3.Controls.Add(this.pictureBoxProfil);
            this.panel3.Controls.Add(this.pictureBoxLogout);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 561);
            this.panel3.TabIndex = 16;
            // 
            // tableLayoutPanelSidebar
            // 
            this.tableLayoutPanelSidebar.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelSidebar.ColumnCount = 1;
            this.tableLayoutPanelSidebar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSidebar.Controls.Add(this.buttonTransaksi, 0, 0);
            this.tableLayoutPanelSidebar.Location = new System.Drawing.Point(12, 268);
            this.tableLayoutPanelSidebar.Name = "tableLayoutPanelSidebar";
            this.tableLayoutPanelSidebar.RowCount = 4;
            this.tableLayoutPanelSidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelSidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelSidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelSidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelSidebar.Size = new System.Drawing.Size(191, 153);
            this.tableLayoutPanelSidebar.TabIndex = 0;
            // 
            // buttonTransaksi
            // 
            this.buttonTransaksi.BackColor = System.Drawing.Color.White;
            this.buttonTransaksi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTransaksi.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransaksi.Location = new System.Drawing.Point(3, 3);
            this.buttonTransaksi.Name = "buttonTransaksi";
            this.buttonTransaksi.Size = new System.Drawing.Size(185, 32);
            this.buttonTransaksi.TabIndex = 2;
            this.buttonTransaksi.Text = "Transaksi";
            this.buttonTransaksi.UseVisualStyleBackColor = false;
            this.buttonTransaksi.Click += new System.EventHandler(this.buttonTransaksi_Click);
            // 
            // pictureBoxProfil
            // 
            this.pictureBoxProfil.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxProfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxProfil.Image = global::TugasBesar.Properties.Resources.Logo_Universitas_Jambi_UNJA;
            this.pictureBoxProfil.Location = new System.Drawing.Point(9, 1);
            this.pictureBoxProfil.Name = "pictureBoxProfil";
            this.pictureBoxProfil.Size = new System.Drawing.Size(200, 196);
            this.pictureBoxProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfil.TabIndex = 0;
            this.pictureBoxProfil.TabStop = false;
            this.pictureBoxProfil.Click += new System.EventHandler(this.pictureBoxProfil_Click);
            // 
            // pictureBoxLogout
            // 
            this.pictureBoxLogout.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLogout.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogout.Image")));
            this.pictureBoxLogout.Location = new System.Drawing.Point(135, 508);
            this.pictureBoxLogout.Name = "pictureBoxLogout";
            this.pictureBoxLogout.Size = new System.Drawing.Size(83, 41);
            this.pictureBoxLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogout.TabIndex = 1;
            this.pictureBoxLogout.TabStop = false;
            this.pictureBoxLogout.Click += new System.EventHandler(this.pictureBoxLogout_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.labelTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(218, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(666, 74);
            this.panel2.TabIndex = 17;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Baskerville Old Face", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(6, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(299, 54);
            this.labelTitle.TabIndex = 9;
            this.labelTitle.Text = "TRANSAKSI";
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(218, 74);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(666, 487);
            this.panelContent.TabIndex = 18;
            // 
            // FormDashboardKasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDashboardKasir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDashboardKasir";
            this.Load += new System.EventHandler(this.FormDashboardKasir_Load);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogout)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSidebar;
        private System.Windows.Forms.Button buttonTransaksi;
        private System.Windows.Forms.PictureBox pictureBoxProfil;
        private System.Windows.Forms.PictureBox pictureBoxLogout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelContent;
    }
}