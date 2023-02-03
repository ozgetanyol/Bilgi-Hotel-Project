using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class OdaResimlerDAL
    {
        #region CRUD Operations
        //ID ye göre Oda Resim Getir.(select with ID)
        public OdaResimlerEntity OdaResimGetir(int OdaId, int ResimId)
        {
            SqlParameter[] OdaResimParametreleri =
            {
                new SqlParameter {

                    ParameterName="OdaId",
                    Value=OdaId

                },
                 new SqlParameter {

                    ParameterName="ResimId",
                    Value=ResimId

                },

            };

            SqlDataReader OdaResimRdr = BilgiHotelHelperSQL.myExecuteReader("sp_OdaResimGetir", OdaResimParametreleri, "sp");

            OdaResimlerEntity myOdaResim = null;
            while (OdaResimRdr.Read())
            {
                myOdaResim.OdaId = Convert.ToInt32(OdaResimRdr["OdaId"]);
                myOdaResim.ResimId = Convert.ToInt32(OdaResimRdr["ResimId"]);



            }

            return myOdaResim;

        }
        //Tüm Verileri Getir.(All)
        public OdaResimlerEntity sp_OdaResimListesiAll(int OdaId, int ResimId)
        {


            SqlDataReader OdaResimRdr = BilgiHotelHelperSQL.myExecuteReader("sp_OdaResimListesiAll", null, "sp");

            OdaResimlerEntity myOdaResim = null;
            while (OdaResimRdr.Read())
            {
                myOdaResim.OdaId = Convert.ToInt32(OdaResimRdr["OdaId"]);
                myOdaResim.ResimId = Convert.ToInt32(OdaResimRdr["ResimId"]);



            }

            return myOdaResim;


        }
        //Yeni Oda Durum  Verisi Gir.(insert)
        public int InsertOdaResim(OdaResimlerEntity EklenecekOdaResim)

        {
            SqlParameter[] OdaResimParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "OdaId",
                    Value = EklenecekOdaResim.OdaId
                },
                new SqlParameter
                {
                    ParameterName = "ResimId",
                    Value = EklenecekOdaResim.ResimId
                },



            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_InsertOdaResimler", OdaResimParametreleri, "sp");

            return etkilenenSatir;


        }
        #endregion
    }
}
