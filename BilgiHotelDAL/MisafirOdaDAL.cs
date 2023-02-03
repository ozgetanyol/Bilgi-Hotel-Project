using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class MisafirOdaDAL
    {
        #region CRUD Operations
        //ID ye göre Misafir Oda Getir.(select with ID)
        public MisafirOdaEntity MisafirOdaGetir(int MisafirId, int OdaId, int SatisId)
        {
            SqlParameter[] MisafirOdaParametreleri =
            {
                new SqlParameter {

                    ParameterName="MisafirId",
                    Value=MisafirId

                },
                 new SqlParameter {

                    ParameterName="OdaId",
                    Value=OdaId

                },
                  new SqlParameter {

                    ParameterName="SatisId",
                    Value=SatisId

                },
            };

            SqlDataReader MisafirOdaRdr = BilgiHotelHelperSQL.myExecuteReader("sp_MisafirOdaGetir", MisafirOdaParametreleri, "sp");

            MisafirOdaEntity myMisafirOda = null;
            while (MisafirOdaRdr.Read())
            {
                myMisafirOda.MisafirId = Convert.ToInt32(MisafirOdaRdr["MisafirId"]);
                myMisafirOda.OdaId = Convert.ToInt32(MisafirOdaRdr["OdaId"]);
                myMisafirOda.SatisId = Convert.ToInt32(MisafirOdaRdr["SatisId"]);


            }
            return myMisafirOda;

        }
        //Tüm Verileri Getir.(All)
        public MisafirOdaEntity sp_MisafirOdaListesiAll(int MisafirId, int OdaId, int SatisId)
        {

            SqlDataReader MisafirOdaRdr = BilgiHotelHelperSQL.myExecuteReader("sp_MisafirOdaListesiAll", null, "sp");

            MisafirOdaEntity myMisafirOda = null;
            while (MisafirOdaRdr.Read())
            {
                myMisafirOda.MisafirId = Convert.ToInt32(MisafirOdaRdr["MisafirId"]);
                myMisafirOda.OdaId = Convert.ToInt32(MisafirOdaRdr["OdaId"]);
                myMisafirOda.SatisId = Convert.ToInt32(MisafirOdaRdr["SatisId"]);


            }
            return myMisafirOda;

        }
        //Yeni Misafir Oda Verisi Gir.(insert)
        public int InsertMisafirOda(MisafirOdaEntity EklenecekMisafirOda)

        {
            SqlParameter[] MisafirOdaParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "MisafirId",
                    Value = EklenecekMisafirOda.MisafirId
                },
                new SqlParameter
                {
                    ParameterName = "OdaId",
                    Value = EklenecekMisafirOda.OdaId
                },
                 new SqlParameter {

                    ParameterName="SatisId",
                    Value=EklenecekMisafirOda.SatisId

                },


            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_İnsertMisafirOda", MisafirOdaParametreleri, "sp");

            return etkilenenSatir;


        }
        #endregion
    }
}
