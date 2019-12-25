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
        bool kontrol = false;
        void fnkTemizle()
        {
            txtBarkod.Text = "";
            TxtUrunAd.Text = "";
            TxtBirimFyt.Text = "";
            txtBarkod.Focus();
        }

        void butonKontrol()
        {
            if (kontrol == true)
            {
                BtnGuncelle.Enabled = true;
                BtnSil.Enabled = true;
            }
            else
            {
                BtnGuncelle.Enabled = false;
                BtnSil.Enabled = false;
            }
        }


        private void BtnEkle_Click(object sender, EventArgs e)
        {
            FnkUrunKontrol();
            if (kontrol)
            {
                MetroMessageBox.Show(this, "\n", "Ürün veri tabanında ekli", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                prc.PrcUrunEkle(txtBarkod.Text, TxtUrunAd.Text, Convert.ToDouble(TxtBirimFyt.Text));
                kontrol = false;
                fnkTemizle();
                butonKontrol();
                FnkListele();
            }                                               
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
            BtnKullanici yeni = new BtnKullanici();
            yeni.Show();
            this.Close();
        }

        void FnkUrunKontrol()
        {
            SqlDataReader reader = prc.PrcListele();
            while(reader.Read())
            {
               if(txtBarkod.Text==reader[1].ToString())
                {                    
                    TxtUrunAd.Text = reader[2].ToString();
                    TxtBirimFyt.Text = reader[3].ToString();
                    kontrol = true;
                    break;
                }
            }
        }
           
        private void txtBarkod_TextChanged(object sender, EventArgs e)
        {
            kontrol = false;           
            FnkUrunKontrol();
            butonKontrol();
            
            if (txtBarkod.TextLength == 13) txtBarkod.SelectAll();//dün gece ekledin unutmaaaaaaa
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            prc.prcUrunUpdate(txtBarkod.Text, TxtUrunAd.Text, Convert.ToDouble(TxtBirimFyt.Text));
            FnkListele();
            fnkTemizle();                       
        }       

        private void BtnSil_Click(object sender, EventArgs e)
        {
            prc.PrcUrunSil(txtBarkod.Text);
            FnkListele();
            fnkTemizle();
        }

        private void txtBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
