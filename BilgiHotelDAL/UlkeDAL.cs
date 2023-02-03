using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class UlkeDAL
    {
        #region CRUD Operations
        //ID ye göre Ülke Getir.(select with ID)
        public UlkeEntity getUlkewithID(int UlkeId)
        {
            SqlParameter[] UlkeParametreleri =
            {
                new SqlParameter {

                    ParameterName="UlkeId",
                    Value=UlkeId

                },
            };

            SqlDataReader UlkeRdr = BilgiHotelHelperSQL.myExecuteReader("UlkeListesiWithID", UlkeParametreleri, "sp");

            UlkeEntity myUlke = null;
            while (UlkeRdr.Read())
            {
                myUlke.UlkeId = Convert.ToInt32(UlkeRdr["UlkeId"]);
                myUlke.UlkeAd = UlkeRdr["UlkeAd"].ToString();
                myUlke.UlkeKisaKod = UlkeRdr["UlkeKisaKod"].ToString();
                myUlke.UlkeTelefonKod = UlkeRdr["UlkeTelefonKod"].ToString();


            }
            return myUlke;

        }
        //Tüm Ülkeleri Getir.(All)
        public UlkeEntity sp_UlkeListesiAll(int GorevId)
        {

            SqlDataReader UlkeRdr = BilgiHotelHelperSQL.myExecuteReader("sp_UlkeListesiAll", null, "sp");

            UlkeEntity myUlke = null;
            while (UlkeRdr.Read())
            {
                myUlke.UlkeId = Convert.ToInt32(UlkeRdr["UlkeId"]);
                myUlke.UlkeAd = UlkeRdr["UlkeAd"].ToString();
                myUlke.UlkeKisaKod = UlkeRdr["UlkeKisaKod"].ToString();
                myUlke.UlkeTelefonKod = UlkeRdr["UlkeTelefonKod"].ToString();


            }
            return myUlke;

        }
        //Yeni Ülke Verisi Gir.(insert)
        public int İnsertUlke(UlkeEntity EklenecekUlke)

        {
            SqlParameter[] UlkeParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "UlkeId",
                    Value = EklenecekUlke.UlkeId
                },
                new SqlParameter
                {
                    ParameterName = "UlkeAd",
                    Value = EklenecekUlke.UlkeAd
                },
                new SqlParameter
                {
                    ParameterName = "UlkeKisaKod",
                    Value = EklenecekUlke.UlkeKisaKod
                },
                 new SqlParameter
                {
                    ParameterName = "UlkeTelefonKod",
                    Value = EklenecekUlke.UlkeTelefonKod
                },

            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_InsertUlke", UlkeParametreleri, "sp");

            return etkilenenSatir;


        }
        //Var olan Ülke verisini ID sine göre bul ve değiştir. (update)
        public int UpdateUlke(UlkeEntity DüzenlenecekUlke)

        {
            SqlParameter[] UlkeParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "UlkeId",
                    Value = DüzenlenecekUlke.UlkeId
                },
                new SqlParameter
                {
                    ParameterName = "UlkeAd",
                    Value = DüzenlenecekUlke.UlkeAd
                },
                new SqlParameter
                {
                    ParameterName = "UlkeKisaKod",
                    Value = DüzenlenecekUlke.UlkeKisaKod
                },
                 new SqlParameter
                {
                    ParameterName = "UlkeTelefonKod",
                    Value = DüzenlenecekUlke.UlkeTelefonKod
                },

            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_UpdateUlke ", UlkeParametreleri, "sp");

            return etkilenenSatir;
        }
        //Var olan Görev verisini ID sine göre sil. (delete)
        public int DeleteUlke(UlkeEntity SilinecekUlke)
        {
            SqlParameter[] UlkeParametreleri =
             {
                new SqlParameter {

                    ParameterName="UlkeId",
                    Value=SilinecekUlke.UlkeId

                },
            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_DeleteUlke", UlkeParametreleri, "sp");
            return etkilenenSatir;



        }
        #endregion
    }
}
