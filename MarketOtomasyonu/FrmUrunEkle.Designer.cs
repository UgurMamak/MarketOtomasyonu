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
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtUrunAd = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtBirimFyt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(117, 224);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(171, 50);
            this.BtnEkle.TabIndex = 0;
            this.BtnEkle.Text = "EKLE";
            this.BtnEkle.UseSelectable = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(117, 96);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(171, 20);
            this.txtBarkod.TabIndex = 1;
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
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Barkod";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 140);
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
            this.materialLabel3.Location = new System.Drawing.Point(12, 184);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(80, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Birim Fiyat";
            // 
            // TxtUrunAd
            // 
            this.TxtUrunAd.Depth = 0;
            this.TxtUrunAd.Hint = "";
            this.TxtUrunAd.Location = new System.Drawing.Point(117, 140);
            this.TxtUrunAd.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtUrunAd.Name = "TxtUrunAd";
            this.TxtUrunAd.PasswordChar = '\0';
            this.TxtUrunAd.SelectedText = "";
            this.TxtUrunAd.SelectionLength = 0;
            this.TxtUrunAd.SelectionStart = 0;
            this.TxtUrunAd.Size = new System.Drawing.Size(171, 23);
            this.TxtUrunAd.TabIndex = 5;
            this.TxtUrunAd.UseSystemPasswordChar = false;
            // 
            // TxtBirimFyt
            // 
            this.TxtBirimFyt.Depth = 0;
            this.TxtBirimFyt.Hint = "";
            this.TxtBirimFyt.Location = new System.Drawing.Point(117, 184);
            this.TxtBirimFyt.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtBirimFyt.Name = "TxtBirimFyt";
            this.TxtBirimFyt.PasswordChar = '\0';
            this.TxtBirimFyt.SelectedText = "";
            this.TxtBirimFyt.SelectionLength = 0;
            this.TxtBirimFyt.SelectionStart = 0;
            this.TxtBirimFyt.Size = new System.Drawing.Size(171, 23);
            this.TxtBirimFyt.TabIndex = 6;
            this.TxtBirimFyt.UseSystemPasswordChar = false;
            // 
            // FrmUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtBirimFyt);
            this.Controls.Add(this.TxtUrunAd);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.BtnEkle);
            this.Name = "FrmUrunEkle";
            this.Text = "FrmUrunEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnEkle;
        private System.Windows.Forms.TextBox txtBarkod;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtUrunAd;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtBirimFyt;
    }
}