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
    public partial class FrmUrunEkle : MaterialForm
    {
        public FrmUrunEkle()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green100, TextShade.WHITE);

        }
        VtIslemler prc = new VtIslemler();
        SqlDataReader reader;
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            //string barkod, string urunad, string fiyat
            prc.PrcUrunEkle(txtBarkod.Text,TxtUrunAd.Text,Convert.ToDouble(TxtBirimFyt.Text));
            MessageBox.Show("Eklendi.");
            FnkListele();
        }

        void FnkListele()
        {
            SqlDataAdapter da = prc.PrcUrunListele();
            DataSet ds = new DataSet();
            da.Fill(ds, "TblKayitlar");
            DgwUrunler.DataSource = ds.Tables[0];
           
        }

        private void FrmUrunEkle_Load(object sender, EventArgs e)
        {
            FnkListele();          
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            Form1 yeni = new Form1();
            yeni.Show();
            this.Close();
        }

        void FnkUrunKontrol()
        {

        }


        private void txtBarkod_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
