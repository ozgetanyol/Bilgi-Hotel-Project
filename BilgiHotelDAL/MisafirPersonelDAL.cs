using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class MisafirPersonelDAL
    {
        #region CRUD Operations
        //ID ye göre Misafir Personel Getir.(select with ID)
        public MisafirPersonelEntity MisafirPersonelGetir(int MisafirId, int PersonelId)
        {
            SqlParameter[] MisafirPersonelParametreleri =
            {
                new SqlParameter {

                    ParameterName="MisafirId",
                    Value=MisafirId

                },
                 new SqlParameter {

                    ParameterName="PersonelId",
                    Value=PersonelId

                },
                
            };

            SqlDataReader MisafirPersonelRdr = BilgiHotelHelperSQL.myExecuteReader("sp_MisafirPersonelGetir", MisafirPersonelParametreleri, "sp");

            MisafirPersonelEntity myMisafirPersonel = null;
            while (MisafirPersonelRdr.Read())
            {
                myMisafirPersonel.MisafirId = Convert.ToInt32(MisafirPersonelRdr["MisafirId"]);
                myMisafirPersonel.PersonelId = Convert.ToInt32(MisafirPersonelRdr["PersonelId"]);
               


            }
            return myMisafirPersonel;

        }
        //Tüm Verileri Getir.(All)
        public MisafirPersonelEntity sp_MisafirPersonelListesiAll(int MisafirId, int PersonelId)
        {

            SqlDataReader MisafirPersonelRdr = BilgiHotelHelperSQL.myExecuteReader("sp_MisafirPersonelListesiAll", null, "sp");

            MisafirPersonelEntity myMisafirPersonel = null;
            while (MisafirPersonelRdr.Read())
            {
                myMisafirPersonel.MisafirId = Convert.ToInt32(MisafirPersonelRdr["MisafirId"]);
                myMisafirPersonel.PersonelId = Convert.ToInt32(MisafirPersonelRdr["PersonelId"]);



            }
            return myMisafirPersonel;

        }
        //Yeni Misafir Personel Verisi Gir.(insert)
        public int InsertMisafirPersonel(MisafirPersonelEntity EklenecekMisafirPersonel)

        {
           
                SqlParameter[] MisafirPersonelParametreleri =
            {
                new SqlParameter {

                    ParameterName="MisafirId",
                    Value=EklenecekMisafirPersonel.MisafirId

                },
                 new SqlParameter {

                    ParameterName="PersonelId",
                    Value=EklenecekMisafirPersonel.PersonelId

                },


            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_İnsertMisafirPersonel", MisafirPersonelParametreleri, "sp");

            return etkilenenSatir;


        }
        #endregion
    }
}
