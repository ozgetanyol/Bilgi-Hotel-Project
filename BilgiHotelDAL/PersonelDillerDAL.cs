using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class PersonelDillerDAL
    {
        #region CRUD Operations
        //ID ye göre Personel Dil Getir.(select with ID)
        public PersonelDillerEntity PersonelDilGetir(int PersonelId, int DilId )
        {
            SqlParameter[] PersonelDilParametreleri =
            {
                new SqlParameter {

                    ParameterName="PersonelId",
                    Value=PersonelId

                },
                 new SqlParameter {

                    ParameterName="DilId",
                    Value=DilId

                },

            };

            SqlDataReader PersonelDilRdr = BilgiHotelHelperSQL.myExecuteReader("sp_PersonelDilGetir", PersonelDilParametreleri, "sp");

            PersonelDillerEntity myPersonelDil = null;
            while (PersonelDilRdr.Read())
            {
                myPersonelDil.PersonelId = Convert.ToInt32(PersonelDilRdr["PersonelId"]);
                myPersonelDil.DilId = Convert.ToInt32(PersonelDilRdr["DilId"]);



            }

            return myPersonelDil;

        }
        //Tüm Verileri Getir.(All)
        public PersonelDillerEntity sp_PersonelDilListesiAll(int PersonelId, int DilId)
        {


            SqlDataReader PersonelDilRdr = BilgiHotelHelperSQL.myExecuteReader("sp_PersonelDilListesiAll", null, "sp");

            PersonelDillerEntity myPersonelDil = null;
            while (PersonelDilRdr.Read())
            {
                myPersonelDil.PersonelId = Convert.ToInt32(PersonelDilRdr["PersonelId"]);
                myPersonelDil.DilId = Convert.ToInt32(PersonelDilRdr["DilId"]);



            }

            return myPersonelDil;


        }
        //Yeni Personel Dil  Verisi Gir.(insert)
        public int InsertPersonelDil(PersonelDillerEntity EklenecekPersonelDil)

        {
            SqlParameter[] PersonelDilParametreleri =
           {
                new SqlParameter {

                    ParameterName="PersonelId",
                    Value=EklenecekPersonelDil.PersonelId

                },
                 new SqlParameter {

                    ParameterName="DilId",
                    Value=EklenecekPersonelDil.DilId

                },



            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_InsertPersonelDil", PersonelDilParametreleri, "sp");

            return etkilenenSatir;


        }
        #endregion
    }
}
