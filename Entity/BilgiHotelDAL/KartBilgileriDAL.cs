using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class KartBilgileriDAL
    {
        #region CRUD Operations
        //ID ye göre Kart Getir.(select with ID)
        public KartBilgileriEntity getKartBilgileriwithID(int KartId)
        {
            SqlParameter[] KartBilgileriParametreleri =
            {
                new SqlParameter {

                    ParameterName="KartId",
                    Value=KartId

                },
            };

            SqlDataReader KartBilgileriRdr = BilgiHotelHelperSQL.myExecuteReader("KartBilgileriListesiwithID", KartBilgileriParametreleri, "sp");

            KartBilgileriEntity myKartBilgileri= null;
            while (KartBilgileriRdr.Read())
            {
                myKartBilgileri.KartId = Convert.ToInt32(KartBilgileriRdr["KartId"]);
                myKartBilgileri.OdaId = Convert.ToInt32(KartBilgileriRdr["OdaId"]);
                myKartBilgileri.KartAktifMi = Convert.ToBoolean(KartBilgileriRdr["KartAktifMi"]);
                myKartBilgileri.PersonelId = Convert.ToInt32(KartBilgileriRdr["PersonelId"]);
                myKartBilgileri.MisafirId = Convert.ToInt32(KartBilgileriRdr["MisafirId"]);
                myKartBilgileri.KartVerilisTarihi = Convert.ToDateTime(KartBilgileriRdr["KartVerilisTarihi"]);
                myKartBilgileri.KartAlisTarihi = Convert.ToDateTime(KartBilgileriRdr["KartAlisTarihi"]);
                myKartBilgileri.KartIslemAciklama = KartBilgileriRdr["KartIslemAciklama"].ToString();
            }
            return myKartBilgileri;

        }
        //Tüm Kampanyaları Getir
        public KartBilgileriEntity getKampanyalarAll(int KartId)
        {

            SqlDataReader KartBilgileriRdr = BilgiHotelHelperSQL.myExecuteReader("sp_KartBilgileriListesiAll", null, "sp");

            KartBilgileriEntity myKartBilgileri = null;
            while (KartBilgileriRdr.Read())
            {
                myKartBilgileri.KartId = Convert.ToInt32(KartBilgileriRdr["KartId"]);
                myKartBilgileri.OdaId = Convert.ToInt32(KartBilgileriRdr["OdaId"]);
                myKartBilgileri.KartAktifMi = Convert.ToBoolean(KartBilgileriRdr["KartAktifMi"]);
                myKartBilgileri.PersonelId = Convert.ToInt32(KartBilgileriRdr["PersonelId"]);
                myKartBilgileri.MisafirId = Convert.ToInt32(KartBilgileriRdr["MisafirId"]);
                myKartBilgileri.KartVerilisTarihi = Convert.ToDateTime(KartBilgileriRdr["KartVerilisTarihi"]);
                myKartBilgileri.KartAlisTarihi = Convert.ToDateTime(KartBilgileriRdr["KartAlisTarihi"]);
                myKartBilgileri.KartIslemAciklama = KartBilgileriRdr["KartIslemAciklama"].ToString();
            }
            return myKartBilgileri;

        }
        //Yeni Kart Bilgileri Verisi Gir.(insert)
        public int İnsertKartBilgileri(KartBilgileriEntity EklenecekKartlar)

        {
            SqlParameter[] KartBilgileriParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "KartId",
                    Value = EklenecekKartlar.KartId
                },
                new SqlParameter
                {
                    ParameterName = "OdaId",
                    Value = EklenecekKartlar.OdaId
                },
                new SqlParameter
                {
                    ParameterName = "KartAktifMi",
                    Value = EklenecekKartlar.KartAktifMi
                },
                 new SqlParameter
                {
                    ParameterName = "PersonelId",
                    Value = EklenecekKartlar.PersonelId
                },
                  new SqlParameter
                {
                    ParameterName = "MisafirId",
                    Value = EklenecekKartlar.MisafirId
                },
                   new SqlParameter
                {
                    ParameterName = "KartVerilisTarihi",
                    Value = EklenecekKartlar.KartVerilisTarihi
                },
                    new SqlParameter
                {
                    ParameterName = "KartAlisTarihi",
                    Value = EklenecekKartlar.KartAlisTarihi
                },
                     new SqlParameter
                {
                    ParameterName = "KartIslemAciklama",
                    Value = EklenecekKartlar.KartIslemAciklama
                },

            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_InsertKartBilgileri", KartBilgileriParametreleri, "sp");

            return etkilenenSatir;


        }
        //Var olan Görev verisini ID sine göre bul ve değiştir. (update)
        public int UpdateKartBilgileri(KartBilgileriEntity DüzenlenecekKartlar)

        {
            SqlParameter[] KartBilgileriParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "KartId",
                    Value = DüzenlenecekKartlar.KartId
                },
                new SqlParameter
                {
                    ParameterName = "OdaId",
                    Value = DüzenlenecekKartlar.OdaId
                },
                new SqlParameter
                {
                    ParameterName = "KartAktifMi",
                    Value = DüzenlenecekKartlar.KartAktifMi
                },
                 new SqlParameter
                {
                    ParameterName = "PersonelId",
                    Value = DüzenlenecekKartlar.PersonelId
                },
                  new SqlParameter
                {
                    ParameterName = "MisafirId",
                    Value = DüzenlenecekKartlar.MisafirId
                },
                   new SqlParameter
                {
                    ParameterName = "KartVerilisTarihi",
                    Value = DüzenlenecekKartlar.KartVerilisTarihi
                },
                    new SqlParameter
                {
                    ParameterName = "KartAlisTarihi",
                    Value = DüzenlenecekKartlar.KartAlisTarihi
                },
                     new SqlParameter
                {
                    ParameterName = "KartIslemAciklama",
                    Value = DüzenlenecekKartlar.KartIslemAciklama
                },

            };

        
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_UpdateKartlar", KartBilgileriParametreleri, "sp");

            return etkilenenSatir;
        }
        //Var olan Görev verisini ID sine göre sil. (delete)
        public int DeleteKartBilgileri(KartBilgileriEntity SilinecekKartlar)
        {
            SqlParameter[] KartBilgileriParametreleri =
             {
                new SqlParameter {

                    ParameterName="KartId",
                    Value=SilinecekKartlar.KartId

                },
            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_DeleteKartlar", KartBilgileriParametreleri, "sp");
            return etkilenenSatir;



        }
        #endregion
    }
}

