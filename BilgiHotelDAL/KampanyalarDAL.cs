using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class KampanyalarDAL
    {
        #region CRUD Operations
        //ID ye göre Kampanyaları Getir.(select with ID)
        public KampanyalarEntity getKampanyalarwithID(int KampanyaId)
        {
            SqlParameter[] KampanyalarParametreleri =
            {
                new SqlParameter {

                    ParameterName="KampanyaId",
                    Value= KampanyaId

                },
            };

            SqlDataReader KampanyalarRdr = BilgiHotelHelperSQL.myExecuteReader("KampanyalarListesiwithID", KampanyalarParametreleri, "sp");

            KampanyalarEntity myKampanyalar = null;
            while (KampanyalarRdr.Read())
            {
                myKampanyalar.KampanyaId = Convert.ToInt32(KampanyalarRdr["KampanyaId"]);
                myKampanyalar.KampanyaBilgileri = KampanyalarRdr["KampanyaBilgileri"].ToString();
                myKampanyalar.KampanyaIndirimOran = Convert.ToInt32(KampanyalarRdr["KampanyaIndirimOran"]);
                myKampanyalar.KampanyaBaslangicZaman = Convert.ToDateTime(KampanyalarRdr["KampanyaBaslangicZaman"]);
                myKampanyalar.KampanyaBitisTarihi= Convert.ToDateTime(KampanyalarRdr["KampanyaBitisTarihi"]);
                myKampanyalar.KampanyaTanim= KampanyalarRdr["KampanyaTanim"].ToString() ;



            }
            return myKampanyalar;

        }
        //Tüm Kampanyaları Getir(All)
        public KampanyalarEntity getKampanyaAll(int GorevId)
        {

            SqlDataReader KampanyalarRdr = BilgiHotelHelperSQL.myExecuteReader("sp_KampanyaListesiAll", null, "sp");

            KampanyalarEntity myKampanyalar = null;
            while (KampanyalarRdr.Read())
            {
                myKampanyalar.KampanyaId = Convert.ToInt32(KampanyalarRdr["KampanyaId"]);
                myKampanyalar.KampanyaBilgileri = KampanyalarRdr["KampanyaBilgileri"].ToString();
                myKampanyalar.KampanyaIndirimOran = Convert.ToInt32(KampanyalarRdr["KampanyaIndirimOran"]);
                myKampanyalar.KampanyaBaslangicZaman = Convert.ToDateTime(KampanyalarRdr["KampanyaBaslangicZaman"]);
                myKampanyalar.KampanyaBitisTarihi = Convert.ToDateTime(KampanyalarRdr["KampanyaBitisTarihi"]);
                myKampanyalar.KampanyaTanim = KampanyalarRdr["KampanyaTanim"].ToString();



            }
            return myKampanyalar;

        }
        //Yeni Kampanya Verisi Gir.(insert)
        public int İnsertKampanyalar(KampanyalarEntity EklenecekKampanyalar)

        {
            SqlParameter[] KampanyaParametreleri =
            {
               
                new SqlParameter
                {
                    ParameterName = "KampanyaBilgileri",
                    Value = EklenecekKampanyalar.KampanyaBilgileri
                },
                new SqlParameter
                {
                    ParameterName = "KampanyaIndirimOran",
                    Value = EklenecekKampanyalar.KampanyaIndirimOran
                },
                 new SqlParameter
                {
                    ParameterName = "KampanyaBaslangicZaman",
                    Value = EklenecekKampanyalar.KampanyaBaslangicZaman
                },
                  new SqlParameter
                {
                    ParameterName = "KampanyaBitisTarihi",
                    Value = EklenecekKampanyalar.KampanyaBitisTarihi
                },
                   new SqlParameter
                {
                    ParameterName = "KampanyaTanim",
                    Value = EklenecekKampanyalar.KampanyaTanim
                },

            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_InsertKampanyalar", KampanyaParametreleri, "sp");

            return etkilenenSatir;


        }
        //Var olan Kampanya verisini ID sine göre bul ve değiştir. (update)
        public int UpdateKampanyalar(KampanyalarEntity DüzenlenecekKampanya)

        {
            SqlParameter[] KampanyaParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "KampanyaId",
                    Value = DüzenlenecekKampanya.KampanyaId
                },
                new SqlParameter
                {
                    ParameterName = "KampanyaBilgileri",
                    Value = DüzenlenecekKampanya.KampanyaBilgileri
                },
                new SqlParameter
                {
                    ParameterName = "KampanyaIndirimOran",
                    Value = DüzenlenecekKampanya.KampanyaIndirimOran
                },
                 new SqlParameter
                {
                    ParameterName = "KampanyaBaslangicZaman",
                    Value = DüzenlenecekKampanya.KampanyaBaslangicZaman
                },
                  new SqlParameter
                {
                    ParameterName = "KampanyaBitisTarihi",
                    Value = DüzenlenecekKampanya.KampanyaBitisTarihi
                },
                   new SqlParameter
                {
                    ParameterName = "KampanyaTanim",
                    Value =   DüzenlenecekKampanya.KampanyaTanim
                },

            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_UpdateKampanyalar", KampanyaParametreleri, "sp");

            return etkilenenSatir;
        }
            //Var olan Görev verisini ID sine göre sil. (delete)
            public int DeleteKampanyalar(KampanyalarEntity SilinecekKampanyalar)
        {
            SqlParameter[] KampanyaParametreleri =
             {
                new SqlParameter {

                    ParameterName="KampanyaId",
                    Value=SilinecekKampanyalar.KampanyaId

                },
            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_DeleteKampanyalar", KampanyaParametreleri, "sp");
            return etkilenenSatir;



        }
        #endregion
    }

}
