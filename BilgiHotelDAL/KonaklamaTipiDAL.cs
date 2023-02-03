using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class KonaklamaTipiDAL
    {
        #region CRUD Operations
        //ID ye göre Konaklama Tipi Getir.(select with ID)
        public KonaklamaTipiEntity getKonaklamaTipiwithID(int KonaklamaTipNo)
        {
            SqlParameter[] KonaklamaTipiParametreleri =
            {
                new SqlParameter {

                    ParameterName="KonaklamaTipNo",
                    Value=KonaklamaTipNo

                },
            };

            SqlDataReader KonaklamaTipiRdr = BilgiHotelHelperSQL.myExecuteReader("KonaklamaTipiListesiwithID", KonaklamaTipiParametreleri, "sp");

            KonaklamaTipiEntity myKonaklamaTipi = null;
            while (KonaklamaTipiRdr.Read())
            {
                myKonaklamaTipi.KonaklamaTipNo = Convert.ToInt32(KonaklamaTipiRdr["KonaklamaTipNo"]);
                myKonaklamaTipi.KonaklamaTipAd = KonaklamaTipiRdr["KonaklamaTipAd"].ToString();
                myKonaklamaTipi.KonaklamaTipAciklama = KonaklamaTipiRdr["KonaklamaTipAciklama"].ToString();
                
            }
            return myKonaklamaTipi;

        }
        //Tüm Konaklama Tiplerini Getir(ALL)
        public KonaklamaTipiEntity getKonaklamaTipiAll(int KonaklamaTipNo)
        {

            SqlDataReader KonaklamaTipiRdr = BilgiHotelHelperSQL.myExecuteReader("sp_KonaklamaTipiListesiAll", null, "sp");

            KonaklamaTipiEntity myKonaklamaTipi = null;
            while (KonaklamaTipiRdr.Read())
            {
                myKonaklamaTipi.KonaklamaTipNo = Convert.ToInt32(KonaklamaTipiRdr["KonaklamaTipNo"]);
                myKonaklamaTipi.KonaklamaTipAd = KonaklamaTipiRdr["KonaklamaTipAd"].ToString();
                myKonaklamaTipi.KonaklamaTipAciklama = KonaklamaTipiRdr["KonaklamaTipAciklama"].ToString();

            }
            return myKonaklamaTipi;

        }
        //Yeni Konaklama Tipi Verisi Gir.(insert)
        public int İnsertKonaklamaTipi(KonaklamaTipiEntity EklenecekKonaklamaTipi)

        {
            SqlParameter[] KonaklamaTipiParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "KonaklamaTipNo",
                    Value = EklenecekKonaklamaTipi.KonaklamaTipNo
                },
                new SqlParameter
                {
                    ParameterName = "KonaklamaTipAd",
                    Value = EklenecekKonaklamaTipi.KonaklamaTipAd
                },
                new SqlParameter
                {
                    ParameterName = "KonaklamaTipAciklama",
                    Value = EklenecekKonaklamaTipi.KonaklamaTipAciklama
                },
                

            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_InsertKonaklamaTipi", KonaklamaTipiParametreleri, "sp");

            return etkilenenSatir;


        }
        //Var olan Konaklama Tipi verisini ID sine göre bul ve değiştir. (update)
        public int UpdateKonaklamaTipi(KonaklamaTipiEntity DüzenlenecekKonaklamaTipi)

        {
            SqlParameter[] KonaklamaTipiParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "KonaklamaTipNo",
                    Value = DüzenlenecekKonaklamaTipi.KonaklamaTipNo
                },
                new SqlParameter
                {
                    ParameterName = "KonaklamaTipAd",
                    Value = DüzenlenecekKonaklamaTipi.KonaklamaTipAd
                },
                new SqlParameter
                {
                    ParameterName = "KonaklamaTipAciklama",
                    Value = DüzenlenecekKonaklamaTipi.KonaklamaTipAciklama
                },


           

        };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_UptadeKonaklamaTipi", KonaklamaTipiParametreleri, "sp");

            return etkilenenSatir;
        }
        //Var olan Konaklama Tipi verisini ID sine göre sil. (delete)
        public int DeleteKonaklamaTipi(KonaklamaTipiEntity SilinecekKonaklamaTipi)
        {
            SqlParameter[] KonaklamaTipiParametreleri =
             {
                new SqlParameter {

                    ParameterName="KonaklamaTipNo",
                    Value=SilinecekKonaklamaTipi.KonaklamaTipNo

                },
            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_DeleteKonaklamaTipi", KonaklamaTipiParametreleri, "sp");
            return etkilenenSatir;



        }
        #endregion
    }
}

