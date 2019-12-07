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
using System.Data;
using System.Data.SqlClient;

namespace MarketOtomasyonu
{
    public partial class FrmIslemler : MaterialForm
    {
        public FrmIslemler()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green100, TextShade.WHITE);
        }
        VtIslemler prc = new VtIslemler();
        SqlDataReader reader;
        double ToplamFiyat = 0;
        bool kontrol = false;
        int adet = 1;

        private void FrmIslemler_Load(object sender, EventArgs e)
        {

        }


        void FnkHesapla()
        {
            adet = Convert.ToInt32(txtAdet.Text); //girilen adet değerini aldık.
            
            LblBarkod.Text = TxtBarkod.Text; //girilen barkodu yazdırma işlemi
            reader = prc.PrcListele();
            while(reader.Read())
            {
                if(reader[1].ToString()==TxtBarkod.Text)
                {
                    kontrol = true;
                    LblUrun.Text = reader[2].ToString();//Ürün bigisini yazdırdım.
                    double fiyat = Convert.ToDouble(reader[3].ToString())*adet;//adet*fiyat işlemi

                    ToplamFiyat = ToplamFiyat + fiyat;
                    LblAdFyt.Text = fiyat.ToString();
                    LblBirimFiyat.Text = reader[3].ToString();


                    //ToplamFiyat = (ToplamFiyat + Convert.ToDouble(reader[3].ToString()))*adet;
                    //LblAdFyt.Text = (adet * Convert.ToDouble(reader[3].ToString())).ToString();
                   // LblBirimFiyat.Text = reader[3].ToString();//ürünün birim fiyatı
                    

                    //datagridwiew'e yazdırma işlemi
                    DgwHarcamalar.Rows.Add(TxtBarkod.Text,reader[2].ToString(),reader[3].ToString(),fiyat);


                }

            }
        }

        private void TxtBarkod_TextChanged(object sender, EventArgs e)
        {
            kontrol = false;
            FnkHesapla();
            if(kontrol==false)
            {
                LblUrun.Text = "Okutulan Ürün Bulunmamaktadır.";
                LblToplamFiyat.Text = "0";
                LblBirimFiyat.Text = "0";
                LblAdFyt.Text = "0";
            }
            LblToplamFiyat.Text = ToplamFiyat.ToString();
            
            if(TxtBarkod.TextLength==13) TxtBarkod.SelectAll();

        }
    }
}
