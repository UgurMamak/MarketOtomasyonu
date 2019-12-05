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
            this.BtnEkle = new MetroFramework.Controls.MetroButton();
            this.TxtBarkod = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtUrunAdi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtFiyat = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(112, 212);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(213, 37);
            this.BtnEkle.TabIndex = 3;
            this.BtnEkle.Text = "EKLE";
            this.BtnEkle.UseSelectable = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // TxtBarkod
            // 
            this.TxtBarkod.Depth = 0;
            this.TxtBarkod.Hint = "";
            this.TxtBarkod.Location = new System.Drawing.Point(112, 93);
            this.TxtBarkod.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtBarkod.Name = "TxtBarkod";
            this.TxtBarkod.PasswordChar = '\0';
            this.TxtBarkod.SelectedText = "";
            this.TxtBarkod.SelectionLength = 0;
            this.TxtBarkod.SelectionStart = 0;
            this.TxtBarkod.Size = new System.Drawing.Size(213, 23);
            this.TxtBarkod.TabIndex = 0;
            this.TxtBarkod.UseSystemPasswordChar = false;
            // 
            // TxtUrunAdi
            // 
            this.TxtUrunAdi.Depth = 0;
            this.TxtUrunAdi.Hint = "";
            this.TxtUrunAdi.Location = new System.Drawing.Point(112, 129);
            this.TxtUrunAdi.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtUrunAdi.Name = "TxtUrunAdi";
            this.TxtUrunAdi.PasswordChar = '\0';
            this.TxtUrunAdi.SelectedText = "";
            this.TxtUrunAdi.SelectionLength = 0;
            this.TxtUrunAdi.SelectionStart = 0;
            this.TxtUrunAdi.Size = new System.Drawing.Size(213, 23);
            this.TxtUrunAdi.TabIndex = 1;
            this.TxtUrunAdi.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 97);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(56, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Barkod";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 133);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(66, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Ürün Adı";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 165);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(41, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Fiyat";
            // 
            // TxtFiyat
            // 
            this.TxtFiyat.Depth = 0;
            this.TxtFiyat.Hint = "";
            this.TxtFiyat.Location = new System.Drawing.Point(112, 165);
            this.TxtFiyat.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtFiyat.Name = "TxtFiyat";
            this.TxtFiyat.PasswordChar = '\0';
            this.TxtFiyat.SelectedText = "";
            this.TxtFiyat.SelectionLength = 0;
            this.TxtFiyat.SelectionStart = 0;
            this.TxtFiyat.Size = new System.Drawing.Size(213, 23);
            this.TxtFiyat.TabIndex = 2;
            this.TxtFiyat.UseSystemPasswordChar = false;
            // 
            // FrmUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 365);
            this.Controls.Add(this.TxtFiyat);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.TxtUrunAdi);
            this.Controls.Add(this.TxtBarkod);
            this.Controls.Add(this.BtnEkle);
            this.Name = "FrmUrunEkle";
            this.Text = "ÜRÜN EKLE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnEkle;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtBarkod;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtUrunAdi;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtFiyat;
    }
}