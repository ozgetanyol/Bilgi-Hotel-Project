using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public static class KullaniciGirisYetki
    {
        public static string GirisYapanAd { get; set; }
        public static string GirisYapanSoyad { get; set; }

        public static int GirisYapanYetki { get; set; }

        public static int KullaniciGirisSorgula(string KullaniciAd, string KullaniciParola)
        {
            SqlDataReader read = BilgiHotelHelperSQL.myExecuteReader("select k.KullaniciAd, k.KullaniciParola, p.PersonelAd,p.PersonelSoyad, y.YetkiGuvenlikKod from Kullanici as k join KullaniciPersonel as kp on k.KullaniciId=kp.KullaniciId join Yetkiler as y on kp.YetkiId=y.YetkiId join Personel as p on kp.PersonelId=p.PersonelId where k.KullaniciAd='" + KullaniciAd + "' and k.KullaniciParola = '" + KullaniciParola + "'", null, "txt");


            KullaniciEntity yenikullanici = new KullaniciEntity();
            YetkilerEntity yetkiler = new YetkilerEntity();
            PersonelEntity personel = new PersonelEntity();

            while (read.Read())
            {
                yenikullanici.KullaniciAd = read[0].ToString();
                yenikullanici.KullaniciParola = read[1].ToString();
                GirisYapanAd = read[2].ToString();
                GirisYapanSoyad = read[3].ToString();
                GirisYapanYetki = Convert.ToInt32(read[4]);

            }
            read.Close();
            int sonuc = 0;

            if (yenikullanici.KullaniciAd == KullaniciAd && yenikullanici.KullaniciParola == KullaniciParola)
            {
                sonuc = yetkiler.YetkiId;
            }
            else
            {
                GirisYapanYetki = 0;
            }
            return sonuc;
        }
    }
}

