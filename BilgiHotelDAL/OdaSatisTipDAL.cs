using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class OdaSatisTipDAL
    {
        #region CRUD Operations
        //ID ye göre Oda Satış Tip Getir.(select with ID)
        public OdaSatisTipEntity getOdaSatisTipwithID(int OdaSatisTip)
        {
            SqlParameter[] OdaSatisTipParametreleri =
            {
                new SqlParameter {

                    ParameterName="OdaSatisTip",
                    Value=OdaSatisTip

                },
            };

            SqlDataReader OdaSatisTipRdr = BilgiHotelHelperSQL.myExecuteReader("OdaSatisTipListesiWithID", OdaSatisTipParametreleri, "sp");

            OdaSatisTipEntity myOdaSatisTip = null;
            while (OdaSatisTipRdr.Read())
            {
                myOdaSatisTip.OdaSatisTip = Convert.ToInt32(OdaSatisTipRdr["OdaSatisTip"]);
                myOdaSatisTip.OdaSatisTipAd = OdaSatisTipRdr["OdaSatisTipAd"].ToString();
                myOdaSatisTip.OdaSatisTipAciklama = OdaSatisTipRdr["OdaSatisTipAciklama"].ToString();

            }
            return myOdaSatisTip;

        }
        //Tüm Oda Satış Tiplerini Getir. (All)
        public OdaSatisTipEntity getOdaSatisTipAll(int OdaSatisTip)
        {

            SqlDataReader OdaSatisTipRdr = BilgiHotelHelperSQL.myExecuteReader("sp_OdaSatisTipListesiAll", null, "sp");

            OdaSatisTipEntity myOdaSatisTip = null;
            while (OdaSatisTipRdr.Read())
            {
                myOdaSatisTip.OdaSatisTip = Convert.ToInt32(OdaSatisTipRdr["OdaSatisTip"]);
                myOdaSatisTip.OdaSatisTipAd = OdaSatisTipRdr["OdaSatisTipAd"].ToString();
                myOdaSatisTip.OdaSatisTipAciklama = OdaSatisTipRdr["OdaSatisTipAciklama"].ToString();

            }
            return myOdaSatisTip;

        }
        //Yeni Oda Satış Tip Verisi Gir.(insert)
        public int İnsertOdaSatisTip(OdaSatisTipEntity EklenecekOdaSatisTip)

        {
            SqlParameter[] OdaSatisTipParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "OdaSatisTip",
                    Value = EklenecekOdaSatisTip.OdaSatisTip
                },
                new SqlParameter
                {
                    ParameterName = "OdaSatisTipAd",
                    Value = EklenecekOdaSatisTip.OdaSatisTipAd
                },
                new SqlParameter
                {
                    ParameterName = "OdaSatisTipAciklama",
                    Value = EklenecekOdaSatisTip.OdaSatisTipAciklama
                },


            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_InsertOdaSatisTip", OdaSatisTipParametreleri, "sp");

            return etkilenenSatir;


        }
        //Var olan Oda Satış Tip verisini ID sine göre bul ve değiştir. (update)
        public int UpdateOdaSatisTip(OdaSatisTipEntity DüzenlenecekOdaSatisTip)

        {
            SqlParameter[] OdaSatisTipParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "OdaSatisTip",
                    Value = DüzenlenecekOdaSatisTip.OdaSatisTip
                },
                new SqlParameter
                {
                    ParameterName = "OdaSatisTipAd",
                    Value = DüzenlenecekOdaSatisTip.OdaSatisTipAd
                },
                new SqlParameter
                {
                    ParameterName = "OdaSatisTipAciklama",
                    Value = DüzenlenecekOdaSatisTip.OdaSatisTipAciklama
                },
            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_UpdateOdaSatisTip", OdaSatisTipParametreleri, "sp");

            return etkilenenSatir;
        }
        //Var olan Oda Satış Tip verisini ID sine göre sil. (delete)
        public int DeleteOdaSatisTip(OdaSatisTipEntity SilinecekOdaSatisTip)
        {
            SqlParameter[] OdaSatisTipParametreleri =
             {
                new SqlParameter {

                    ParameterName="OdaSatisTip",
                    Value=SilinecekOdaSatisTip.OdaSatisTip

                },
            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_DeleteOdaSatisTip", OdaSatisTipParametreleri, "sp");
            return etkilenenSatir;



        }
        #endregion
    }
}
