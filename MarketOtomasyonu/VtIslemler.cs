using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MarketOtomasyonu
{
    class VtIslemler
    {

        public const string Baglanti = "Data Source=.;Initial Catalog=DbMarket; Integrated Security=True;";
        SqlCommand cmd;
        SqlDataReader reader;


        public SqlCommand CreateCommand()//sql ile bağlantıyı sağlayan fonksiyon
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = Baglanti;
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            return command;
        }

        // Prosedüre bağlanma işlemi hep tekrarlandığı için connection fonksiyonu yazarak çağırma işlemini gerçekleştirdik.
        public void Connection(string prc)//prosedüre bağlanma işlemi
        {
            cmd = CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = prc;
            if (cmd.Connection.State == ConnectionState.Closed) cmd.Connection.Open();
        }

        public SqlDataReader PrcGiris(String KulAdi, String Parola)//Kullanıcı adı veşifre kontrolü
        {
            Connection("PrcGiris");
            cmd.Parameters.AddWithValue("@KulAdi", KulAdi);
            cmd.Parameters.AddWithValue("@Parola", Parola);
            reader = cmd.ExecuteReader();
            return reader;
        }


        public SqlDataReader PrcListele()
        {
            try
            {
                Connection("PrcUrunListele");
                reader = cmd.ExecuteReader();
            }
            catch (Exception) { }
            return reader;
        }

       public void PrcUrunEkle(string barkod, string urunad, double fiyat)
       {
            Connection("PrcUrunEkle");
            cmd.Parameters.AddWithValue("@Barkod", barkod);
            cmd.Parameters.AddWithValue("@UrunAdi", urunad);
            cmd.Parameters.AddWithValue("@Fiyat", fiyat);
            cmd.ExecuteNonQuery();
       }

        //Markette bulunan ürünleri listelemek için.      
        public SqlDataAdapter PrcUrunListele()
        {
            SqlDataAdapter urunler = new SqlDataAdapter("Select * from TblUrunler", Baglanti);
            return urunler;
        }


        public void prcUrunUpdate(string barkod, string urunad, double fiyat)
        {
            
                Connection("UrunUpdate");
                cmd.Parameters.AddWithValue("@Barkod", barkod);
                cmd.Parameters.AddWithValue("@UrunAdi", urunad);
                cmd.Parameters.AddWithValue("@Fiyat", fiyat);
                cmd.ExecuteNonQuery();
            //    if (cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();           
        }


        public void PrcUrunSil(string barkod)
        {                      
                Connection("PrcUrunSil");
                cmd.Parameters.AddWithValue("@Barkod", barkod);//Yazdığımız ıdyi silmeye yarar. 
                cmd.ExecuteNonQuery();
                if (cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();                      
        }


        //TblUrunler2 tablosundaki ürünleri listemek için kullanılan metot
        public SqlDataReader PrcTblUrunler2_Select()
        {
            try
            {
                Connection("PrcTblUrunler_Select");
                reader = cmd.ExecuteReader();
            }
            catch (Exception) { }
            return reader;
        }

        //TblUrunler2 tablosuna insert işlemi yapabilmek için oluşturduğum metot
        public void PrcTblUrunler2_Insert(List<string>Bilgiler)
        {
            Connection("PrcTblUrunler2_Insert");
            cmd.Parameters.AddWithValue("@Barkod", Bilgiler[0].ToString());
            cmd.Parameters.AddWithValue("@UrunAdi", Bilgiler[1].ToString());
            cmd.Parameters.AddWithValue("@GelisFiyat", Convert.ToDouble(Bilgiler[2].ToString()));
            cmd.Parameters.AddWithValue("@SatisFiyat", Convert.ToDouble(Bilgiler[3].ToString()));
            cmd.Parameters.AddWithValue("@Stok", Convert.ToInt32(Bilgiler[4].ToString()));
            cmd.ExecuteNonQuery();

        }

        

        //faturadaki ürünleri veri tabanında stok ve diğer bilgilerinin güncelleme işlemi
       // public void PrcTblUrunler2_Update(string barkod, string urunad, double gelisfiyat, double satisfiyat, int stok)
      public void PrcTblUrunler2_Update(List<string>Bilgiler)
      {
            Connection("PrcTblUrunler2_Update");
            cmd.Parameters.AddWithValue("@Barkod", Bilgiler[0].ToString());
            cmd.Parameters.AddWithValue("@UrunAdi", Bilgiler[1].ToString());
            cmd.Parameters.AddWithValue("@GelisFiyat", Convert.ToDouble(Bilgiler[2].ToString()));
            cmd.Parameters.AddWithValue("@SatisFiyat", Convert.ToDouble(Bilgiler[3].ToString()));
            cmd.Parameters.AddWithValue("@Stok", Convert.ToInt32(Bilgiler[4].ToString()));
            cmd.ExecuteNonQuery();
      }



        public void PrcTblUrunler2_Update2(List<string> Bilgiler)
        {
            Connection("PrcTblUrunler2_Update2");
            cmd.Parameters.AddWithValue("@Barkod", Bilgiler[0].ToString());
            cmd.Parameters.AddWithValue("@UrunAdi", Bilgiler[1].ToString());
            cmd.Parameters.AddWithValue("@GelisFiyat", Convert.ToDouble(Bilgiler[2].ToString()));
            cmd.Parameters.AddWithValue("@SatisFiyat", Convert.ToDouble(Bilgiler[3].ToString()));
            cmd.Parameters.AddWithValue("@Stok", Convert.ToInt32(Bilgiler[4].ToString()));
            cmd.ExecuteNonQuery();
        }

        public void PrcTblIslemler_Insert(int KulId, DateTime tarih,int urunid, string barkod,int adet)
        {
            Connection("PrcTblIslemler_Insert");

           
            cmd.Parameters.AddWithValue("@KulId",KulId);
            cmd.Parameters.AddWithValue("@islemtarih",tarih);
            cmd.Parameters.AddWithValue("@urunid",urunid);
            cmd.Parameters.AddWithValue("@barkod",barkod);
            cmd.Parameters.AddWithValue("@adet", adet);
            cmd.ExecuteNonQuery();
        }

        public void PrcTblUrunler2_Delete(string barkod)
        {
            Connection("PrcTblUrunler2_Delete");
            cmd.Parameters.AddWithValue("@barkod", barkod);//Yazdığımız ıdyi silmeye yarar. 
            cmd.ExecuteNonQuery();
            if (cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();
        }


        public SqlDataReader PrcTblIslemler_Select()
        {
            try
            {
                Connection("PrcTblIslemler_Select");
                reader = cmd.ExecuteReader();
            }
            catch (Exception) { }
            return reader;
        }
    



    }
}
