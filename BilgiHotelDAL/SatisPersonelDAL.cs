using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class SatisPersonelDAL
    {
        #region CRUD Operations
        //ID ye göre Satış Personel Getir.(select with ID)
        public SatisPersonelEntity SatisPersonelGetir( int PersonelId , int SatisId)
        {
            SqlParameter[] SatisPersonelParametreleri =
            {
                new SqlParameter {

                    ParameterName="PersonelId",
                    Value=PersonelId

                },
                 new SqlParameter {

                    ParameterName="SatisId",
                    Value=SatisId

                },

            };

            SqlDataReader SatisPersonelRdr = BilgiHotelHelperSQL.myExecuteReader("sp_SatisPersonelGetir", SatisPersonelParametreleri, "sp");

            SatisPersonelEntity mySatisPersonel = null;
            while (SatisPersonelRdr.Read())
            {
                mySatisPersonel.PersonelId = Convert.ToInt32(SatisPersonelRdr["PersonelId"]);
                mySatisPersonel.SatisId = Convert.ToInt32(SatisPersonelRdr["SatisId"]);



            }
            return mySatisPersonel;

        }
        //Tüm Verileri Getir.(All)
        public SatisPersonelEntity sp_SatisPersonelListesiAll(int PersonelId, int SatisId)
        {

            SqlDataReader SatisPersonelRdr = BilgiHotelHelperSQL.myExecuteReader("sp_SatisPersonelListesiAll", null, "sp");

            SatisPersonelEntity mySatisPersonel = null;
            while (SatisPersonelRdr.Read())
            {
                mySatisPersonel.PersonelId = Convert.ToInt32(SatisPersonelRdr["PersonelId"]);
                mySatisPersonel.SatisId = Convert.ToInt32(SatisPersonelRdr["SatisId"]);



            }
            return mySatisPersonel;

        }
        //Yeni Satış Personel Verisi Gir.(insert)
        public int InsertSatisPersonel(SatisPersonelEntity EklenecekSatisPersonel)

        {
            SqlParameter[] SatisPersonelParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "PersonelId",
                    Value = EklenecekSatisPersonel.PersonelId
                },
                new SqlParameter
                {
                    ParameterName = "SatisId",
                    Value = EklenecekSatisPersonel.SatisId
                },



            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_InsertSatisPersonel", SatisPersonelParametreleri, "sp");

            return etkilenenSatir;


        }
        #endregion
    }
}
