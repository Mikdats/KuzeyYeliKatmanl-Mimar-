using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeliORM
{
    public class Kategoriler
    {
        public static DataTable listele()
        {
            SqlDataAdapter adp =new SqlDataAdapter("select*from Kategoriler", tools.Baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;

        }
        
        //kategori tablosu için select insert update delete işlemi yapar
    }
}
