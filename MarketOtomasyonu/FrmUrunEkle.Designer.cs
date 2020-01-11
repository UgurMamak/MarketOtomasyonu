namespace MarketOtomasyonu
{
    partial class FrmUrunEkle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnEkle = new MetroFramework.Controls.MetroButton();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.DgwUrunler = new MetroFramework.Controls.MetroGrid();
            this.BtnGeri = new MetroFramework.Controls.MetroButton();
            this.BtnGuncelle = new MetroFramework.Controls.MetroButton();
            this.BtnSil = new MetroFramework.Controls.MetroButton();
            this.TxtUrunAd = new System.Windows.Forms.TextBox();
            this.TxtBirimFyt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgwUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEkle
            // 
            this.BtnEkle.Enabled = false;
            this.BtnEkle.Location = new System.Drawing.Point(393, 100);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(149, 20);
            this.BtnEkle.TabIndex = 3;
            this.BtnEkle.Text = "EKLE";
            this.BtnEkle.UseSelectable = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(179, 100);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(171, 20);
            this.txtBarkod.TabIndex = 0;
            this.txtBarkod.TextChanged += new System.EventHandler(this.txtBarkod_TextChanged);
            this.txtBarkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarkod_KeyPress);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(74, 101);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(56, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Barkod";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(74, 137);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(66, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Ürün Adı";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(74, 174);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(80, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Birim Fiyat";
            // 
            // DgwUrunler
            // 
            this.DgwUrunler.AllowUserToResizeRows = false;
            this.DgwUrunler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DgwUrunler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgwUrunler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgwUrunler.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgwUrunler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgwUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgwUrunler.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgwUrunler.EnableHeadersVisualStyles = false;
            this.DgwUrunler.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DgwUrunler.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DgwUrunler.Location = new System.Drawing.Point(60, 220);
            this.DgwUrunler.Name = "DgwUrunler";
            this.DgwUrunler.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgwUrunler.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgwUrunler.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgwUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgwUrunler.Size = new System.Drawing.Size(634, 164);
            this.DgwUrunler.TabIndex = 6;
            this.DgwUrunler.DoubleClick += new System.EventHandler(this.DgwUrunler_DoubleClick);
            // 
            // BtnGeri
            // 
            this.BtnGeri.Location = new System.Drawing.Point(3, 66);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(108, 23);
            this.BtnGeri.TabIndex = 8;
            this.BtnGeri.Text = "Ana Sayfaya Dön";
            this.BtnGeri.UseSelectable = true;
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Enabled = false;
            this.BtnGuncelle.Location = new System.Drawing.Point(393, 137);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(149, 19);
            this.BtnGuncelle.TabIndex = 4;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.UseSelectable = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Enabled = false;
            this.BtnSil.Location = new System.Drawing.Point(393, 170);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(149, 23);
            this.BtnSil.TabIndex = 5;
            this.BtnSil.Text = "SİL";
            this.BtnSil.UseSelectable = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // TxtUrunAd
            // 
            this.TxtUrunAd.Location = new System.Drawing.Point(179, 138);
            this.TxtUrunAd.Name = "TxtUrunAd";
            this.TxtUrunAd.Size = new System.Drawing.Size(171, 20);
            this.TxtUrunAd.TabIndex = 9;
            // 
            // TxtBirimFyt
            // 
            this.TxtBirimFyt.Location = new System.Drawing.Point(179, 175);
            this.TxtBirimFyt.Name = "TxtBirimFyt";
            this.TxtBirimFyt.Size = new System.Drawing.Size(171, 20);
            this.TxtBirimFyt.TabIndex = 10;
            // 
            // FrmUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 397);
            this.Controls.Add(this.TxtBirimFyt);
            this.Controls.Add(this.TxtUrunAd);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnGeri);
            this.Controls.Add(this.DgwUrunler);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.BtnEkle);
            this.Name = "FrmUrunEkle";
            this.Text = "ÜRÜN EKLE";
            this.Load += new System.EventHandler(this.FrmUrunEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgwUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnEkle;
        private System.Windows.Forms.TextBox txtBarkod;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MetroFramework.Controls.MetroGrid DgwUrunler;
        private MetroFramework.Controls.MetroButton BtnGeri;
        private MetroFramework.Controls.MetroButton BtnGuncelle;
        private MetroFramework.Controls.MetroButton BtnSil;
        private System.Windows.Forms.TextBox TxtUrunAd;
        private System.Windows.Forms.TextBox TxtBirimFyt;
    }
}