namespace MarketOtomasyonu
{
    partial class FrmGiris
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtKulad = new System.Windows.Forms.TextBox();
            this.TxtParola = new System.Windows.Forms.TextBox();
            this.BtnGiris = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(58, 122);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(92, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Kullanıcı Adı";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(58, 167);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(52, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Parola";
            // 
            // TxtKulad
            // 
            this.TxtKulad.Location = new System.Drawing.Point(171, 123);
            this.TxtKulad.Name = "TxtKulad";
            this.TxtKulad.Size = new System.Drawing.Size(100, 20);
            this.TxtKulad.TabIndex = 0;
            // 
            // TxtParola
            // 
            this.TxtParola.Location = new System.Drawing.Point(171, 166);
            this.TxtParola.Name = "TxtParola";
            this.TxtParola.Size = new System.Drawing.Size(100, 20);
            this.TxtParola.TabIndex = 1;
            this.TxtParola.UseSystemPasswordChar = true;
            // 
            // BtnGiris
            // 
            this.BtnGiris.AutoSize = true;
            this.BtnGiris.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnGiris.Depth = 0;
            this.BtnGiris.Location = new System.Drawing.Point(183, 195);
            this.BtnGiris.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnGiris.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Primary = false;
            this.BtnGiris.Size = new System.Drawing.Size(76, 36);
            this.BtnGiris.TabIndex = 2;
            this.BtnGiris.Text = "Giris Yap";
            this.BtnGiris.UseVisualStyleBackColor = true;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 294);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.TxtParola);
            this.Controls.Add(this.TxtKulad);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "FrmGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.TextBox TxtKulad;
        private System.Windows.Forms.TextBox TxtParola;
        private MaterialSkin.Controls.MaterialFlatButton BtnGiris;
    }
}