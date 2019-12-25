using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using MetroFramework.Controls;
using MetroFramework;

namespace MarketOtomasyonu
{
    public partial class BtnKullanici : MaterialForm
    {
        public BtnKullanici()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green100, TextShade.WHITE);
           

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            FrmUrunEkle frm = new FrmUrunEkle();
            frm.Show();
            this.Hide();
            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            FrmIslemler frm = new FrmIslemler();
            frm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //if (FrmGiris.KullaniciTip.ToString() == "kullanıcı") BtnUrunIslem.Visible = false;
        }
    }
}
