using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class MusteriMisafirSatisDAL
    {
        #region CRUD Operations
        //ID ye göre Müşteri ve Misafir Satış Getir.(select with ID)
        public MusteriMisafirSatisEntity MusteriMisafirSatisGetir(int MusteriId, int MisafirId, int SatisId)
        {
            SqlParameter[] MusteriMisafirSatisParametreleri =
            {
                new SqlParameter {

                    ParameterName="MusteriId",
                    Value=MusteriId

                },
                 new SqlParameter {

                    ParameterName="MisafirId",
                    Value=MisafirId

                },
                  new SqlParameter {

                    ParameterName="SatisId",
                    Value=SatisId

                },
            };

            SqlDataReader MusteriMisafirSatisRdr = BilgiHotelHelperSQL.myExecuteReader("sp_MusteriMisafirSatisGetir", MusteriMisafirSatisParametreleri, "sp");

            MusteriMisafirSatisEntity myMusteriMisafirSatis = null;
            while (MusteriMisafirSatisRdr.Read())
            {
                myMusteriMisafirSatis.MusteriId = Convert.ToInt32(MusteriMisafirSatisRdr["MusteriId"]);
                myMusteriMisafirSatis.MisafirId = Convert.ToInt32(MusteriMisafirSatisRdr["MisafirId"]);
                myMusteriMisafirSatis.SatisId = Convert.ToInt32(MusteriMisafirSatisRdr["SatisId"]);


            }
            return myMusteriMisafirSatis;

        }
        //Tüm Verileri Getir.(All)
        public MusteriMisafirSatisEntity sp_MusteriMisafirSatisListesiAll(int MusteriId, int MisafirId, int SatisId)
        {

            SqlDataReader MusteriMisafirSatisRdr = BilgiHotelHelperSQL.myExecuteReader("sp_MusteriMisafirSatisListesiAll", null, "sp");

            MusteriMisafirSatisEntity myMusteriMisafirSatis = null;
            while (MusteriMisafirSatisRdr.Read())
            {
                myMusteriMisafirSatis.MusteriId = Convert.ToInt32(MusteriMisafirSatisRdr["MusteriId"]);
                myMusteriMisafirSatis.MisafirId = Convert.ToInt32(MusteriMisafirSatisRdr["MisafirId"]);
                myMusteriMisafirSatis.SatisId = Convert.ToInt32(MusteriMisafirSatisRdr["SatisId"]);


            }
            return myMusteriMisafirSatis;

        }
        //Yeni Müşteri Misafir Satış Verisi Gir.(insert)
        public int InsertMusteriMisafirSatis(MusteriMisafirSatisEntity EklenecekMusteriMisafirSatis)

        {
            SqlParameter[] MusteriMisafirSatisParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "MusteriId",
                    Value = EklenecekMusteriMisafirSatis.MusteriId
                },
                new SqlParameter
                {
                    ParameterName = "MisafirId",
                    Value = EklenecekMusteriMisafirSatis.MisafirId
                },
                 new SqlParameter {

                    ParameterName="SatisId",
                    Value=EklenecekMusteriMisafirSatis.SatisId

                },


            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_InsertMusteriMisafirSatis", MusteriMisafirSatisParametreleri, "sp");

            return etkilenenSatir;


        }
        #endregion
    }
}
