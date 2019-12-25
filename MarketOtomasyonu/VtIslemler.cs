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




    }
}
