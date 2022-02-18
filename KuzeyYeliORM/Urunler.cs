using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using KuzeyYeliEntity;

namespace KuzeyYeliORM
{
    public class Urunler
    {
        public static DataTable listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select*from Urunler",tools.Baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static bool Ekle(Urun U)
        {
            SqlCommand komut = new SqlCommand("UrunEkle", tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@ad",U.UrunAdi );
            komut.Parameters.AddWithValue("@fiyat", U.Fiyat);
            komut.Parameters.AddWithValue("@stok", U.Stok);
            komut.Parameters.AddWithValue("@tedarikciID", U.TedarikciID);
            komut.Parameters.AddWithValue("@kategoriID", U.KategoriID);
            tools.Baglanti.Open();
            int sonuc=komut.ExecuteNonQuery();
            tools.Baglanti.Close();
            if (sonuc>0)
            {
                return true;
            }
            else
            {
                return false;
            }

            return true;
        }
        //urunler tablosu için select insert update delete işlemi yapar
    }
}
