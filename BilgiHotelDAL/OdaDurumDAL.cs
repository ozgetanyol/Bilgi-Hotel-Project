using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class OdaDurumDAL
    {
        #region CRUD Operations
        //ID ye göre Oda Durum Getir.(select with ID)
        public OdaDurumEntity OdaDurumGetir(int OdaId, int DurumKategoriId)
        {
            SqlParameter[] OdaDurumParametreleri =
            {
                new SqlParameter {

                    ParameterName="OdaId",
                    Value=OdaId

                },
                 new SqlParameter {

                    ParameterName="DurumKategoriId",
                    Value=DurumKategoriId

                },

            };

            SqlDataReader OdaDurumRdr = BilgiHotelHelperSQL.myExecuteReader("sp_OdaDurumGetir", OdaDurumParametreleri, "sp");

            OdaDurumEntity myOdaDurum = null;
            while (OdaDurumRdr.Read())
            {
                myOdaDurum.OdaId = Convert.ToInt32(OdaDurumRdr["OdaId"]);
                myOdaDurum.DurumKategoriId = Convert.ToInt32(OdaDurumRdr["DurumKategoriId"]);



            }

            return myOdaDurum;

        }
        //Tüm Verileri Getir.(All)
        public OdaDurumEntity sp_OdaDurumListesiAll(int OdaId, int DurumKategoriId)
        {


            SqlDataReader OdaDurumRdr = BilgiHotelHelperSQL.myExecuteReader("sp_OdaDurumListesiAll", null, "sp");

            OdaDurumEntity myOdaDurum = null;
            while (OdaDurumRdr.Read())
            {
                myOdaDurum.OdaId = Convert.ToInt32(OdaDurumRdr["OdaId"]);
                myOdaDurum.DurumKategoriId = Convert.ToInt32(OdaDurumRdr["DurumKategoriId"]);



            }

            return myOdaDurum;

        }
        //Yeni Oda Durum  Verisi Gir.(insert)
        public int InsertOdaDurum(OdaDurumEntity EklenecekOdaDurum)

        {
            SqlParameter[] OdaDurumParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "OdaId",
                    Value = EklenecekOdaDurum.OdaId
                },
                new SqlParameter
                {
                    ParameterName = "DurumKategoriId",
                    Value = EklenecekOdaDurum.DurumKategoriId
                },



            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_InsertOdaDurum", OdaDurumParametreleri, "sp");

            return etkilenenSatir;


        }
        #endregion
    }
}
