using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class CinsiyetDAL
    {
        #region CRUD Operations

        //ID ye göre Cinsiyet Getir.(select with ID)
        public CinsiyetEntity getCinsiyetwithID(int CinsiyetId)
        {
            SqlParameter[] CinsiyetParametreleri =
            {
                new SqlParameter {

                    ParameterName="CinsiyetId",
                    Value=CinsiyetId

                },
            };

            SqlDataReader CinsiyetRdr = BilgiHotelHelperSQL.myExecuteReader("CinsiyetListesiwithID", CinsiyetParametreleri, "sp");

            CinsiyetEntity myCinsiyet = null;
            while (CinsiyetRdr.Read())
            {
                myCinsiyet.CinsiyetId = Convert.ToInt32(CinsiyetRdr["CinsiyetId"]);
                myCinsiyet.CinsiyetAd = CinsiyetRdr["CinsiyetAd"].ToString();
                myCinsiyet.CinsiyetAciklama = CinsiyetRdr["CinsiyetAciklama"].ToString();


            }
            return myCinsiyet;

        }

        //Tüm Cinsiyetleri Getir.(select all)
        public CinsiyetEntity getCinsiyetALl(int CinsiyetId)
        {

            SqlDataReader CinsiyetRdr = BilgiHotelHelperSQL.myExecuteReader("sp_CinsiyetListesiAll", null, "sp");

            CinsiyetEntity myCinsiyet = null;
            while (CinsiyetRdr.Read())
            {
                myCinsiyet.CinsiyetId = Convert.ToInt32(CinsiyetRdr["CinsiyetId"]);
                myCinsiyet.CinsiyetAd = CinsiyetRdr["CinsiyetAd"].ToString();
                myCinsiyet.CinsiyetAciklama = CinsiyetRdr["CinsiyetAciklama"].ToString();


            }
            return myCinsiyet;

        }
        //Yeni Cinsiyet Verisi Gir.(insert)
        public int İnsertCinsiyet(CinsiyetEntity EklenecekCinsiyet)

        {
            SqlParameter[] CinsiyetParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "CinsiyetId",
                    Value = EklenecekCinsiyet.CinsiyetId
                },
                new SqlParameter
                {
                    ParameterName = "CinsiyetAd",
                    Value = EklenecekCinsiyet.CinsiyetAd
                },
                new SqlParameter
                {
                    ParameterName = "CinsiyetAciklama",
                    Value = EklenecekCinsiyet.CinsiyetAciklama
                },
            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("İnsertCinsiyet", CinsiyetParametreleri, "sp");

            return etkilenenSatir;


        }
        //Var olan Cinsiyet verisini ID sine göre bul ve değiştir. (update)
        public int UpdateCinsiyet(CinsiyetEntity DüzenlenecekCinsiyet)

        {
            SqlParameter[] CinsiyetParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "CinsiyetId",
                    Value = DüzenlenecekCinsiyet.CinsiyetId
                },
                new SqlParameter
                {
                    ParameterName = "CinsiyetAd",
                    Value = DüzenlenecekCinsiyet.CinsiyetAd
                },
                new SqlParameter
                {
                    ParameterName = "CinsiyetAciklama",
                    Value = DüzenlenecekCinsiyet.CinsiyetAciklama
                },
            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("UpdateCinsiyet", CinsiyetParametreleri, "sp");

            return etkilenenSatir;


        }
        //Var olan Cinsiyet verisini ID sine göre sil. (delete)
        public int DeleteCinsiyet(CinsiyetEntity SilinecekCinsiyet)
        {
            SqlParameter[] CinsiyetParametreleri =
             {
                new SqlParameter {

                    ParameterName="CinsiyetId",
                    Value=SilinecekCinsiyet.CinsiyetId

                },
            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("DeleteCinsiyet", CinsiyetParametreleri, "sp");
            return etkilenenSatir;


            #endregion
        }
    }
}