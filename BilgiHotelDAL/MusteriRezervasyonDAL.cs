using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class MusteriRezervasyonDAL
    {
        #region CRUD Operations
        //ID ye göre Müşteri Rezervasyon Getir.(select with ID)
        public MusteriRezervasyonEntity MusteriRezervasyonGetir(int MusteriId, int RezervasyonId, int MisafirId, int OdaId)
        {
            SqlParameter[] MusteriRezervasyonParametreleri =
            {
                new SqlParameter {

                    ParameterName="MusteriId",
                    Value=MusteriId

                },
                 new SqlParameter {

                    ParameterName="RezervasyonId",
                    Value=RezervasyonId

                },
               new SqlParameter {

                    ParameterName="MisafirId",
                    Value=MisafirId

                },
                new SqlParameter {

                    ParameterName="OdaId",
                    Value=OdaId

                },

            };

            SqlDataReader MusteriRezervasyonRdr = BilgiHotelHelperSQL.myExecuteReader("sp_MusteriRezervasyonGetir", MusteriRezervasyonParametreleri, "sp");

            MusteriRezervasyonEntity myMusteriRezervasyon = null;
            while (MusteriRezervasyonRdr.Read())
            {
                myMusteriRezervasyon.MusteriId = Convert.ToInt32(MusteriRezervasyonRdr["MusteriId"]);
                myMusteriRezervasyon.RezervasyonId = Convert.ToInt32(MusteriRezervasyonRdr["RezervasyonId"]);
                myMusteriRezervasyon.MisafirId = Convert.ToInt32(MusteriRezervasyonRdr["MisafirId"]);
                myMusteriRezervasyon.OdaId = Convert.ToInt32(MusteriRezervasyonRdr["OdaId"]);



            }
            return myMusteriRezervasyon;

        }
        //Tüm Verileri Getir.(All)
        public MusteriRezervasyonEntity sp_MusteriRezervasyonListesiAll(int MusteriId, int RezervasyonId, int MisafirId, int OdaId)
        {

            SqlDataReader MusteriRezervasyonRdr = BilgiHotelHelperSQL.myExecuteReader("sp_MusteriRezervasyonListesiAll", null, "sp");

            MusteriRezervasyonEntity myMusteriRezervasyon = null;
            while (MusteriRezervasyonRdr.Read())
            {
                myMusteriRezervasyon.MusteriId = Convert.ToInt32(MusteriRezervasyonRdr["MusteriId"]);
                myMusteriRezervasyon.RezervasyonId = Convert.ToInt32(MusteriRezervasyonRdr["RezervasyonId"]);
                myMusteriRezervasyon.MisafirId = Convert.ToInt32(MusteriRezervasyonRdr["MisafirId"]);
                myMusteriRezervasyon.OdaId = Convert.ToInt32(MusteriRezervasyonRdr["OdaId"]);



            }
            return myMusteriRezervasyon;

        }
        //Yeni Müşteri Personel Verisi Gir.(insert)
        public int InsertMusteriRezervasyon(MusteriRezervasyonEntity EklenecekMusteriRezervasyon)

        {
            SqlParameter[] MusteriRezervasyonParametreleri =
            {
                new SqlParameter {

                    ParameterName="MusteriId",
                    Value=EklenecekMusteriRezervasyon.MusteriId

                },
                 new SqlParameter {

                    ParameterName="RezervasyonId",
                    Value=EklenecekMusteriRezervasyon.RezervasyonId

                },
               new SqlParameter {

                    ParameterName="MisafirId",
                    Value=EklenecekMusteriRezervasyon.MisafirId

                },
                new SqlParameter {

                    ParameterName="OdaId",
                    Value=EklenecekMusteriRezervasyon.OdaId

                },


            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_InsertMusteriRezervasyon", MusteriRezervasyonParametreleri, "sp");

            return etkilenenSatir;


        }
        #endregion
    }
}
