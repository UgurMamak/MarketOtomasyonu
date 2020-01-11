using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using MetroFramework.Controls;
using MetroFramework;
using Microsoft.Office.Interop.Excel;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace MarketOtomasyonu
{
    public partial class Form2 : MaterialForm
    {
        public Form2()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green100, TextShade.WHITE);
        }

        SqlDataReader reader;
        VtIslemler islem = new VtIslemler();
        bool urunvarmi = false;
        bool kontrol = false;
        List<string> bilgiler = new List<string>();
        bool kontrol2 = false;

        


        // excell verisini okuma işlemi
        public static System.Data.DataTable Import(String path)
        {
            ApplicationClass app = new ApplicationClass();
            Workbook workBook = app.Workbooks.Open(path, 0, true, 4, "", "", true, XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            Worksheet workSheet = (Worksheet)workBook.ActiveSheet;
            int index = 0;
            object rowIndex = 2;
            System.Data.DataTable dt = new System.Data.DataTable();

            dt.Columns.Add("Barkod");
            dt.Columns.Add("Ürün Bilgisi");
            dt.Columns.Add("Geliş Birim Fiyat");
            dt.Columns.Add("satış Birim Fiyat");
            dt.Columns.Add("Ürün Adet");
            dt.Columns.Add("GF x Adet");
            System.Data.DataRow row;
            while (((Microsoft.Office.Interop.Excel.Range)workSheet.Cells[rowIndex, 1]).Value2 != null)
            {
                rowIndex = 2 + index;
                row = dt.NewRow();
                row[0] = Convert.ToString(((Microsoft.Office.Interop.Excel.Range)workSheet.Cells[rowIndex, 1]).Value2);
                row[1] = Convert.ToString(((Microsoft.Office.Interop.Excel.Range)workSheet.Cells[rowIndex, 2]).Value2);
                row[2] = Convert.ToString(((Microsoft.Office.Interop.Excel.Range)workSheet.Cells[rowIndex, 3]).Value2);
                row[3] = Convert.ToString(((Microsoft.Office.Interop.Excel.Range)workSheet.Cells[rowIndex, 4]).Value2);
                row[4] = Convert.ToString(((Microsoft.Office.Interop.Excel.Range)workSheet.Cells[rowIndex, 5]).Value2);
                row[5] = Convert.ToString(((Microsoft.Office.Interop.Excel.Range)workSheet.Cells[rowIndex, 6]).Value2);

                index++;
                dt.Rows.Add(row);
            }
            app.Workbooks.Close();
            return dt;
        }    

        private void Form2_Load(object sender, EventArgs e)
        {
            FnkStokList();
            FnkListele();
            FnkIslemlerList(DateTime.Today.ToString("dd/MM/yyyy"));
            label1.Text = DateTime.Today.ToString("dd/MM/yyyy"); 
        }      

        //tablodaki verileri DB ye kaydetmek için oluşturduğum metot
        void FnkUrunKaydet()
        {           
            int sayac = 0;
            int giris = 0;
            foreach (DataGridViewRow satir in DgwUrunler.Rows)
            {
                kontrol = false;
                sayac++;
                urunvarmi = false;
                foreach (DataGridViewCell cell in satir.Cells)
                {                                         
                    if (!satir.IsNewRow  && DgwUrunler.RowCount>sayac)
                    {
                        kontrol = true;                        
                        reader = islem.PrcTblUrunler2_Select();
                        while (reader.Read())
                        {
                            if(cell.Value.ToString()==reader[1].ToString())//excell tablosundaki ürün vt de var mı kontrol edilir.
                            {
                                urunvarmi = true;
                                break;
                            }  
                        }
                        bilgiler.Add(cell.Value.ToString());//ürün bilgileri listeye kaydedilir.     
                    }                       
                }               
                    if (urunvarmi && kontrol==true)
                    {                        
                        //update yapan prosedür burada kullanılacak.
                        //listBox2.Items.Add(cell.Value.ToString());
                        islem.PrcTblUrunler2_Update(bilgiler);                 
                        bilgiler.Clear();
                    }

                    //veri tabanında olmayan ürünlerin bilgilerini veri tabanında kaydetmek için
                    if (!urunvarmi && kontrol==true)
                    {                      
                        //insert yapan prosedür burada olacak.
                        // listBox3.Items.Add(cell.Value.ToString());
                        islem.PrcTblUrunler2_Insert(bilgiler);
                        bilgiler.Clear();
                    }                
            }
        }

       

        private void BtnDosyaAc_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Excel Dosyası |*.xlsx";

            if (file.ShowDialog() == DialogResult.OK)
            {
                System.Data.DataTable dt = Import(file.FileName);
                DgwUrunler.DataSource = dt;//excellede okunan verinin datagridviewe ekleme işlemi
                BtnStokKaydet.Enabled = true;
            }
        }

        private void BtnStokKaydet_Click_1(object sender, EventArgs e)
        {
            FnkUrunKaydet();
            MessageBox.Show("Ürünler Güncellendi");
            DgwUrunler.DataSource = null;
            BtnStokKaydet.Enabled = false;
            FnkStokList();
            FnkListele();

        }

        void FnkStokList()
        {
            dgwStok.Rows.Clear();
            reader = islem.PrcTblUrunler2_Select();
            while(reader.Read())
            {
                dgwStok.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString());
            }           
        }

        void FnkListele()
        {
            metroGrid1.Rows.Clear();
            reader = islem.PrcTblUrunler2_Select();
            while (reader.Read())
            {
                metroGrid1.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString());
            }
        }

        void fnkTemizle()
        {
            txtBarkod.Text = "";
            TxtUrunAd.Text = "";
            TxtBirimFyt.Text = "";
            txtStok.Text = "";
            txtBarkod.Focus();
        }
        void butonKontrol()
        {
            if (kontrol2 == true)
            {
                BtnGuncelle.Enabled = true;
                BtnSil.Enabled = true;
                BtnEkle.Enabled = true;
                btnStokGuncelle.Enabled = true;
            }
            else
            {
                BtnGuncelle.Enabled = false;
                BtnSil.Enabled = false;
                BtnEkle.Enabled = true;
                btnStokGuncelle.Enabled =false;
            }
        }


        void FnkUrunKontrol()
        {

            SqlDataReader reader = islem.PrcTblUrunler2_Select();
            while (reader.Read())
            {
                if (txtBarkod.Text == reader[1].ToString())
                {
                    TxtUrunAd.Text = reader[2].ToString();
                    txtGelisFiyat.Text = reader[3].ToString();
                    TxtBirimFyt.Text = reader[4].ToString();
                    txtStok.Text = reader[5].ToString();
                    kontrol2 = true;
                    break;
                }
                else
                {
                    TxtUrunAd.Text = "";
                    txtGelisFiyat.Text = "";
                    TxtBirimFyt.Text = "";
                    txtStok.Text = "";
                }
            }

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if (txtBarkod.Text == "" || TxtBirimFyt.Text == "" || TxtUrunAd.Text == "" || txtStok.Text=="" || txtGelisFiyat.Text=="")
            { MetroMessageBox.Show(this, "\n", "Boş alan bırakmayınız", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                if (kontrol2)
                {
                    MetroMessageBox.Show(this, "\n", "Ürün veri tabanında ekli", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                   
                    bilgiler.Add(txtBarkod.Text);
                    bilgiler.Add(TxtUrunAd.Text);
                    bilgiler.Add(txtGelisFiyat.Text);
                    bilgiler.Add(TxtBirimFyt.Text);
                    bilgiler.Add(txtStok.Text);
                    islem.PrcTblUrunler2_Insert(bilgiler);
                    kontrol2 = false;
                    bilgiler.Clear();
                    fnkTemizle();
                    butonKontrol();
                    FnkListele();
                    dgwStok.Rows.Clear();
                    FnkStokList();
                }
            }
        }

        private void txtBarkod_TextChanged(object sender, EventArgs e)
        {
            kontrol2 = false;
            FnkUrunKontrol();
            butonKontrol();


            if (txtBarkod.TextLength == 13) txtBarkod.SelectAll();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
           islem.PrcTblUrunler2_Delete(txtBarkod.Text);
            FnkListele();
            fnkTemizle();
            dgwStok.Rows.Clear();
            FnkStokList();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            bilgiler.Add(txtBarkod.Text);
            bilgiler.Add(TxtUrunAd.Text);
            bilgiler.Add(txtGelisFiyat.Text);
            bilgiler.Add(TxtBirimFyt.Text);
            bilgiler.Add(txtStok.Text);
            islem.PrcTblUrunler2_Update(bilgiler);
            FnkListele();
            fnkTemizle();
            bilgiler.Clear();
            dgwStok.Rows.Clear();
            FnkStokList();
        }

        private void btnStokGuncelle_Click(object sender, EventArgs e)
        {
            bilgiler.Add(txtBarkod.Text);
            bilgiler.Add(TxtUrunAd.Text);
            bilgiler.Add(txtGelisFiyat.Text);
            bilgiler.Add(TxtBirimFyt.Text);
            bilgiler.Add(txtStok.Text);
            islem.PrcTblUrunler2_Update2(bilgiler);
            FnkListele();
            fnkTemizle();
            bilgiler.Clear();
            dgwStok.Rows.Clear();
            FnkStokList();
        }

        double gelir = 0;
        double gider = 0;
        void FnkIslemlerList(string tarih)
        {
            dgwIslemler.Rows.Clear();
            reader = islem.PrcTblIslemler_Select();
            while(reader.Read())
            {
                DateTime dbtarih =Convert.ToDateTime(reader[2].ToString());
                if (tarih == dbtarih.ToString("dd/MM/yyyy"))
                {

                    //4 geliş
                    //5 satış
                    gider = gider + Convert.ToDouble(reader[4].ToString());
                    gelir = gelir + Convert.ToDouble(reader[5].ToString());
                    dgwIslemler.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString());
                }
            }
            FnkGelirHesapla();
        }

        
        void FnkGelirHesapla()
        {
            LblGelir.Text = gelir.ToString();
            LblGider.Text = gider.ToString();
            LblNet.Text = (gelir - gider).ToString();
        }

       
    }
}
