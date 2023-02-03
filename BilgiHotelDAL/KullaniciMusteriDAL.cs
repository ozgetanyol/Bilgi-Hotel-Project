using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class KullaniciMusteriDAL
    {
        #region CRUD Operations
        //ID ye göre Kullanici Musteri Getir.(select with ID)
        public KullaniciMusteriEntity KullaniciMusteriGetir(int KullaniciId, int MusteriId, int YetkiId)
        {
            SqlParameter[] KullaniciMusteriParametreleri =
            {
                new SqlParameter {

                    ParameterName="KullaniciId",
                    Value=KullaniciId

                },
                 new SqlParameter {

                    ParameterName="MusteriId",
                    Value=MusteriId

                },
                  new SqlParameter {

                    ParameterName="YetkiId",
                    Value=YetkiId

                },
            };

            SqlDataReader KullaniciMusteriRdr = BilgiHotelHelperSQL.myExecuteReader("sp_KullaniciMusteriGetir", KullaniciMusteriParametreleri, "sp");

            KullaniciMusteriEntity myKullaniciMusteri = null;
            while (KullaniciMusteriRdr.Read())
            {
                myKullaniciMusteri.KullaniciId = Convert.ToInt32(KullaniciMusteriRdr["KullaniciId"]);
                myKullaniciMusteri.MusteriId = Convert.ToInt32(KullaniciMusteriRdr["MusteriId"]);
                myKullaniciMusteri.YetkiId = Convert.ToInt32(KullaniciMusteriRdr["YetkiId"]);


            }
            return myKullaniciMusteri;

        }
        //Tüm Verileri Getir.(All)
        public KullaniciMusteriEntity sp_KullaniciMusteriListesiAll(int KullaniciId, int MusteriId, int YetkiId)
        {

            SqlDataReader KullaniciMusteriRdr = BilgiHotelHelperSQL.myExecuteReader("sp_KullaniciMusteriListesiAll", null, "sp");

            KullaniciMusteriEntity myKullaniciMusteri = null;
            while (KullaniciMusteriRdr.Read())
            {
                myKullaniciMusteri.KullaniciId = Convert.ToInt32(KullaniciMusteriRdr["KullaniciId"]);
                myKullaniciMusteri.MusteriId = Convert.ToInt32(KullaniciMusteriRdr["MusteriId"]);
                myKullaniciMusteri.YetkiId = Convert.ToInt32(KullaniciMusteriRdr["YetkiId"]);


            }
            return myKullaniciMusteri;

        }
        //Yeni Kullanici Musteri Verisi Gir.(insert)
        public int InsertKullaniciMusteri(KullaniciMusteriEntity EklenecekKullaniciMusteri)

        {
            SqlParameter[] KullaniciMusteriParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "KullaniciId",
                    Value = EklenecekKullaniciMusteri.KullaniciId
                },
                new SqlParameter
                {
                    ParameterName = "MusteriId",
                    Value = EklenecekKullaniciMusteri.MusteriId
                },
                 new SqlParameter {

                    ParameterName="YetkiId",
                    Value=EklenecekKullaniciMusteri.YetkiId

                },


            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_InsertKullaniciMusteri", KullaniciMusteriParametreleri, "sp");

            return etkilenenSatir;


        }
        #endregion
    }
}
