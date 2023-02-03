using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class OdalarDAL
    {
        #region CRUD Operations
        //ID ye göre Oda Getir.(select with ID)
        public OdalarEntity getOdalarwithID(int OdaId)
        {
            SqlParameter[] OdaParametreleri =
            {
                new SqlParameter {

                    ParameterName="OdaId",
                    Value=OdaId

                },
            };

            SqlDataReader OdaRdr = BilgiHotelHelperSQL.myExecuteReader("OdaListesiwithID", OdaParametreleri, "sp");

            OdalarEntity myOda = null;
            while (OdaRdr.Read())
            {
                myOda.OdaId = Convert.ToInt32(OdaRdr["OdaId"]);
                myOda.OdaEbatMsqr = Convert.ToInt32(OdaRdr["OdaEbatMsqr"]);
                myOda.OdaTipiId = Convert.ToInt32(OdaRdr["OdaTipiId"]);
                myOda.OdaFiyat = Convert.ToDecimal(OdaRdr["OdaFiyat"]);
                myOda.OdaYatakTipi = OdaRdr["OdaYatakTipi"].ToString();
                myOda.OdaMiniBarOk = Convert.ToBoolean(OdaRdr["OdaMiniBarOk"]);
                myOda.OdaKlimaOk = Convert.ToBoolean(OdaRdr["OdaKlimaOk"]);
                myOda.OdaKurutmaOk = Convert.ToBoolean(OdaRdr["OdaKurutmaOk"]);
                myOda.OdaWifiOk = Convert.ToBoolean(OdaRdr["OdaWifiOk"]);
                myOda.OdaKasaOk = Convert.ToBoolean(OdaRdr["OdaKasaOk"]);
                myOda.OdaBalkonOk = Convert.ToBoolean(OdaRdr["OdaBalkonOk"]);
                myOda.OdaTvOk = Convert.ToBoolean(OdaRdr["OdaTvOk"]);
                myOda.OdaAciklama = OdaRdr["OdaAciklama"].ToString();
                myOda.OdaEbatBoyut = OdaRdr["OdaEbatBoyut"].ToString();
                myOda.OdaNo = OdaRdr["OdaNo"].ToString();
                myOda.OdaKat = Convert.ToInt32(OdaRdr["OdaKat"]);

            }
            return myOda;

        }
        //Tüm Oda Tiplerini Getir(ALL)
        public OdalarEntity getOdaAll(int OdaId)
        {

            SqlDataReader OdaRdr = BilgiHotelHelperSQL.myExecuteReader("sp_OdaListesiAll", null, "sp");

            OdalarEntity myOda = null;
            while (OdaRdr.Read())
            {
                myOda.OdaId = Convert.ToInt32(OdaRdr["OdaId"]);
                myOda.OdaEbatMsqr = Convert.ToInt32(OdaRdr["OdaEbatMsqr"]);
                myOda.OdaTipiId = Convert.ToInt32(OdaRdr["OdaTipiId"]);
                myOda.OdaFiyat = Convert.ToDecimal(OdaRdr["OdaFiyat"]);
                myOda.OdaYatakTipi = OdaRdr["OdaYatakTipi"].ToString();
                myOda.OdaMiniBarOk = Convert.ToBoolean(OdaRdr["OdaMiniBarOk"]);
                myOda.OdaKlimaOk = Convert.ToBoolean(OdaRdr["OdaKlimaOk"]);
                myOda.OdaKurutmaOk = Convert.ToBoolean(OdaRdr["OdaKurutmaOk"]);
                myOda.OdaWifiOk = Convert.ToBoolean(OdaRdr["OdaWifiOk"]);
                myOda.OdaKasaOk = Convert.ToBoolean(OdaRdr["OdaKasaOk"]);
                myOda.OdaBalkonOk = Convert.ToBoolean(OdaRdr["OdaBalkonOk"]);
                myOda.OdaTvOk = Convert.ToBoolean(OdaRdr["OdaTvOk"]);
                myOda.OdaAciklama = OdaRdr["OdaAciklama"].ToString();
                myOda.OdaEbatBoyut = OdaRdr["OdaEbatBoyut"].ToString();
                myOda.OdaNo = OdaRdr["OdaNo"].ToString();
                myOda.OdaKat = Convert.ToInt32(OdaRdr["OdaKat"]);

            }
            return myOda;

        }
        //Yeni Oda Verisi Gir.(insert)
        public int İnsertOdalar (OdalarEntity EklenecekOda)

        {
            SqlParameter[] OdaParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "OdaId",
                    Value = EklenecekOda.OdaId
                },
                new SqlParameter
                {
                    ParameterName = "OdaEbatMsqr",
                    Value = EklenecekOda.OdaEbatMsqr
                },
                new SqlParameter
                {
                    ParameterName = "OdaTipiId",
                    Value = EklenecekOda.OdaTipiId
                },
                new SqlParameter
                {
                    ParameterName = "OdaFiyat",
                    Value = EklenecekOda.OdaFiyat
                },
                new SqlParameter
                {
                    ParameterName = "OdaYatakTipi",
                    Value = EklenecekOda.OdaYatakTipi
                },
                new SqlParameter
                {
                    ParameterName = "OdaMiniBarOk",
                    Value = EklenecekOda.OdaMiniBarOk
                },
                 new SqlParameter
                {
                    ParameterName = "OdaKlimaOk",
                    Value = EklenecekOda.OdaKlimaOk
                },
                 new SqlParameter
                {
                    ParameterName = "OdaKurutmaOk",
                    Value = EklenecekOda.OdaKurutmaOk
                },
                new SqlParameter
                {
                    ParameterName = "OdaWifiOk",
                    Value = EklenecekOda.OdaWifiOk
                },
                new SqlParameter
                {
                    ParameterName = "OdaKasaOk",
                    Value = EklenecekOda.OdaKasaOk
                },
                 new SqlParameter
                {
                    ParameterName = "OdaBalkonOk",
                    Value = EklenecekOda.OdaBalkonOk
                },
                 new SqlParameter
                {
                    ParameterName = "OdaTvOk",
                    Value = EklenecekOda.OdaTvOk
                },
                new SqlParameter
                {
                    ParameterName = "OdaAciklama",
                    Value = EklenecekOda.OdaAciklama
                },
                 new SqlParameter
                {
                    ParameterName = "OdaEbatBoyut",
                    Value = EklenecekOda.OdaEbatBoyut
                },
                  new SqlParameter
                {
                    ParameterName = "OdaNo",
                    Value = EklenecekOda.OdaNo
                },
                   new SqlParameter
                {
                    ParameterName = "OdaKat",
                    Value = EklenecekOda.OdaKat
                },


            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_OdaEkle", OdaParametreleri, "sp");

            return etkilenenSatir;


        }
        //Var olan Oda verisini OdaNo suna göre bul ve değiştir. (update)
        public int UpdateOdalar(OdalarEntity DüzenlenecekOda)

        {
            SqlParameter[] OdaParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "OdaId",
                    Value = DüzenlenecekOda.OdaId
                },
                new SqlParameter
                {
                    ParameterName = "OdaEbatMsqr",
                    Value = DüzenlenecekOda.OdaEbatMsqr
                },
                new SqlParameter
                {
                    ParameterName = "OdaTipiId",
                    Value = DüzenlenecekOda.OdaTipiId
                },
                new SqlParameter
                {
                    ParameterName = "OdaFiyat",
                    Value = DüzenlenecekOda.OdaFiyat
                },
                new SqlParameter
                {
                    ParameterName = "OdaYatakTipi",
                    Value = DüzenlenecekOda.OdaYatakTipi
                },
                new SqlParameter
                {
                    ParameterName = "OdaMiniBarOk",
                    Value = DüzenlenecekOda.OdaMiniBarOk
                },
                 new SqlParameter
                {
                    ParameterName = "OdaKlimaOk",
                    Value = DüzenlenecekOda.OdaKlimaOk
                },
                 new SqlParameter
                {
                    ParameterName = "OdaKurutmaOk",
                    Value = DüzenlenecekOda.OdaKurutmaOk
                },
                new SqlParameter
                {
                    ParameterName = "OdaWifiOk",
                    Value = DüzenlenecekOda.OdaWifiOk
                },
                new SqlParameter
                {
                    ParameterName = "OdaKasaOk",
                    Value = DüzenlenecekOda.OdaKasaOk
                },
                 new SqlParameter
                {
                    ParameterName = "OdaBalkonOk",
                    Value = DüzenlenecekOda.OdaBalkonOk
                },
                 new SqlParameter
                {
                    ParameterName = "OdaTvOk",
                    Value = DüzenlenecekOda.OdaTvOk
                },
                new SqlParameter
                {
                    ParameterName = "OdaAciklama",
                    Value = DüzenlenecekOda.OdaAciklama
                },
                 new SqlParameter
                {
                    ParameterName = "OdaEbatBoyut",
                    Value = DüzenlenecekOda.OdaEbatBoyut
                },
                  new SqlParameter
                {
                    ParameterName = "OdaNo",
                    Value = DüzenlenecekOda.OdaNo
                },
                   new SqlParameter
                {
                    ParameterName = "OdaKat",
                    Value = DüzenlenecekOda.OdaKat
                },





        };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_UpdateOdalar", OdaParametreleri, "sp");

            return etkilenenSatir;
        }
        //Var olan Oda verisini OdaNo suna göre sil. (delete)
        public int DeleteOdalar(OdalarEntity SilinecekOda)
        {
            SqlParameter[] OdaParametreleri =
             {
                new SqlParameter {

                    ParameterName="OdaId",
                    Value=SilinecekOda.OdaId

                },
            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_DeleteOdalar", OdaParametreleri, "sp");
            return etkilenenSatir;



        }
        #endregion
    }
}
