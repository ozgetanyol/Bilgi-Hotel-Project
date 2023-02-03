using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class DillerDAL
    {
        #region CRUD Operations
        //ID ye göre Dil Getir.(select with ID)
        public DilEntity getDilwithID(int DilId)
        {
            SqlParameter[] DilParametreleri =
            {
                new SqlParameter {

                    ParameterName="DilId",
                    Value=DilId

                },
            };

            SqlDataReader DilRdr = BilgiHotelHelperSQL.myExecuteReader("DilListesiwithID", DilParametreleri, "sp");

            DilEntity myDil = null;
            while (DilRdr.Read())
            {
                myDil.DilId = Convert.ToInt32(DilRdr["DilId"]);
                myDil.DilAd = DilRdr["DilAd"].ToString();
                myDil.DilAciklama = DilRdr["DilAciklama"].ToString();
                myDil.DilKod = DilRdr["DilKod"].ToString();


            }
            return myDil;

        }
        //Tüm Dilleri Getir.(All)
        public DilEntity getDilAll(int DilId)
        {

            SqlDataReader DilRdr = BilgiHotelHelperSQL.myExecuteReader("sp_DilListesiAll", null, "sp");

            DilEntity myDil = null;
            while (DilRdr.Read())
            {
                myDil.DilId = Convert.ToInt32(DilRdr["DilId"]);
                myDil.DilAd = DilRdr["DilAd"].ToString();
                myDil.DilAciklama = DilRdr["DilAciklama"].ToString();
                myDil.DilKod = DilRdr["DilKod"].ToString();


            }
            return myDil;

        }
        //Yeni Dil Verisi Gir.(insert)
        public int İnsertDiller(DilEntity EklenecekDiller)

        {
            SqlParameter[] DilParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "DilId",
                    Value = EklenecekDiller.DilId
                },
                new SqlParameter
                {
                    ParameterName = "DilAd",
                    Value = EklenecekDiller.DilAd
                },
                new SqlParameter
                {
                    ParameterName = "DilAciklama",
                    Value = EklenecekDiller.DilAciklama
                },
                 new SqlParameter
                {
                    ParameterName = "DilKod",
                    Value = EklenecekDiller.DilKod
                },

            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_InsertDil", DilParametreleri, "sp");

            return etkilenenSatir;


        }
        //Var olan Dil verisini ID sine göre bul ve değiştir. (update)
        public int UpdateDiller(DilEntity DüzenlenecekDil)

        {
            SqlParameter[] DilParametreleri =
             {
                new SqlParameter
                {
                    ParameterName = "DilId",
                    Value = DüzenlenecekDil.DilId
                },
                new SqlParameter
                {
                    ParameterName = "DilAd",
                    Value = DüzenlenecekDil.DilAd
                },
                new SqlParameter
                {
                    ParameterName = "DilAciklama",
                    Value = DüzenlenecekDil.DilAciklama
                },
                 new SqlParameter
                {
                    ParameterName = "DilKod",
                    Value = DüzenlenecekDil.DilKod
                },
            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_UpdateDiller", DilParametreleri, "sp");

            return etkilenenSatir;
        }
        //Var olan Dil verisini ID sine göre sil. (delete)
        public int DeleteDiller(DilEntity SilinecekDil)
        {
            SqlParameter[] DilParametreleri =
             {
                new SqlParameter {

                    ParameterName="DilId",
                    Value=SilinecekDil.DilId

                },
            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_DeleteDiller", DilParametreleri, "sp");
            return etkilenenSatir;



        }
#endregion
    }
}
