using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class MusteriPersonelDAL
    {
        #region CRUD Operations
        //ID ye göre Müşteri Personel Getir.(select with ID)
        public MusteriPersonelEntity MusteriPersonelGetir(int MusteriId, int PersonelId)
        {
            SqlParameter[] MusteriPersonelParametreleri =
            {
                new SqlParameter {

                    ParameterName="MusteriId",
                    Value=MusteriId

                },
                 new SqlParameter {

                    ParameterName="PersonelId",
                    Value=PersonelId

                },
                
            };

            SqlDataReader MusteriPersonelRdr = BilgiHotelHelperSQL.myExecuteReader("sp_MusteriPersonelGetir", MusteriPersonelParametreleri, "sp");

            MusteriPersonelEntity myMusteriPersonel = null;
            while (MusteriPersonelRdr.Read())
            {
                myMusteriPersonel.MusteriId = Convert.ToInt32(MusteriPersonelRdr["MusteriId"]);
                myMusteriPersonel.PersonelId = Convert.ToInt32(MusteriPersonelRdr["PersonelId"]);
              


            }
            return myMusteriPersonel;

        }
        //Tüm Verileri Getir.(All)
        public MusteriPersonelEntity sp_MusteriPersonelListesiAll(int MusteriId, int PersonelId)
        {

            SqlDataReader MusteriPersonelRdr = BilgiHotelHelperSQL.myExecuteReader("sp_MusteriPersonelListesiAll", null, "sp");

            MusteriPersonelEntity myMusteriPersonel = null;
            while (MusteriPersonelRdr.Read())
            {
                myMusteriPersonel.MusteriId = Convert.ToInt32(MusteriPersonelRdr["MusteriId"]);
                myMusteriPersonel.PersonelId = Convert.ToInt32(MusteriPersonelRdr["PersonelId"]);



            }
            return myMusteriPersonel;

        }
        //Yeni Müşteri Personel Verisi Gir.(insert)
        public int InsertMusteriPersonel(MusteriPersonelEntity EklenecekMusteriPersonel)

        {
            SqlParameter[] MusteriPersonelParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "MusteriId",
                    Value = EklenecekMusteriPersonel.MusteriId
                },
                new SqlParameter
                {
                    ParameterName = "PersonelId",
                    Value = EklenecekMusteriPersonel.PersonelId
                },
               


            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_InsertMusteriPersonel", MusteriPersonelParametreleri, "sp");

            return etkilenenSatir;


        }
        #endregion
    }
}
