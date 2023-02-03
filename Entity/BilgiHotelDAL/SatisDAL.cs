using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class SatisDAL
    {
        #region CRUD Operations
        //ID ye göre Satış Getir.(select with ID)
        public SatisEntity getSatiswithID(int SatisId)
        {
            SqlParameter[] SatisParametreleri =
            {
                new SqlParameter {

                    ParameterName="SatisId",
                    Value=SatisId

                },
            };

            SqlDataReader SatisRdr = BilgiHotelHelperSQL.myExecuteReader("SatisListesiwithID", SatisParametreleri, "sp");

            SatisEntity mySatis = null;
            while (SatisRdr.Read())
            {
                mySatis.SatisId = Convert.ToInt32(SatisRdr["KonaklamaTipNo"]);
                mySatis.SatisOdaGirisTarihi = Convert.ToDateTime(SatisRdr["SatisOdaGirisTarihi"]);
                mySatis.SatisOdaCikisTarihi = Convert.ToDateTime(SatisRdr["SatisOdaCikisTarihi"]);
                mySatis.SatisIndirim = Convert.ToInt32(SatisRdr["SatisIndirim"]);
                mySatis.KartId = Convert.ToInt32(SatisRdr["KartId"]);
                mySatis.OdaId = Convert.ToInt32(SatisRdr["OdaId"]);
                mySatis.OdaSatisDurum = Convert.ToBoolean(SatisRdr["OdaSatisDurum"]);
                mySatis.OdaSatisTutar = Convert.ToDecimal(SatisRdr["OdaSatisTutar"]);
                mySatis.OdaSatisKDV = Convert.ToInt32(SatisRdr["OdaSatisKDV"]);
                mySatis.OdaSatisOdemeTipiId = Convert.ToInt32(SatisRdr["OdaSatisOdemeTipiId"]);

            }
            return mySatis;

        }
        //Tüm Satış Tiplerini Getir(ALL)
        public SatisEntity getSatisAll(int SatisId)
        {

            SqlDataReader SatisRdr = BilgiHotelHelperSQL.myExecuteReader("sp_SatisListesiAll", null, "sp");

            SatisEntity mySatis = null;
            while (SatisRdr.Read())
            {
                mySatis.SatisId = Convert.ToInt32(SatisRdr["KonaklamaTipNo"]);
                mySatis.SatisOdaGirisTarihi = Convert.ToDateTime(SatisRdr["SatisOdaGirisTarihi"]);
                mySatis.SatisOdaCikisTarihi = Convert.ToDateTime(SatisRdr["SatisOdaCikisTarihi"]);
                mySatis.SatisIndirim = Convert.ToInt32(SatisRdr["SatisIndirim"]);
                mySatis.KartId = Convert.ToInt32(SatisRdr["KartId"]);
                mySatis.OdaId = Convert.ToInt32(SatisRdr["OdaId"]);
                mySatis.OdaSatisDurum = Convert.ToBoolean(SatisRdr["OdaSatisDurum"]);
                mySatis.OdaSatisTutar = Convert.ToDecimal(SatisRdr["OdaSatisTutar"]);
                mySatis.OdaSatisKDV = Convert.ToInt32(SatisRdr["OdaSatisKDV"]);
                mySatis.OdaSatisOdemeTipiId = Convert.ToInt32(SatisRdr["OdaSatisOdemeTipiId"]);

            }
            return mySatis;

        }
        //Yeni Satış Verisi Gir.(insert)
        public int İnsertSatis(SatisEntity EklenecekSatis)

        {
            SqlParameter[] SatisParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "SatisId",
                    Value = EklenecekSatis.SatisId
                },
                new SqlParameter
                {
                    ParameterName = "SatisOdaGirisTarihi",
                    Value = EklenecekSatis.SatisOdaGirisTarihi
                },
                new SqlParameter
                {
                    ParameterName = "SatisOdaCikisTarihi",
                    Value = EklenecekSatis.SatisOdaCikisTarihi
                },
              new SqlParameter
                {
                    ParameterName = "SatisIndirim",
                    Value = EklenecekSatis.SatisIndirim
                },
                new SqlParameter
                {
                    ParameterName = "KartId",
                    Value = EklenecekSatis.KartId
                },
                new SqlParameter
                {
                    ParameterName = "OdaId",
                    Value = EklenecekSatis.OdaId
                },
                new SqlParameter
                {
                    ParameterName = "OdaSatisDurum",
                    Value = EklenecekSatis.OdaSatisDurum
                },
                new SqlParameter
                {
                    ParameterName = "OdaSatisTutar",
                    Value = EklenecekSatis.OdaSatisTutar
                },
                 new SqlParameter
                {
                    ParameterName = "OdaSatisKDV",
                    Value = EklenecekSatis.OdaSatisKDV
                },
                 new SqlParameter
                {
                    ParameterName = "OdaSatisOdemeTipiId",
                    Value = EklenecekSatis.OdaSatisOdemeTipiId
                },



            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_InsertSatis", SatisParametreleri, "sp");

            return etkilenenSatir;


        }
        //Var olan Satış verisini ID sine göre bul ve değiştir. (update)
        public int UpdateSatis (SatisEntity DüzenlenecekSatis)

        {
            SqlParameter[] SatisParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "SatisId",
                    Value = DüzenlenecekSatis.SatisId
                },
                new SqlParameter
                {
                    ParameterName = "SatisOdaGirisTarihi",
                    Value = DüzenlenecekSatis.SatisOdaGirisTarihi
                },
                new SqlParameter
                {
                    ParameterName = "SatisOdaCikisTarihi",
                    Value = DüzenlenecekSatis.SatisOdaCikisTarihi
                },
              new SqlParameter
                {
                    ParameterName = "SatisIndirim",
                    Value = DüzenlenecekSatis.SatisIndirim
                },
                new SqlParameter
                {
                    ParameterName = "KartId",
                    Value = DüzenlenecekSatis.KartId
                },
                new SqlParameter
                {
                    ParameterName = "OdaId",
                    Value = DüzenlenecekSatis.OdaId
                },
                new SqlParameter
                {
                    ParameterName = "OdaSatisDurum",
                    Value = DüzenlenecekSatis.OdaSatisDurum
                },
                new SqlParameter
                {
                    ParameterName = "OdaSatisTutar",
                    Value = DüzenlenecekSatis.OdaSatisTutar
                },
                 new SqlParameter
                {
                    ParameterName = "OdaSatisKDV",
                    Value = DüzenlenecekSatis.OdaSatisKDV
                },
                 new SqlParameter
                {
                    ParameterName = "OdaSatisOdemeTipiId",
                    Value = DüzenlenecekSatis.OdaSatisOdemeTipiId
                },


        };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_UpdateSatis", SatisParametreleri, "sp");

            return etkilenenSatir;
        }
        //Var olan Konaklama Tipi verisini ID sine göre sil. (delete)
        public int DeleteSatis(SatisEntity SilinecekSatis)
        {
            SqlParameter[] SatisParametreleri =
             {
                new SqlParameter {

                    ParameterName="SatisId",
                    Value=SilinecekSatis.SatisId

                },
            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_DeleteSatis", SatisParametreleri, "sp");
            return etkilenenSatir;



        }
        #endregion
    }
}

