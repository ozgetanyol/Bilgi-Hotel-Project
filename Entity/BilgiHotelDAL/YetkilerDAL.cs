using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class YetkilerDAL

    {
        #region CRUD Operations
        //ID ye göre Yetki Getir.(select with ID)
        public YetkilerEntity getYetkiwithID(int YetkiId)
        {
            SqlParameter[] YetkiParametreleri =
            {
                new SqlParameter {

                    ParameterName="YetkiId",
                    Value=YetkiId

                },
            };

            SqlDataReader YetkiRdr = BilgiHotelHelperSQL.myExecuteReader("YetkiListesiwithID", YetkiParametreleri, "sp");

            YetkilerEntity myYetki = null;
            while (YetkiRdr.Read())
            {
                myYetki.YetkiId = Convert.ToInt32(YetkiRdr["YetkiId"]);
                myYetki.YetkiAd = YetkiRdr["YetkiAd"].ToString();
                myYetki.YetkiAciklama = YetkiRdr["YetkiAciklama"].ToString();
                myYetki.YetkiGuvenlikKod = YetkiRdr["YetkiGuvenlikKod"].ToString();
                myYetki.YetkiAccessKod = YetkiRdr["YetkiAccessKod"].ToString();


            }
            return myYetki;

        }
        //Tüm Yetkileri Getir(ALL)
        public YetkilerEntity getYetkiAll(int YetkiId)
        {

            SqlDataReader YetkiRdr = BilgiHotelHelperSQL.myExecuteReader("sp_YetkiListesiAll", null, "sp");

            YetkilerEntity myYetki = null;
            while (YetkiRdr.Read())
            {
                myYetki.YetkiId = Convert.ToInt32(YetkiRdr["YetkiId"]);
                myYetki.YetkiAd = YetkiRdr["YetkiAd"].ToString();
                myYetki.YetkiAciklama = YetkiRdr["YetkiAciklama"].ToString();
                myYetki.YetkiGuvenlikKod = YetkiRdr["YetkiGuvenlikKod"].ToString();
                myYetki.YetkiAccessKod = YetkiRdr["YetkiAccessKod"].ToString();


            }
            return myYetki;
        }
        //Yeni Yetki Verisi Gir.(insert)
        public int İnsertYetki(YetkilerEntity EklenecekYetki)

        {
            SqlParameter[] YetkiParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "YetkiId",
                    Value = EklenecekYetki.YetkiId
                },
                new SqlParameter
                {
                    ParameterName = "YetkiAd",
                    Value = EklenecekYetki.YetkiAd
                },
                new SqlParameter
                {
                    ParameterName = "YetkiAciklama",
                    Value = EklenecekYetki.YetkiAciklama
                },
                  new SqlParameter
                {
                    ParameterName = "YetkiGuvenlikKod",
                    Value = EklenecekYetki.YetkiGuvenlikKod
                },

                    new SqlParameter
                {
                    ParameterName = "YetkiAccessKod",
                    Value = EklenecekYetki.YetkiAccessKod
                },



            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_InsertYetkiler", YetkiParametreleri, "sp");

            return etkilenenSatir;


        }
        //Var olan Yetki verisini ID sine göre bul ve değiştir. (update)
        public int UpdateYetki(YetkilerEntity DüzenlenecekYetki)

        {
            SqlParameter[] YetkiParametreleri =
             {
                new SqlParameter
                {
                    ParameterName = "YetkiId",
                    Value = DüzenlenecekYetki.YetkiId
                },
                new SqlParameter
                {
                    ParameterName = "YetkiAd",
                    Value = DüzenlenecekYetki.YetkiAd
                },
                new SqlParameter
                {
                    ParameterName = "YetkiAciklama",
                    Value = DüzenlenecekYetki.YetkiAciklama
                },
                  new SqlParameter
                {
                    ParameterName = "YetkiGuvenlikKod",
                    Value = DüzenlenecekYetki.YetkiGuvenlikKod
                },

                    new SqlParameter
                {
                    ParameterName = "YetkiAccessKod",
                    Value = DüzenlenecekYetki.YetkiAccessKod
                },





        };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_UpdateYetkiler", YetkiParametreleri, "sp");

            return etkilenenSatir;
        }
        //Var olan Yetki verisini ID sine göre sil. (delete)
        public int DeleteYetki(YetkilerEntity SilinecekYetki)
        {
            SqlParameter[] YetkiParametreleri =
             {
                new SqlParameter {

                    ParameterName="YetkiId",
                    Value=SilinecekYetki.YetkiId

                },
            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_DeleteYetkiler", YetkiParametreleri, "sp");
            return etkilenenSatir;



        }
        #endregion

    }
}

