using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class OdaTipiDAL
    {
        #region CRUD Operations
        //ID ye göre Oda Tipi Getir.(select with ID)
        public OdaTipiEntity getOdaTipiwithID(int OdaTipiId)
        {
            SqlParameter[] OdaTipiParametreleri =
            {
                new SqlParameter {

                    ParameterName="OdaTipiId",
                    Value=OdaTipiId

                },
            };

            SqlDataReader OdaTipiRdr = BilgiHotelHelperSQL.myExecuteReader("OdaTipiListesiWithID", OdaTipiParametreleri, "sp");

            OdaTipiEntity myOdaTip = null;
            while (OdaTipiRdr.Read())
            {
                myOdaTip.OdaTipiId = Convert.ToInt32(OdaTipiRdr["OdaTipiId"]);
                myOdaTip.OdaTipiAd = OdaTipiRdr["OdaTipiAd"].ToString();
                myOdaTip.OdaTipiAciklama = OdaTipiRdr["OdaTipiAciklama"].ToString();

            }
            return myOdaTip;

        }
        //Tüm Oda Tiplerini Getir. (All)
        public OdaTipiEntity getOdaTipAll(int OdaTipiId)
        {

            SqlDataReader OdaTipiRdr = BilgiHotelHelperSQL.myExecuteReader("sp_OdaTipiListesiAll", null, "sp");

            OdaTipiEntity myOdaTip = null;
            while (OdaTipiRdr.Read())
            {
                myOdaTip.OdaTipiId = Convert.ToInt32(OdaTipiRdr["OdaTipiId"]);
                myOdaTip.OdaTipiAd = OdaTipiRdr["OdaTipiAd"].ToString();
                myOdaTip.OdaTipiAciklama = OdaTipiRdr["OdaTipiAciklama"].ToString();

            }
            return myOdaTip;

        }
        //Yeni Oda Tipi Verisi Gir.(insert)
        public int İnsertOdaTipi(OdaTipiEntity EklenecekOdaTipi)

        {
            SqlParameter[] OdaTipiParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "OdaTipiId",
                    Value = EklenecekOdaTipi.OdaTipiId
                },
                new SqlParameter
                {
                    ParameterName = "OdaTipiAd",
                    Value = EklenecekOdaTipi.OdaTipiAd
                },
                new SqlParameter
                {
                    ParameterName = "OdaTipiAciklama",
                    Value = EklenecekOdaTipi.OdaTipiAciklama
                },


            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_InsertOdaTipi", OdaTipiParametreleri, "sp");

            return etkilenenSatir;


        }
        //Var olan Oda Tipi verisini ID sine göre bul ve değiştir. (update)
        public int UpdateOdaTipi(OdaTipiEntity DüzenlenecekOdaTipi)

        {
            SqlParameter[] OdaTipiParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "OdaTipiId",
                    Value = DüzenlenecekOdaTipi.OdaTipiId
                },
                new SqlParameter
                {
                    ParameterName = "OdaTipiAd",
                    Value = DüzenlenecekOdaTipi.OdaTipiAd
                },
                new SqlParameter
                {
                    ParameterName = "OdaTipiAciklama",
                    Value = DüzenlenecekOdaTipi.OdaTipiAciklama
                },

            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_UpdateOdaTipi", OdaTipiParametreleri, "sp");

            return etkilenenSatir;
        }
        //Var olan Oda Tipi verisini ID sine göre sil. (delete)
        public int DeleteOdaTipi(OdaTipiEntity SilinecekOdaTipi)
        {
            SqlParameter[] OdaTipiParametreleri =
             {
                new SqlParameter {

                    ParameterName="OdaTipiId",
                    Value=SilinecekOdaTipi.OdaTipiId

                },
            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_DeleteOdaTipi", OdaTipiParametreleri, "sp");
            return etkilenenSatir;



        }
        #endregion
    }
}
