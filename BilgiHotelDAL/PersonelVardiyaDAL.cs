using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class PersonelVardiyaDAL
    {
        #region CRUD Operations
        //ID ye göre Personel Vardiya Getir.(select with ID)
        public PersonelVardiyaEntity PersonelVardiyaGetir(int VardiyaId, int PersonelId)
        {
            SqlParameter[] PersonelVardiyaParametreleri =
            {
                new SqlParameter {

                    ParameterName="VardiyaId",
                    Value=VardiyaId

                },
                 new SqlParameter {

                    ParameterName="PersonelId",
                    Value=PersonelId

                },

            };

            SqlDataReader PersonelVardiyaRdr = BilgiHotelHelperSQL.myExecuteReader("sp_PersonelVardiyaGetir", PersonelVardiyaParametreleri, "sp");

            PersonelVardiyaEntity myPersonelVardiya = null;
            while (PersonelVardiyaRdr.Read())
            {
                myPersonelVardiya.VardiyaId = Convert.ToInt32(PersonelVardiyaRdr["VardiyaId"]);
                myPersonelVardiya.PersonelId = Convert.ToInt32(PersonelVardiyaRdr["PersonelId"]);



            }

            return myPersonelVardiya;

        }
        //Tüm Verileri Getir.(All)
        public PersonelVardiyaEntity sp_PersonelVardiyaListesiAll(int VardiyaId, int PersonelId)
        {


            SqlDataReader PersonelVardiyaRdr = BilgiHotelHelperSQL.myExecuteReader("sp_PersonelVardiyaListesiAll", null, "sp");

            PersonelVardiyaEntity myPersonelVardiya = null;
            while (PersonelVardiyaRdr.Read())
            {
                myPersonelVardiya.VardiyaId = Convert.ToInt32(PersonelVardiyaRdr["VardiyaId"]);
                myPersonelVardiya.PersonelId = Convert.ToInt32(PersonelVardiyaRdr["PersonelId"]);



            }

            return myPersonelVardiya;


        }
        //Yeni Personel Vardiya Verisi Gir.(insert)
        public int InsertPersonelVardiya(PersonelVardiyaEntity EklenecekPersonelVardiya)

        {
            SqlParameter[] PersonelVardiyaParametreleri =
           {
                new SqlParameter {

                    ParameterName="VardiyaId",
                    Value=EklenecekPersonelVardiya.VardiyaId

                },
                 new SqlParameter {

                    ParameterName="PersonelId",
                    Value=EklenecekPersonelVardiya.PersonelId

                },



            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_InsertPersonelVardiya ", PersonelVardiyaParametreleri, "sp");

            return etkilenenSatir;


        }
        #endregion
    }
}
