namespace MarketOtomasyonu
{
    partial class FrmIslemler
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
            this.TxtBarkod = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.LblBarkod = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.LblUrun = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.LblToplamFiyat = new MaterialSkin.Controls.MaterialLabel();
            this.DgwHarcamalar = new MetroFramework.Controls.MetroGrid();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.LblBirimFiyat = new MaterialSkin.Controls.MaterialLabel();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.LblAdFyt = new MaterialSkin.Controls.MaterialLabel();
            this.barkodd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fyt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdFyt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DgwHarcamalar)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtBarkod
            // 
            this.TxtBarkod.Location = new System.Drawing.Point(12, 102);
            this.TxtBarkod.Name = "TxtBarkod";
            this.TxtBarkod.Size = new System.Drawing.Size(214, 20);
            this.TxtBarkod.TabIndex = 0;
            this.TxtBarkod.TextChanged += new System.EventHandler(this.TxtBarkod_TextChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(8, 149);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(56, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Barkod";
            // 
            // LblBarkod
            // 
            this.LblBarkod.AutoSize = true;
            this.LblBarkod.Depth = 0;
            this.LblBarkod.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblBarkod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblBarkod.Location = new System.Drawing.Point(117, 149);
            this.LblBarkod.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblBarkod.Name = "LblBarkod";
            this.LblBarkod.Size = new System.Drawing.Size(109, 19);
            this.LblBarkod.TabIndex = 2;
            this.LblBarkod.Text = ".........................";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(8, 196);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(40, 19);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Ürün";
            // 
            // LblUrun
            // 
            this.LblUrun.AutoSize = true;
            this.LblUrun.Depth = 0;
            this.LblUrun.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblUrun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblUrun.Location = new System.Drawing.Point(117, 196);
            this.LblUrun.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblUrun.Name = "LblUrun";
            this.LblUrun.Size = new System.Drawing.Size(109, 19);
            this.LblUrun.TabIndex = 4;
            this.LblUrun.Text = ".........................";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(8, 336);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(96, 19);
            this.materialLabel5.TabIndex = 5;
            this.materialLabel5.Text = "Toplam Fiyat";
            // 
            // LblToplamFiyat
            // 
            this.LblToplamFiyat.AutoSize = true;
            this.LblToplamFiyat.Depth = 0;
            this.LblToplamFiyat.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblToplamFiyat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblToplamFiyat.Location = new System.Drawing.Point(117, 336);
            this.LblToplamFiyat.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblToplamFiyat.Name = "LblToplamFiyat";
            this.LblToplamFiyat.Size = new System.Drawing.Size(109, 19);
            this.LblToplamFiyat.TabIndex = 6;
            this.LblToplamFiyat.Text = ".........................";
            // 
            // DgwHarcamalar
            // 
            this.DgwHarcamalar.AllowUserToResizeRows = false;
            this.DgwHarcamalar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DgwHarcamalar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgwHarcamalar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgwHarcamalar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgwHarcamalar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgwHarcamalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwHarcamalar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barkodd,
            this.urunadi,
            this.fyt,
            this.AdFyt});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgwHarcamalar.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgwHarcamalar.EnableHeadersVisualStyles = false;
            this.DgwHarcamalar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DgwHarcamalar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DgwHarcamalar.Location = new System.Drawing.Point(272, 102);
            this.DgwHarcamalar.Name = "DgwHarcamalar";
            this.DgwHarcamalar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgwHarcamalar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgwHarcamalar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgwHarcamalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgwHarcamalar.Size = new System.Drawing.Size(442, 253);
            this.DgwHarcamalar.TabIndex = 7;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(8, 248);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(80, 19);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Birim Fiyat";
            // 
            // LblBirimFiyat
            // 
            this.LblBirimFiyat.AutoSize = true;
            this.LblBirimFiyat.Depth = 0;
            this.LblBirimFiyat.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblBirimFiyat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblBirimFiyat.Location = new System.Drawing.Point(117, 248);
            this.LblBirimFiyat.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblBirimFiyat.Name = "LblBirimFiyat";
            this.LblBirimFiyat.Size = new System.Drawing.Size(109, 19);
            this.LblBirimFiyat.TabIndex = 9;
            this.LblBirimFiyat.Text = ".........................";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(54, 76);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(60, 20);
            this.txtAdet.TabIndex = 10;
            this.txtAdet.Text = "1";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(8, 293);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(89, 19);
            this.materialLabel4.TabIndex = 11;
            this.materialLabel4.Text = "Adet X Fiyat";
            // 
            // LblAdFyt
            // 
            this.LblAdFyt.AutoSize = true;
            this.LblAdFyt.Depth = 0;
            this.LblAdFyt.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblAdFyt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblAdFyt.Location = new System.Drawing.Point(117, 293);
            this.LblAdFyt.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblAdFyt.Name = "LblAdFyt";
            this.LblAdFyt.Size = new System.Drawing.Size(109, 19);
            this.LblAdFyt.TabIndex = 12;
            this.LblAdFyt.Text = ".........................";
            // 
            // barkodd
            // 
            this.barkodd.HeaderText = "Barkod";
            this.barkodd.Name = "barkodd";
            // 
            // urunadi
            // 
            this.urunadi.HeaderText = "Ürün Adı";
            this.urunadi.Name = "urunadi";
            // 
            // fyt
            // 
            this.fyt.HeaderText = "Birim Fiyat";
            this.fyt.Name = "fyt";
            // 
            // AdFyt
            // 
            this.AdFyt.HeaderText = "Fiyat X Adet";
            this.AdFyt.Name = "AdFyt";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(8, 77);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(40, 19);
            this.materialLabel6.TabIndex = 13;
            this.materialLabel6.Text = "Adet";
            // 
            // FrmIslemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.LblAdFyt);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.LblBirimFiyat);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.DgwHarcamalar);
            this.Controls.Add(this.LblToplamFiyat);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.LblUrun);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.LblBarkod);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.TxtBarkod);
            this.Name = "FrmIslemler";
            this.Text = "FrmIslemler";
            this.Load += new System.EventHandler(this.FrmIslemler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgwHarcamalar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBarkod;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel LblBarkod;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel LblUrun;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel LblToplamFiyat;
        private MetroFramework.Controls.MetroGrid DgwHarcamalar;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel LblBirimFiyat;
        private System.Windows.Forms.TextBox txtAdet;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel LblAdFyt;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodd;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn fyt;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdFyt;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
    }
}