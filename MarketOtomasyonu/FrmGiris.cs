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
using System.Data.Sql;
using System.Data.SqlClient;

namespace MarketOtomasyonu
{
    public partial class FrmGiris : MaterialForm
    {
        public FrmGiris()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green100, TextShade.WHITE);

        }
        VtIslemler prc = new VtIslemler();
        SqlDataReader reader;
        public static string KullaniciTip,KulAd;
        public static int KulId;
        bool kontrol = false;

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            reader = prc.PrcGiris(TxtKulad.Text, TxtParola.Text);
            while (reader.Read())
            {
                if (reader[0].ToString() == "1")
                {
                    kontrol = true;
                    KullaniciTip = reader[1].ToString();
                    KulAd = reader[2].ToString();
                    KulId = Convert.ToInt32(reader[3].ToString());
                    if(KullaniciTip=="kullanıcı")
                    {
                        FrmIslemler islem = new FrmIslemler();
                        islem.Show();
                        this.Hide();
                    }
                    else
                    {
                        BtnKullanici yeni = new BtnKullanici();
                        yeni.Show();
                        this.Hide();
                    }                                        
                    break;              
                }
            }
            if (!kontrol)
            {
                MetroMessageBox.Show(this, "\n", "Kullanıcı Adı veya Şifre Hatalı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
      
        }
    }
}
