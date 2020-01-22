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
            this.components = new System.ComponentModel.Container();
            this.TxtBarkod = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.LblBarkod = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.LblUrun = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.LblToplamFiyat = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.LblBirimFiyat = new MaterialSkin.Controls.MaterialLabel();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.LblAdFyt = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.BtnFaturaKes = new MaterialSkin.Controls.MaterialFlatButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Barkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirimFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunadet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FiyatAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnGeri = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCikisYap = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtBarkod
            // 
            this.TxtBarkod.Location = new System.Drawing.Point(21, 104);
            this.TxtBarkod.Name = "TxtBarkod";
            this.TxtBarkod.Size = new System.Drawing.Size(214, 20);
            this.TxtBarkod.TabIndex = 0;
            this.TxtBarkod.TextChanged += new System.EventHandler(this.TxtBarkod_TextChanged);
            this.TxtBarkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBarkod_KeyPress);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(17, 151);
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
            this.LblBarkod.Location = new System.Drawing.Point(126, 151);
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
            this.materialLabel3.Location = new System.Drawing.Point(17, 198);
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
            this.LblUrun.Location = new System.Drawing.Point(126, 198);
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
            this.materialLabel5.Location = new System.Drawing.Point(17, 338);
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
            this.LblToplamFiyat.Location = new System.Drawing.Point(126, 338);
            this.LblToplamFiyat.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblToplamFiyat.Name = "LblToplamFiyat";
            this.LblToplamFiyat.Size = new System.Drawing.Size(109, 19);
            this.LblToplamFiyat.TabIndex = 6;
            this.LblToplamFiyat.Text = ".........................";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(17, 250);
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
            this.LblBirimFiyat.Location = new System.Drawing.Point(126, 250);
            this.LblBirimFiyat.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblBirimFiyat.Name = "LblBirimFiyat";
            this.LblBirimFiyat.Size = new System.Drawing.Size(109, 19);
            this.LblBirimFiyat.TabIndex = 9;
            this.LblBirimFiyat.Text = ".........................";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(63, 78);
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
            this.materialLabel4.Location = new System.Drawing.Point(17, 295);
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
            this.LblAdFyt.Location = new System.Drawing.Point(126, 295);
            this.LblAdFyt.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblAdFyt.Name = "LblAdFyt";
            this.LblAdFyt.Size = new System.Drawing.Size(109, 19);
            this.LblAdFyt.TabIndex = 12;
            this.LblAdFyt.Text = ".........................";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(17, 79);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(40, 19);
            this.materialLabel6.TabIndex = 13;
            this.materialLabel6.Text = "Adet";
            // 
            // serialPort1
            // 
            this.serialPort1.ReceivedBytesThreshold = 10;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // BtnFaturaKes
            // 
            this.BtnFaturaKes.AutoSize = true;
            this.BtnFaturaKes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnFaturaKes.Depth = 0;
            this.BtnFaturaKes.Location = new System.Drawing.Point(130, 370);
            this.BtnFaturaKes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnFaturaKes.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnFaturaKes.Name = "BtnFaturaKes";
            this.BtnFaturaKes.Primary = false;
            this.BtnFaturaKes.Size = new System.Drawing.Size(92, 36);
            this.BtnFaturaKes.TabIndex = 16;
            this.BtnFaturaKes.Text = "Fatura Kes";
            this.BtnFaturaKes.UseVisualStyleBackColor = true;
            this.BtnFaturaKes.Click += new System.EventHandler(this.BtnFaturaKes_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Barkod,
            this.UrunAd,
            this.BirimFiyat,
            this.urunadet,
            this.FiyatAdet});
            this.dataGridView1.Location = new System.Drawing.Point(350, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(551, 134);
            this.dataGridView1.TabIndex = 17;
            // 
            // Barkod
            // 
            this.Barkod.HeaderText = "Barkod";
            this.Barkod.Name = "Barkod";
            // 
            // UrunAd
            // 
            this.UrunAd.HeaderText = "Ürün Adı";
            this.UrunAd.Name = "UrunAd";
            // 
            // BirimFiyat
            // 
            this.BirimFiyat.HeaderText = "Birim Fiyat";
            this.BirimFiyat.Name = "BirimFiyat";
            // 
            // urunadet
            // 
            this.urunadet.HeaderText = "Adet";
            this.urunadet.Name = "urunadet";
            // 
            // FiyatAdet
            // 
            this.FiyatAdet.HeaderText = "FiyatXAdet";
            this.FiyatAdet.Name = "FiyatAdet";
            // 
            // BtnGeri
            // 
            this.BtnGeri.Depth = 0;
            this.BtnGeri.Location = new System.Drawing.Point(0, 25);
            this.BtnGeri.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Primary = true;
            this.BtnGeri.Size = new System.Drawing.Size(157, 39);
            this.BtnGeri.TabIndex = 18;
            this.BtnGeri.Text = "Ana sayfaya dön";
            this.BtnGeri.UseVisualStyleBackColor = true;
            this.BtnGeri.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.Depth = 0;
            this.btnCikisYap.Location = new System.Drawing.Point(838, 41);
            this.btnCikisYap.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.Primary = true;
            this.btnCikisYap.Size = new System.Drawing.Size(75, 23);
            this.btnCikisYap.TabIndex = 19;
            this.btnCikisYap.Text = "Çıkış Yap";
            this.btnCikisYap.UseVisualStyleBackColor = true;
            this.btnCikisYap.Click += new System.EventHandler(this.btnCikisYap_Click);
            // 
            // FrmIslemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 460);
            this.Controls.Add(this.btnCikisYap);
            this.Controls.Add(this.BtnGeri);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnFaturaKes);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.LblAdFyt);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.LblBirimFiyat);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.LblToplamFiyat);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.LblUrun);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.LblBarkod);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.TxtBarkod);
            this.Name = "FrmIslemler";
            this.Load += new System.EventHandler(this.FrmIslemler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel LblBirimFiyat;
        private System.Windows.Forms.TextBox txtAdet;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel LblAdFyt;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.IO.Ports.SerialPort serialPort1;
        private MaterialSkin.Controls.MaterialFlatButton BtnFaturaKes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirimFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadet;
        private System.Windows.Forms.DataGridViewTextBoxColumn FiyatAdet;
        private MaterialSkin.Controls.MaterialRaisedButton BtnGeri;
        private MaterialSkin.Controls.MaterialRaisedButton btnCikisYap;
    }
}