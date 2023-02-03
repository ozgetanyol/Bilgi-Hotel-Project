using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class RezervasyonPersonelDAL
    {
        #region CRUD Operations
        //ID ye göre Rezervasyon Personel Getir.(select with ID)
        public RezervasyonPersonelEntity RezervasyonPersonelGetir(int RezervasyonId, int PersonelId)
        {
            SqlParameter[] RezervasyonPersonelParametreleri =
            {
                new SqlParameter {

                    ParameterName="RezervasyonId",
                    Value=RezervasyonId

                },
                 new SqlParameter {

                    ParameterName="PersonelId",
                    Value=PersonelId

                },

            };

            SqlDataReader RezervasyonPersonelRdr = BilgiHotelHelperSQL.myExecuteReader("sp_RezervasyonPersonelGetir", RezervasyonPersonelParametreleri, "sp");

            RezervasyonPersonelEntity myRezervasyonPersonel = null;
            while (RezervasyonPersonelRdr.Read())
            {
                myRezervasyonPersonel.RezervasyonId = Convert.ToInt32(RezervasyonPersonelRdr["RezervasyonId"]);
                myRezervasyonPersonel.PersonelId = Convert.ToInt32(RezervasyonPersonelRdr["PersonelId"]);



            }
            return myRezervasyonPersonel;

        }
        //Tüm Verileri Getir.(All)
        public RezervasyonPersonelEntity sp_RezervasyonPersonelListesiAll(int RezervasyonId, int PersonelId)
        {

            SqlDataReader RezervasyonPersonelRdr = BilgiHotelHelperSQL.myExecuteReader("sp_RezervasyonPersonelListesiAll", null, "sp");

            RezervasyonPersonelEntity myRezervasyonPersonel = null;
            while (RezervasyonPersonelRdr.Read())
            {
                myRezervasyonPersonel.RezervasyonId = Convert.ToInt32(RezervasyonPersonelRdr["RezervasyonId"]);
                myRezervasyonPersonel.PersonelId = Convert.ToInt32(RezervasyonPersonelRdr["PersonelId"]);



            }
            return myRezervasyonPersonel;

        }
        //Yeni Rezervasyon Personel Verisi Gir.(insert)
        public int InsertRezervasyonPersonel(RezervasyonPersonelEntity EklenecekRezervasyonPersonel)

        {
            SqlParameter[] RezervasyonPersonelParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "RezervasyonId",
                    Value = EklenecekRezervasyonPersonel.RezervasyonId
                },
                new SqlParameter
                {
                    ParameterName = "PersonelId",
                    Value = EklenecekRezervasyonPersonel.PersonelId
                },



            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_InsertRezervasyonPersonel", RezervasyonPersonelParametreleri, "sp");

            return etkilenenSatir;


        }
        #endregion
    }
}
