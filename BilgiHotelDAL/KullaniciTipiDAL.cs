using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class KullaniciTipiDAL
    {
        #region CRUD Operations
        //ID ye göre Kullanıcı Tipi Getir.(select with ID)
        public KullaniciTipiEntity getKullaniciTipiwithID(int KullaniciTipiId)
        {
            SqlParameter[] KullaniciTipiParametreleri =
            {
                new SqlParameter {

                    ParameterName="KullaniciTipiId",
                    Value=KullaniciTipiId

                },
            };

            SqlDataReader KullaniciTipiRdr = BilgiHotelHelperSQL.myExecuteReader("KullaniciTipiListesiwithID", KullaniciTipiParametreleri, "sp");

            KullaniciTipiEntity myKullaniciTipi = null;
            while (KullaniciTipiRdr.Read())
            {
                myKullaniciTipi.KullaniciTipiId = Convert.ToInt32(KullaniciTipiRdr["KullaniciTipiId"]);
                myKullaniciTipi.KullaniciTipiTanim = KullaniciTipiRdr["KullaniciTipiTanim"].ToString();
                myKullaniciTipi.KullaniciTipiAciklama = KullaniciTipiRdr["KullaniciTipiAciklama"].ToString();
                

            }
            return myKullaniciTipi;

        }
        //Tüm Kullanıcı tiplerini Getir
        public KullaniciTipiEntity getKullaniciTipiAll(int KullaniciTipiId)
        {

            SqlDataReader KullaniciTipiRdr = BilgiHotelHelperSQL.myExecuteReader("sp_KullaniciTipiListesiAll", null, "sp");

            KullaniciTipiEntity myKullaniciTipi = null;
            while (KullaniciTipiRdr.Read())
            {
                myKullaniciTipi.KullaniciTipiId = Convert.ToInt32(KullaniciTipiRdr["KullaniciTipiId"]);
                myKullaniciTipi.KullaniciTipiTanim = KullaniciTipiRdr["KullaniciTipiTanim"].ToString();
                myKullaniciTipi.KullaniciTipiAciklama = KullaniciTipiRdr["KullaniciTipiAciklama"].ToString();


            }
            return myKullaniciTipi;

        }
        //Yeni Kullanıcı Tipi Verisi Gir.(insert)
        public int İnsertKullaniciTipi(KullaniciTipiEntity EklenecekKullaniciTipi)

        {
            SqlParameter[] KullaniciTipiParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "KullaniciTipiId",
                    Value = EklenecekKullaniciTipi.KullaniciTipiId
                },
                new SqlParameter
                {
                    ParameterName = "KullaniciTipiTanim",
                    Value = EklenecekKullaniciTipi.KullaniciTipiTanim
                },
                new SqlParameter
                {
                    ParameterName = "KullaniciTipiAciklama",
                    Value = EklenecekKullaniciTipi.KullaniciTipiAciklama
                },
                 
            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_İnsertKullaniciTipi", KullaniciTipiParametreleri, "sp");

            return etkilenenSatir;


        }
        //Var olan Kullanıcı Tipi verisini ID sine göre bul ve değiştir. (update)
        public int UpdateKullaniciTipi(KullaniciTipiEntity DüzenlenecekKullaniciTipi)

        {
            SqlParameter[] KullaniciTipiParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "KullaniciTipiId",
                    Value = DüzenlenecekKullaniciTipi.KullaniciTipiId
                },
                new SqlParameter
                {
                    ParameterName = "KullaniciTipiTanim",
                    Value = DüzenlenecekKullaniciTipi.KullaniciTipiTanim
                },
                new SqlParameter
                {
                    ParameterName = "KullaniciTipiAciklama",
                    Value = DüzenlenecekKullaniciTipi.KullaniciTipiAciklama
                },

            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_UpdateKullaniciTipi", KullaniciTipiParametreleri, "sp");

            return etkilenenSatir;

        }
        //Var olan Kullanıcı Tipi verisini ID sine göre sil. (delete)
        public int DeleteKullaniciTipi(KullaniciTipiEntity SilinecekKullaniciTipi)
        {
            SqlParameter[] KullaniciTipiParametreleri =
             {
                new SqlParameter {

                    ParameterName="KullaniciTipiId",
                    Value=SilinecekKullaniciTipi.KullaniciTipiId

                },
            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_DeleteKullaniciTipi", KullaniciTipiParametreleri, "sp");
            return etkilenenSatir;



        }
        #endregion
    }
}


