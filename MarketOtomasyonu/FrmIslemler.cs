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
using System.IO;

using iTextSharp.text.pdf;
using iTextSharp.text;


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
            if (FrmGiris.KullaniciTip.ToString() == "kullanıcı") BtnGeri.Visible = false;
            //Application.Idle += new EventHandler(FnkBarkodYakala);
           
        }

        
        VtIslemler prc = new VtIslemler();
        SqlDataReader reader;
        double ToplamFiyat = 0;
        bool kontrol = false;
        int adet = 1;
        string port;
        List<string> Barkodlar = new List<string>();
        List<int> Adetler = new List<int>();
        List<int> UrunIdler = new List<int>();


        private void FrmIslemler_Load(object sender, EventArgs e)
        {
           
        }
       
      


        void FnkHesapla()
        {
            adet = Convert.ToInt32(txtAdet.Text); //üründen kaç adet aldığına bakıyoruz.        
            LblBarkod.Text = TxtBarkod.Text; //girilen barkodu yazdırma işlemi
            reader = prc.PrcTblUrunler2_Select();
            while(reader.Read())
            {
                if(reader[1].ToString()==TxtBarkod.Text)
                {
                    
                    if (Convert.ToInt32(reader[5].ToString()) > 0 && Convert.ToInt32(reader[5].ToString())-adet>0)
                    {
                        Barkodlar.Add(TxtBarkod.Text);
                        Adetler.Add(Convert.ToInt32(txtAdet.Text));
                        UrunIdler.Add(Convert.ToInt32(reader[0].ToString()));
                        kontrol = true;
                        LblUrun.Text = reader[2].ToString();//Ürün bigisini yazdırdım.
                        double fiyat = Convert.ToDouble(reader[4].ToString()) * adet;//adet*fiyat işlemi
                        ToplamFiyat = ToplamFiyat + fiyat;
                        LblAdFyt.Text = fiyat.ToString();
                        LblBirimFiyat.Text = reader[4].ToString();
                        dataGridView1.Rows.Add(TxtBarkod.Text, reader[2].ToString(), reader[4].ToString(), adet, fiyat);
                    }
                }
            }
        }

        private void TxtBarkod_TextChanged(object sender, EventArgs e)
        {
            kontrol = false;
            FnkHesapla();
            if(kontrol==false)
            {
             //   LblUrun.Text = "Okutulan Ürün Sisteme kayıtlı değil veya stokta tükenmiştir.";
                LblUrun.Text = "Okutulan ürün stokta bulunmamaktadır veya ürünün stoktaki miktarından fazla ürün istendi yapıldı.";
                LblToplamFiyat.Text = "0";
                LblBirimFiyat.Text = "0";
                LblAdFyt.Text = "0";
            }
            LblToplamFiyat.Text = ToplamFiyat.ToString();
            
            if(TxtBarkod.TextLength==13) TxtBarkod.SelectAll();

        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            BtnKullanici yeni = new BtnKullanici();
            yeni.Show();
            this.Close();
        }

        void Temizle()
        {
            ToplamFiyat = 0;
             kontrol = false;
             adet = 1;
            TxtBarkod.Text = "";
            LblUrun.Text =".........................";
            LblBarkod.Text = ".........................";
            LblBirimFiyat.Text = ".........................";
            LblAdFyt.Text = ".........................";
            LblToplamFiyat.Text = ".........................";
            txtAdet.Text = "1";
           // DgwHarcamalar.Rows.Clear();
            TxtBarkod.Focus();
            dataGridView1.Rows.Clear();
        }

        private void BtnFaturaKes_Click(object sender, EventArgs e)
        {
            pdfKaydet(dataGridView1);
            Temizle();
            FnkIslemler();
        }

        //stoktan adet düşme ve yapılan işlemi veri tabanına kaydetmek için
        void FnkIslemler()
        {
            for (int i = 0; i <Barkodlar.Count; i++)
            {              
               prc.PrcTblIslemler_Insert(FrmGiris.KulId,DateTime.Now,UrunIdler[i],Barkodlar[i],Adetler[i]);
            }

        }






        //fiş kesme işlemi
       void pdfKaydet(DataGridView veriTablosu)
        {
            string Tahoma = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Tahoma.TTF");
            BaseFont bf = BaseFont.CreateFont(Tahoma, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            PdfPTable pdfTablosu = new PdfPTable(veriTablosu.ColumnCount);
            pdfTablosu.DefaultCell.Padding = 3;
            pdfTablosu.WidthPercentage = 100;
            pdfTablosu.HorizontalAlignment = Element.ALIGN_LEFT;
            // pdfTablosu.DefaultCell.BorderWidth = 1;

            foreach (DataGridViewColumn sutun in veriTablosu.Columns)
            {
                PdfPCell pdfHucresi = new PdfPCell(new Phrase(sutun.HeaderText, new iTextSharp.text.Font(bf)));
                pdfTablosu.AddCell(pdfHucresi);
            }
            foreach (DataGridViewRow satir in veriTablosu.Rows)
            {
                foreach (DataGridViewCell cell in satir.Cells)
                {
                    if (!satir.IsNewRow)
                        pdfTablosu.AddCell(new Phrase(cell.Value.ToString(), new iTextSharp.text.Font(bf)));
                    // burada new Phare nesnesi kullanarak kod içeriğini yeniden yazdık ve font tanımlamasınıda yaptık.
                }
            }
            Random a = new Random();
            int sayi = a.Next(0,10000);
            SaveFileDialog dosyakaydet = new SaveFileDialog();
            dosyakaydet.FileName = "Fiş"+sayi.ToString();
            dosyakaydet.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
            dosyakaydet.Filter = "PDF Dosyası|*.pdf";
            if (dosyakaydet.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(dosyakaydet.FileName, FileMode.Create))
                {
                    DateTime bugun = DateTime.Now;
                  

                    Paragraph tarih = new Paragraph("Tarih: "+bugun.ToString()+"\n\n"+"Kasiyer: "+FrmGiris.KulAd+"\n\n");
                    Paragraph toplamfiyat = new Paragraph("Toplam Fiyat: "+LblToplamFiyat.Text+"TL");

                    Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(tarih);
                    pdfDoc.Add(pdfTablosu);
                    pdfDoc.Add(toplamfiyat);

                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Fatura Kesildi.");
                    //MessageBox.Show("PDF dosyası başarıyla oluşturuldu!\n" + "Dosya Konumu: " + dosyakaydet.FileName, "İşlem Tamam");
                }
            }
        }

        private void TxtBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            
        }





    }
}
