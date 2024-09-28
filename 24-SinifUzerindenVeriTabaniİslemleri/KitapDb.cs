using Microsoft.AspNet.SignalR.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_SinifUzerindenVeriTabaniİslemleri
{

    
    public class KitapDb
    {
        public List<Kitap> kitaplar()
        {
            List<Kitap> ktp = new List<Kitap>();
            SqlCommand cmd = new SqlCommand("select * from Kitaplar");
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Kitap k= new Kitap();
                k.Id = Convert.ToInt16(dr[0].ToString());
                k.Ad = dr[1].ToString();
                k.Yazar = dr[2].ToString();

                ktp.Add(k);
            }
            return ktp;
        }

        public void KitapEkle(Kitap kt)
        {
            SqlCommand cmd = new SqlCommand("insert into Kitaplar (KitapAd,Yazar) values (@p1,@p2)");
            cmd.Parameters.AddWithValue("@p1", kt.Ad);
            cmd.Parameters.AddWithValue("@p2", kt.Yazar);
            cmd.ExecuteNonQuery();
            
        }
    }
}
