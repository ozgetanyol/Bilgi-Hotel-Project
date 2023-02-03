using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class PersonelOdaDAL
    {
        #region CRUD Operations
        //ID ye göre Personel Oda Getir.(select with ID)
        public PersonelOdaEntity PersonelOdaGetir(int PersonelId, int OdaId)
        {
            SqlParameter[] PersonelOdaParametreleri =
            {
                new SqlParameter {

                    ParameterName="PersonelId",
                    Value=PersonelId

                },
                 new SqlParameter {

                    ParameterName="OdaId",
                    Value=OdaId

                },

            };

            SqlDataReader PersonelOdaRdr = BilgiHotelHelperSQL.myExecuteReader("sp_PersonelOdaGetir", PersonelOdaParametreleri, "sp");

            PersonelOdaEntity myPersonelOda = null;
            while (PersonelOdaRdr.Read())
            {
                myPersonelOda.PersonelId = Convert.ToInt32(PersonelOdaRdr["PersonelId"]);
                myPersonelOda.OdaId = Convert.ToInt32(PersonelOdaRdr["OdaId"]);

            }

            return myPersonelOda;

        }
        //Tüm Verileri Getir.(All)
        public PersonelOdaEntity sp_PersonelOdaListesiAll(int PersonelId, int OdaId)
        {


            SqlDataReader PersonelOdaRdr = BilgiHotelHelperSQL.myExecuteReader("sp_PersonelOdaListesiAll", null, "sp");

            PersonelOdaEntity myPersonelOda = null;
            while (PersonelOdaRdr.Read())
            {
                myPersonelOda.PersonelId = Convert.ToInt32(PersonelOdaRdr["PersonelId"]);
                myPersonelOda.OdaId = Convert.ToInt32(PersonelOdaRdr["OdaId"]);

            }

            return myPersonelOda;


        }
        //Yeni Personel Dil  Verisi Gir.(insert)
        public int InsertPersonelOda(PersonelOdaEntity EklenecekPersonelOda)

        {
            SqlParameter[] PersonelOdaParametreleri =
           {
                new SqlParameter {

                    ParameterName="PersonelId",
                    Value=EklenecekPersonelOda.PersonelId

                },
                 new SqlParameter {

                    ParameterName="OdaId",
                    Value=EklenecekPersonelOda.OdaId

                },



            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_InsertPersonelOda", PersonelOdaParametreleri, "sp");

            return etkilenenSatir;


        }
        #endregion
    }
}
