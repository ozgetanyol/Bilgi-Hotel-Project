using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class KullaniciDAL
    {
        #region CRUD Operations
        //ID ye göre Kullanıcıları Getir.(select with ID)
        public KullaniciEntity getKullaniciwithID(int KullaniciId)
        {
            SqlParameter[] KullaniciParametreleri =
            {
                new SqlParameter {

                    ParameterName="KullaniciId",
                    Value=KullaniciId

                },
            };

            SqlDataReader KullaniciRdr = BilgiHotelHelperSQL.myExecuteReader("KullaniciListesiwithID", KullaniciParametreleri, "sp");

            KullaniciEntity myKullanici = null;
            while (KullaniciRdr.Read())
            {
                myKullanici.KullaniciId = Convert.ToInt32(KullaniciRdr["KullaniciId"]);
                myKullanici.KullaniciTipiId = Convert.ToInt32(KullaniciRdr["KullaniciTipiId"]);
                myKullanici.KullaniciAd = KullaniciRdr["KullaniciAd"].ToString();
                myKullanici.KullaniciParola = KullaniciRdr["KullaniciParola"].ToString();
                myKullanici.KullaniciEposta = KullaniciRdr["KullaniciEposta"].ToString();
                myKullanici.KullaniciEpostaOnayKod = KullaniciRdr["KullaniciEpostaOnayKod"].ToString();
                myKullanici.KullaniciEpostaOnay = Convert.ToBoolean(KullaniciRdr["KullaniciEpostaOnay"]);
                myKullanici.KullaniciKayıtTarihi = Convert.ToDateTime(KullaniciRdr["KullaniciKayıtTarihi"]);
                myKullanici.KullaniciSonGirisTarihi = Convert.ToDateTime(KullaniciRdr["KullaniciSonGirisTarihi"]);
                myKullanici.DilId = Convert.ToInt32(KullaniciRdr["DilId"]);
                myKullanici.ResimId = Convert.ToInt32(KullaniciRdr["ResimId"]);

            }
            return myKullanici;

        }
        //Tüm Kullanıcıları Getir.(All)
        public KullaniciEntity getKullaniciAll(int KullaniciId)
        {

            SqlDataReader KullaniciRdr = BilgiHotelHelperSQL.myExecuteReader("sp_KullaniciListesiAll", null, "sp");

            KullaniciEntity myKullanici = null;
            while (KullaniciRdr.Read())
            {
                myKullanici.KullaniciId = Convert.ToInt32(KullaniciRdr["KullaniciId"]);
                myKullanici.KullaniciTipiId = Convert.ToInt32(KullaniciRdr["KullaniciTipiId"]);
                myKullanici.KullaniciAd = KullaniciRdr["KullaniciAd"].ToString();
                myKullanici.KullaniciParola = KullaniciRdr["KullaniciParola"].ToString();
                myKullanici.KullaniciEposta = KullaniciRdr["KullaniciEposta"].ToString();
                myKullanici.KullaniciEpostaOnayKod = KullaniciRdr["KullaniciEpostaOnayKod"].ToString();
                myKullanici.KullaniciEpostaOnay = Convert.ToBoolean(KullaniciRdr["KullaniciEpostaOnay"]);
                myKullanici.KullaniciKayıtTarihi = Convert.ToDateTime(KullaniciRdr["KullaniciKayıtTarihi"]);
                myKullanici.KullaniciSonGirisTarihi = Convert.ToDateTime(KullaniciRdr["KullaniciSonGirisTarihi"]);
                myKullanici.DilId = Convert.ToInt32(KullaniciRdr["DilId"]);
                myKullanici.ResimId = Convert.ToInt32(KullaniciRdr["ResimId"]);

            }
            return myKullanici;

        }
        //Yeni Kullanıcı Verisi Gir.(insert)
        public int İnsertKullanici(KullaniciEntity EklenecekKullanici)

        {
            SqlParameter[] KullaniciParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "KullaniciId",
                    Value = EklenecekKullanici.KullaniciId
                },
                new SqlParameter
                {
                    ParameterName = "KullaniciTipiId",
                    Value = EklenecekKullanici.KullaniciTipiId
                },
                new SqlParameter
                {
                    ParameterName = "KullaniciAd",
                    Value = EklenecekKullanici.KullaniciAd
                },
                 new SqlParameter
                {
                    ParameterName = "KullaniciParola",
                    Value = EklenecekKullanici.KullaniciParola
                },
                  new SqlParameter
                {
                    ParameterName = "KullaniciEposta",
                    Value = EklenecekKullanici.KullaniciEposta
                },
                   new SqlParameter
                {
                    ParameterName = "KullaniciEpostaOnayKod",
                    Value = EklenecekKullanici.KullaniciEpostaOnayKod
                },
                    new SqlParameter
                {
                    ParameterName = "KullaniciEpostaOnay",
                    Value = EklenecekKullanici.KullaniciEpostaOnay
                },
                     new SqlParameter
                {
                    ParameterName = "KullaniciKayıtTarihi",
                    Value = EklenecekKullanici.KullaniciKayıtTarihi
                },
                      new SqlParameter
                {
                    ParameterName = "KullaniciSonGirisTarihi",
                    Value = EklenecekKullanici.KullaniciSonGirisTarihi
                },
                       new SqlParameter
                {
                    ParameterName = "DilId",
                    Value = EklenecekKullanici.DilId
                },
                        new SqlParameter
                {
                    ParameterName = "ResimId",
                    Value = EklenecekKullanici.ResimId
                },

            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_InsertKullanicilar", KullaniciParametreleri, "sp");

            return etkilenenSatir;


        }
        //Var olan Kullanıcı verisini ID sine göre bul ve değiştir. (update)
        public int UpdateKullanici(KullaniciEntity DüzenlenecekKullanici)

        {
            SqlParameter[] KullaniciParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "KullaniciId",
                    Value = DüzenlenecekKullanici.KullaniciId
                },
                new SqlParameter
                {
                    ParameterName = "KullaniciTipiId",
                    Value = DüzenlenecekKullanici.KullaniciTipiId
                },
                new SqlParameter
                {
                    ParameterName = "KullaniciAd",
                    Value = DüzenlenecekKullanici.KullaniciAd
                },
                 new SqlParameter
                {
                    ParameterName = "KullaniciParola",
                    Value = DüzenlenecekKullanici.KullaniciParola
                },
                  new SqlParameter
                {
                    ParameterName = "KullaniciEposta",
                    Value = DüzenlenecekKullanici.KullaniciEposta
                },
                   new SqlParameter
                {
                    ParameterName = "KullaniciEpostaOnayKod",
                    Value = DüzenlenecekKullanici.KullaniciEpostaOnayKod
                },
                    new SqlParameter
                {
                    ParameterName = "KullaniciEpostaOnay",
                    Value = DüzenlenecekKullanici.KullaniciEpostaOnay
                },
                     new SqlParameter
                {
                    ParameterName = "KullaniciKayıtTarihi",
                    Value = DüzenlenecekKullanici.KullaniciKayıtTarihi
                },
                      new SqlParameter
                {
                    ParameterName = "KullaniciSonGirisTarihi",
                    Value = DüzenlenecekKullanici.KullaniciSonGirisTarihi
                },
                       new SqlParameter
                {
                    ParameterName = "DilId",
                    Value = DüzenlenecekKullanici.DilId
                },
                        new SqlParameter
                {
                    ParameterName = "ResimId",
                    Value = DüzenlenecekKullanici.ResimId
                },

            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_UpdateKulanicilar", KullaniciParametreleri, "sp");

            return etkilenenSatir;
        }
        //Var olan Görev verisini ID sine göre sil. (delete)
        public int DeleteKullanici(KullaniciEntity SilinecekKullanici)
        {
            SqlParameter[] KullaniciParametreleri =
             {
                new SqlParameter {

                    ParameterName="KullaniciId",
                    Value=SilinecekKullanici.KullaniciId

                },
            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_DeleteKullanicilar", KullaniciParametreleri, "sp");
            return etkilenenSatir;



        }
        #endregion
    }
}

