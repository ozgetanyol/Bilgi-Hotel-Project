using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class GorevlerDAL
    {
        #region CRUD Operations
        //ID ye göre Görev Getir.(select with ID)
        public GorevlerEntity getGorevwithID(int GorevId)
        {
            SqlParameter[] GorevParametreleri =
            {
                new SqlParameter {

                    ParameterName="GorevId",
                    Value=GorevId

                },
            };

            SqlDataReader GorevRdr = BilgiHotelHelperSQL.myExecuteReader("GorevListesiwithID", GorevParametreleri, "sp");

            GorevlerEntity myGorev = null;
            while (GorevRdr.Read())
            {
                myGorev.GorevId= Convert.ToInt32(GorevRdr["GorevId"]);
                myGorev.GorevAd = GorevRdr["GorevAd"].ToString();
                myGorev.GorevAciklama = GorevRdr["GorevAciklama"].ToString();
                myGorev.GorevIsTanimi= GorevRdr["GorevIsTanimi"].ToString();


            }
            return myGorev;

        }
        //Tüm Görevleri Getir
        public GorevlerEntity getGorevAll(int GorevId)
        {

            SqlDataReader GorevRdr = BilgiHotelHelperSQL.myExecuteReader("sp_GorevListesiAll", null, "sp");

            GorevlerEntity myGorev = null;
            while (GorevRdr.Read())
            {
                myGorev.GorevId = Convert.ToInt32(GorevRdr["GorevId"]);
                myGorev.GorevAd = GorevRdr["GorevAd"].ToString();
                myGorev.GorevAciklama = GorevRdr["GorevAciklama"].ToString();
                myGorev.GorevIsTanimi = GorevRdr["GorevIsTanimi"].ToString();

            }
            return myGorev;

        }
        //Yeni Görev Verisi Gir.(insert)
        public int İnsertGorevler(GorevlerEntity EklenecekGorevler)

        {
            SqlParameter[] GovdeParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "GorevId",
                    Value = EklenecekGorevler.GorevId
                },
                new SqlParameter
                {
                    ParameterName = "GorevAd",
                    Value = EklenecekGorevler.GorevAd
                },
                new SqlParameter
                {
                    ParameterName = "GorevAciklama",
                    Value = EklenecekGorevler.GorevAciklama
                },
                 new SqlParameter
                {
                    ParameterName = "GorevIsTanimi",
                    Value = EklenecekGorevler.GorevIsTanimi
                },

            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_InsertGorevler", GovdeParametreleri, "sp");

            return etkilenenSatir;


        }
        //Var olan Görev verisini ID sine göre bul ve değiştir. (update)
        public int UpdateGorevler(GorevlerEntity DüzenlenecekGorev)

        {
            SqlParameter[] GovdeParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "GorevId",
                    Value = DüzenlenecekGorev.GorevId
                },
                new SqlParameter
                {
                    ParameterName = "GorevAd",
                    Value = DüzenlenecekGorev.GorevAd
                },
                new SqlParameter
                {
                    ParameterName = "GorevAciklama",
                    Value = DüzenlenecekGorev.GorevAciklama
                },
                 new SqlParameter
                {
                    ParameterName = "GorevIsTanimi",
                    Value = DüzenlenecekGorev.GorevIsTanimi
                },

            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_UpdateGorevler", GovdeParametreleri, "sp");

            return etkilenenSatir;
        }
        //Var olan Görev verisini ID sine göre sil. (delete)
        public int DeleteGorevler(GorevlerEntity SilinecekGorev)
        {
            SqlParameter[] GorevParametreleri =
             {
                new SqlParameter {

                    ParameterName="GorevId",
                    Value=SilinecekGorev.GorevId

                },
            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_DeleteGorevler", GorevParametreleri, "sp");
            return etkilenenSatir;



        }
        #endregion
    }
}
