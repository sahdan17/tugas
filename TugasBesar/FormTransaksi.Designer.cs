
namespace TugasBesar
{
    partial class FormTransaksi
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonService = new System.Windows.Forms.Button();
            this.buttonPenjualan = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonService, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonPenjualan, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 443);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(684, 44);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonService
            // 
            this.buttonService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonService.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonService.Location = new System.Drawing.Point(345, 3);
            this.buttonService.Name = "buttonService";
            this.buttonService.Size = new System.Drawing.Size(336, 38);
            this.buttonService.TabIndex = 1;
            this.buttonService.Text = "Service";
            this.buttonService.UseVisualStyleBackColor = true;
            this.buttonService.Click += new System.EventHandler(this.buttonService_Click);
            // 
            // buttonPenjualan
            // 
            this.buttonPenjualan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPenjualan.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPenjualan.Location = new System.Drawing.Point(3, 3);
            this.buttonPenjualan.Name = "buttonPenjualan";
            this.buttonPenjualan.Size = new System.Drawing.Size(336, 38);
            this.buttonPenjualan.TabIndex = 0;
            this.buttonPenjualan.Text = "Penjualan";
            this.buttonPenjualan.UseVisualStyleBackColor = true;
            this.buttonPenjualan.Click += new System.EventHandler(this.buttonPenjualan_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.labelTitle.Location = new System.Drawing.Point(3, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(0, 27);
            this.labelTitle.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 44);
            this.panel1.TabIndex = 3;
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 44);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(684, 399);
            this.panelContent.TabIndex = 4;
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 487);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTransaksi";
            this.Text = "FormTransaksi";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonService;
        private System.Windows.Forms.Button buttonPenjualan;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelContent;
    }
}