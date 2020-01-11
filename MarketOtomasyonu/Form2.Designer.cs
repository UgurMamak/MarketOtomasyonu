namespace MarketOtomasyonu
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.TapControl = new MaterialSkin.Controls.MaterialTabControl();
            this.TpAnaSayfa = new System.Windows.Forms.TabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dgwStok = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TpPersonelEkle = new System.Windows.Forms.TabPage();
            this.BtnDosyaAc = new MetroFramework.Controls.MetroButton();
            this.DgwUrunler = new System.Windows.Forms.DataGridView();
            this.BtnStokKaydet = new MetroFramework.Controls.MetroButton();
            this.TpAracCikis = new System.Windows.Forms.TabPage();
            this.txtGelisFiyat = new System.Windows.Forms.TextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnStokGuncelle = new MetroFramework.Controls.MetroButton();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.TxtBirimFyt = new System.Windows.Forms.TextBox();
            this.TxtUrunAd = new System.Windows.Forms.TextBox();
            this.BtnSil = new MetroFramework.Controls.MetroButton();
            this.BtnGuncelle = new MetroFramework.Controls.MetroButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.BtnEkle = new MetroFramework.Controls.MetroButton();
            this.TpRapor = new System.Windows.Forms.TabPage();
            this.LblGider = new MetroFramework.Controls.MetroLabel();
            this.LblNet = new MetroFramework.Controls.MetroLabel();
            this.LblGelir = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.dgwIslemler = new System.Windows.Forms.DataGridView();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.TapControl.SuspendLayout();
            this.TpAnaSayfa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStok)).BeginInit();
            this.TpPersonelEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgwUrunler)).BeginInit();
            this.TpAracCikis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.TpRapor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwIslemler)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.TapControl;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.materialTabSelector1.Location = new System.Drawing.Point(-3, 54);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1249, 30);
            this.materialTabSelector1.TabIndex = 6;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // TapControl
            // 
            this.TapControl.Controls.Add(this.TpAnaSayfa);
            this.TapControl.Controls.Add(this.TpPersonelEkle);
            this.TapControl.Controls.Add(this.TpAracCikis);
            this.TapControl.Controls.Add(this.TpRapor);
            this.TapControl.Depth = 0;
            this.TapControl.Location = new System.Drawing.Point(1, 84);
            this.TapControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.TapControl.Name = "TapControl";
            this.TapControl.SelectedIndex = 0;
            this.TapControl.Size = new System.Drawing.Size(1047, 364);
            this.TapControl.TabIndex = 5;
            // 
            // TpAnaSayfa
            // 
            this.TpAnaSayfa.Controls.Add(this.metroLabel1);
            this.TpAnaSayfa.Controls.Add(this.dgwStok);
            this.TpAnaSayfa.Location = new System.Drawing.Point(4, 22);
            this.TpAnaSayfa.Name = "TpAnaSayfa";
            this.TpAnaSayfa.Padding = new System.Windows.Forms.Padding(3);
            this.TpAnaSayfa.Size = new System.Drawing.Size(1039, 338);
            this.TpAnaSayfa.TabIndex = 0;
            this.TpAnaSayfa.Text = "Stok";
            this.TpAnaSayfa.UseVisualStyleBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(431, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(125, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "STOKTAKİ ÜRÜNLER";
            // 
            // dgwStok
            // 
            this.dgwStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgwStok.Location = new System.Drawing.Point(166, 37);
            this.dgwStok.Name = "dgwStok";
            this.dgwStok.Size = new System.Drawing.Size(643, 280);
            this.dgwStok.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ürün Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Barkod";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ürün Adı";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Geliş Fiyat";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Satş Fiyat";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Stok";
            this.Column6.Name = "Column6";
            // 
            // TpPersonelEkle
            // 
            this.TpPersonelEkle.BackColor = System.Drawing.Color.White;
            this.TpPersonelEkle.Controls.Add(this.BtnDosyaAc);
            this.TpPersonelEkle.Controls.Add(this.DgwUrunler);
            this.TpPersonelEkle.Controls.Add(this.BtnStokKaydet);
            this.TpPersonelEkle.Location = new System.Drawing.Point(4, 22);
            this.TpPersonelEkle.Name = "TpPersonelEkle";
            this.TpPersonelEkle.Padding = new System.Windows.Forms.Padding(3);
            this.TpPersonelEkle.Size = new System.Drawing.Size(1039, 338);
            this.TpPersonelEkle.TabIndex = 1;
            this.TpPersonelEkle.Text = "Stok ekle(Faturadan)";
            // 
            // BtnDosyaAc
            // 
            this.BtnDosyaAc.Location = new System.Drawing.Point(317, 6);
            this.BtnDosyaAc.Name = "BtnDosyaAc";
            this.BtnDosyaAc.Size = new System.Drawing.Size(104, 46);
            this.BtnDosyaAc.TabIndex = 8;
            this.BtnDosyaAc.Text = "Fatura Yükle";
            this.BtnDosyaAc.UseSelectable = true;
            this.BtnDosyaAc.Click += new System.EventHandler(this.BtnDosyaAc_Click);
            // 
            // DgwUrunler
            // 
            this.DgwUrunler.AllowUserToAddRows = false;
            this.DgwUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwUrunler.Location = new System.Drawing.Point(56, 58);
            this.DgwUrunler.Name = "DgwUrunler";
            this.DgwUrunler.Size = new System.Drawing.Size(836, 233);
            this.DgwUrunler.TabIndex = 7;
            // 
            // BtnStokKaydet
            // 
            this.BtnStokKaydet.Enabled = false;
            this.BtnStokKaydet.Location = new System.Drawing.Point(447, 6);
            this.BtnStokKaydet.Name = "BtnStokKaydet";
            this.BtnStokKaydet.Size = new System.Drawing.Size(96, 46);
            this.BtnStokKaydet.TabIndex = 6;
            this.BtnStokKaydet.Text = "Stok Kaydet";
            this.BtnStokKaydet.UseSelectable = true;
            this.BtnStokKaydet.Click += new System.EventHandler(this.BtnStokKaydet_Click_1);
            // 
            // TpAracCikis
            // 
            this.TpAracCikis.BackColor = System.Drawing.Color.White;
            this.TpAracCikis.Controls.Add(this.txtGelisFiyat);
            this.TpAracCikis.Controls.Add(this.metroLabel3);
            this.TpAracCikis.Controls.Add(this.metroLabel2);
            this.TpAracCikis.Controls.Add(this.btnStokGuncelle);
            this.TpAracCikis.Controls.Add(this.txtStok);
            this.TpAracCikis.Controls.Add(this.TxtBirimFyt);
            this.TpAracCikis.Controls.Add(this.TxtUrunAd);
            this.TpAracCikis.Controls.Add(this.BtnSil);
            this.TpAracCikis.Controls.Add(this.BtnGuncelle);
            this.TpAracCikis.Controls.Add(this.materialLabel5);
            this.TpAracCikis.Controls.Add(this.materialLabel4);
            this.TpAracCikis.Controls.Add(this.metroGrid1);
            this.TpAracCikis.Controls.Add(this.materialLabel3);
            this.TpAracCikis.Controls.Add(this.materialLabel2);
            this.TpAracCikis.Controls.Add(this.materialLabel1);
            this.TpAracCikis.Controls.Add(this.txtBarkod);
            this.TpAracCikis.Controls.Add(this.BtnEkle);
            this.TpAracCikis.Location = new System.Drawing.Point(4, 22);
            this.TpAracCikis.Name = "TpAracCikis";
            this.TpAracCikis.Padding = new System.Windows.Forms.Padding(3);
            this.TpAracCikis.Size = new System.Drawing.Size(1039, 338);
            this.TpAracCikis.TabIndex = 2;
            this.TpAracCikis.Text = "Stok ekle(Elle)";
            // 
            // txtGelisFiyat
            // 
            this.txtGelisFiyat.Location = new System.Drawing.Point(304, 77);
            this.txtGelisFiyat.Name = "txtGelisFiyat";
            this.txtGelisFiyat.Size = new System.Drawing.Size(171, 20);
            this.txtGelisFiyat.TabIndex = 24;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(659, 78);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(228, 19);
            this.metroLabel3.TabIndex = 23;
            this.metroLabel3.Text = "(Girilen değer eski adete eklenecektir.)";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(659, 113);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(242, 19);
            this.metroLabel2.TabIndex = 22;
            this.metroLabel2.Text = "(Girilen değer yeni stok değeri olacaktır)";
            // 
            // btnStokGuncelle
            // 
            this.btnStokGuncelle.Enabled = false;
            this.btnStokGuncelle.Location = new System.Drawing.Point(504, 112);
            this.btnStokGuncelle.Name = "btnStokGuncelle";
            this.btnStokGuncelle.Size = new System.Drawing.Size(149, 20);
            this.btnStokGuncelle.TabIndex = 21;
            this.btnStokGuncelle.Text = "STOK GÜNCELLE";
            this.btnStokGuncelle.UseSelectable = true;
            this.btnStokGuncelle.Click += new System.EventHandler(this.btnStokGuncelle_Click);
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(304, 144);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(171, 20);
            this.txtStok.TabIndex = 20;
            // 
            // TxtBirimFyt
            // 
            this.TxtBirimFyt.Location = new System.Drawing.Point(304, 112);
            this.TxtBirimFyt.Name = "TxtBirimFyt";
            this.TxtBirimFyt.Size = new System.Drawing.Size(171, 20);
            this.TxtBirimFyt.TabIndex = 20;
            // 
            // TxtUrunAd
            // 
            this.TxtUrunAd.Location = new System.Drawing.Point(304, 44);
            this.TxtUrunAd.Name = "TxtUrunAd";
            this.TxtUrunAd.Size = new System.Drawing.Size(171, 20);
            this.TxtUrunAd.TabIndex = 19;
            // 
            // BtnSil
            // 
            this.BtnSil.Enabled = false;
            this.BtnSil.Location = new System.Drawing.Point(504, 45);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(149, 23);
            this.BtnSil.TabIndex = 17;
            this.BtnSil.Text = "ÜRÜN ÇIKAR";
            this.BtnSil.UseSelectable = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Enabled = false;
            this.BtnGuncelle.Location = new System.Drawing.Point(504, 78);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(149, 19);
            this.BtnGuncelle.TabIndex = 15;
            this.BtnGuncelle.Text = "ÜRÜN GÜNCELLE";
            this.BtnGuncelle.UseSelectable = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(199, 80);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(83, 19);
            this.materialLabel5.TabIndex = 16;
            this.materialLabel5.Text = "Geliş Fiyatı";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(203, 143);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(40, 19);
            this.materialLabel4.TabIndex = 16;
            this.materialLabel4.Text = "Stok";
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(149, 170);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(651, 162);
            this.metroGrid1.TabIndex = 18;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "UrunId";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Barkod";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Ürün Adı";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Geliş Fiyat";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Satış Fiyat";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Stok";
            this.Column12.Name = "Column12";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(203, 113);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(79, 19);
            this.materialLabel3.TabIndex = 16;
            this.materialLabel3.Text = "Satış Fiyat";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(199, 45);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(66, 19);
            this.materialLabel2.TabIndex = 13;
            this.materialLabel2.Text = "Ürün Adı";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(199, 11);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(56, 19);
            this.materialLabel1.TabIndex = 12;
            this.materialLabel1.Text = "Barkod";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(304, 10);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(171, 20);
            this.txtBarkod.TabIndex = 11;
            this.txtBarkod.TextChanged += new System.EventHandler(this.txtBarkod_TextChanged);
            // 
            // BtnEkle
            // 
            this.BtnEkle.Enabled = false;
            this.BtnEkle.Location = new System.Drawing.Point(504, 11);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(149, 20);
            this.BtnEkle.TabIndex = 14;
            this.BtnEkle.Text = "YENİ ÜRÜN EKLE";
            this.BtnEkle.UseSelectable = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // TpRapor
            // 
            this.TpRapor.BackColor = System.Drawing.Color.White;
            this.TpRapor.Controls.Add(this.label1);
            this.TpRapor.Controls.Add(this.LblGider);
            this.TpRapor.Controls.Add(this.LblNet);
            this.TpRapor.Controls.Add(this.LblGelir);
            this.TpRapor.Controls.Add(this.metroLabel5);
            this.TpRapor.Controls.Add(this.metroLabel6);
            this.TpRapor.Controls.Add(this.metroLabel4);
            this.TpRapor.Controls.Add(this.dgwIslemler);
            this.TpRapor.Location = new System.Drawing.Point(4, 22);
            this.TpRapor.Name = "TpRapor";
            this.TpRapor.Padding = new System.Windows.Forms.Padding(3);
            this.TpRapor.Size = new System.Drawing.Size(1039, 338);
            this.TpRapor.TabIndex = 3;
            this.TpRapor.Text = "Rapor";
            // 
            // LblGider
            // 
            this.LblGider.AutoSize = true;
            this.LblGider.Location = new System.Drawing.Point(71, 43);
            this.LblGider.Name = "LblGider";
            this.LblGider.Size = new System.Drawing.Size(33, 19);
            this.LblGider.TabIndex = 1;
            this.LblGider.Text = "........";
            // 
            // LblNet
            // 
            this.LblNet.AutoSize = true;
            this.LblNet.Location = new System.Drawing.Point(71, 106);
            this.LblNet.Name = "LblNet";
            this.LblNet.Size = new System.Drawing.Size(33, 19);
            this.LblNet.TabIndex = 1;
            this.LblNet.Text = "........";
            // 
            // LblGelir
            // 
            this.LblGelir.AutoSize = true;
            this.LblGelir.Location = new System.Drawing.Point(71, 72);
            this.LblGelir.Name = "LblGelir";
            this.LblGelir.Size = new System.Drawing.Size(33, 19);
            this.LblGelir.TabIndex = 1;
            this.LblGelir.Text = "........";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 43);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(48, 19);
            this.metroLabel5.TabIndex = 1;
            this.metroLabel5.Text = "GİDER:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 106);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(36, 19);
            this.metroLabel6.TabIndex = 1;
            this.metroLabel6.Text = "KAR:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 72);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(45, 19);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "GELİR:";
            // 
            // dgwIslemler
            // 
            this.dgwIslemler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwIslemler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column18,
            this.Column19,
            this.Column17});
            this.dgwIslemler.Location = new System.Drawing.Point(170, 72);
            this.dgwIslemler.Name = "dgwIslemler";
            this.dgwIslemler.Size = new System.Drawing.Size(746, 208);
            this.dgwIslemler.TabIndex = 0;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "İşlem Id";
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.HeaderText = "İşlemi Yapan";
            this.Column14.Name = "Column14";
            // 
            // Column15
            // 
            this.Column15.HeaderText = "İşlem Tarihi";
            this.Column15.Name = "Column15";
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Ürün Adı";
            this.Column16.Name = "Column16";
            // 
            // Column18
            // 
            this.Column18.HeaderText = "Geliş Fiyat";
            this.Column18.Name = "Column18";
            // 
            // Column19
            // 
            this.Column19.HeaderText = "Satış Fiyat";
            this.Column19.Name = "Column19";
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Adet";
            this.Column17.Name = "Column17";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 503);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.TapControl);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.TapControl.ResumeLayout(false);
            this.TpAnaSayfa.ResumeLayout(false);
            this.TpAnaSayfa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStok)).EndInit();
            this.TpPersonelEkle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgwUrunler)).EndInit();
            this.TpAracCikis.ResumeLayout(false);
            this.TpAracCikis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.TpRapor.ResumeLayout(false);
            this.TpRapor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwIslemler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl TapControl;
        private System.Windows.Forms.TabPage TpAnaSayfa;
        private System.Windows.Forms.TabPage TpPersonelEkle;
        private MetroFramework.Controls.MetroButton BtnDosyaAc;
        private System.Windows.Forms.DataGridView DgwUrunler;
        private MetroFramework.Controls.MetroButton BtnStokKaydet;
        private System.Windows.Forms.TabPage TpAracCikis;
        private System.Windows.Forms.TabPage TpRapor;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView dgwStok;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox TxtBirimFyt;
        private System.Windows.Forms.TextBox TxtUrunAd;
        private MetroFramework.Controls.MetroButton BtnSil;
        private MetroFramework.Controls.MetroButton BtnGuncelle;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox txtBarkod;
        private MetroFramework.Controls.MetroButton BtnEkle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.TextBox txtStok;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnStokGuncelle;
        private System.Windows.Forms.TextBox txtGelisFiyat;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.DataGridView dgwIslemler;
        private MetroFramework.Controls.MetroLabel LblGelir;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private MetroFramework.Controls.MetroLabel LblGider;
        private MetroFramework.Controls.MetroLabel LblNet;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.Label label1;
    }
}