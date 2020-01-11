namespace MarketOtomasyonu
{
    partial class BtnKullanici
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
            this.BtnUrunIslem = new MetroFramework.Controls.MetroButton();
            this.BtnHesapla = new MetroFramework.Controls.MetroButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btncikis = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // BtnUrunIslem
            // 
            this.BtnUrunIslem.Location = new System.Drawing.Point(141, 87);
            this.BtnUrunIslem.Name = "BtnUrunIslem";
            this.BtnUrunIslem.Size = new System.Drawing.Size(128, 39);
            this.BtnUrunIslem.TabIndex = 1;
            this.BtnUrunIslem.Text = "ÜRÜN İŞLEMLERİ";
            this.BtnUrunIslem.UseSelectable = true;
            this.BtnUrunIslem.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // BtnHesapla
            // 
            this.BtnHesapla.Location = new System.Drawing.Point(141, 151);
            this.BtnHesapla.Name = "BtnHesapla";
            this.BtnHesapla.Size = new System.Drawing.Size(128, 43);
            this.BtnHesapla.TabIndex = 2;
            this.BtnHesapla.Text = "HESAPLA";
            this.BtnHesapla.UseSelectable = true;
            this.BtnHesapla.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(396, 68);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(10, 10);
            this.textBox1.TabIndex = 0;
            // 
            // btncikis
            // 
            this.btncikis.Location = new System.Drawing.Point(359, 82);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(57, 33);
            this.btncikis.TabIndex = 3;
            this.btncikis.Text = "ÇIKIŞ";
            this.btncikis.UseSelectable = true;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // BtnKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 277);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnHesapla);
            this.Controls.Add(this.BtnUrunIslem);
            this.Name = "BtnKullanici";
            this.Text = "ANA SAYFA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton BtnUrunIslem;
        private MetroFramework.Controls.MetroButton BtnHesapla;
        private System.Windows.Forms.TextBox textBox1;
        private MetroFramework.Controls.MetroButton btncikis;
    }
}

