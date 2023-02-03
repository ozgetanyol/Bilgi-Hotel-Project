using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class ResimlerDAL
    {
        #region CRUD Operations
        //ID ye göre Resim Getir.(select with ID)
        public ResimlerEntity getResimwithID(int ResimId)
        {
            SqlParameter[] ResimParametreleri =
            {
                new SqlParameter {

                    ParameterName="ResimId",
                    Value=ResimId

                },
            };

            SqlDataReader ResimRdr = BilgiHotelHelperSQL.myExecuteReader("sp_ResimListesiWithID", ResimParametreleri, "sp");

            ResimlerEntity myResim = null;
            while (ResimRdr.Read())
            {
                myResim.ResimId = Convert.ToInt32(ResimRdr["ResimId"]);
                myResim.ResimUrlAdres = ResimRdr["ResimUrlAdres"].ToString();
                myResim.ResimAciklama = ResimRdr["ResimAciklama"].ToString();
                myResim.ResimAktifOk = Convert.ToBoolean(ResimRdr["ResimAktifOk"]);
                myResim.ResimAlternatifText = ResimRdr["ResimAlternatifText"].ToString();


            }
            return myResim;

        }
        //Tüm Resimleri Getir
        public ResimlerEntity getResimAll(int ResimId)
        {

            SqlDataReader ResimRdr = BilgiHotelHelperSQL.myExecuteReader("sp_ResimlerListesiAll", null, "sp");

            ResimlerEntity myResim = null;
            while (ResimRdr.Read())
            {
                myResim.ResimId = Convert.ToInt32(ResimRdr["ResimId"]);
                myResim.ResimUrlAdres = ResimRdr["ResimUrlAdres"].ToString();
                myResim.ResimAciklama = ResimRdr["ResimAciklama"].ToString();
                myResim.ResimAktifOk = Convert.ToBoolean(ResimRdr["ResimAktifOk"]);
                myResim.ResimAlternatifText = ResimRdr["ResimAlternatifText"].ToString();


            }
            return myResim;

        }
        //Yeni Resim Verisi Gir.(insert)
        public int İnsertResimler (ResimlerEntity EklenecekResimler)

        {
            SqlParameter[] ResimParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "ResimId",
                    Value = EklenecekResimler.ResimId
                },
                new SqlParameter
                {
                    ParameterName = "ResimUrlAdres",
                    Value = EklenecekResimler.ResimUrlAdres
                },
                new SqlParameter
                {
                    ParameterName = "ResimAciklama",
                    Value = EklenecekResimler.ResimAciklama
                },
                 new SqlParameter
                {
                    ParameterName = "ResimAktifOk",
                    Value = EklenecekResimler.ResimAktifOk

                },
                  new SqlParameter
                {
                    ParameterName = "ResimAlternatifText",
                    Value = EklenecekResimler.ResimAlternatifText

                },

            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_InsertResimler", ResimParametreleri, "sp");

            return etkilenenSatir;


        }
        //Var olan Resim verisini ID sine göre bul ve değiştir. (update)
        public int UpdateResimler(ResimlerEntity DüzenlenecekResim)

        {
            SqlParameter[] ResimParametreleri =
             {
                new SqlParameter
                {
                    ParameterName = "ResimId",
                    Value = DüzenlenecekResim.ResimId
                },
                new SqlParameter
                {
                    ParameterName = "ResimUrlAdres",
                    Value = DüzenlenecekResim.ResimUrlAdres
                },
                new SqlParameter
                {
                    ParameterName = "ResimAciklama",
                    Value = DüzenlenecekResim.ResimAciklama
                },
                 new SqlParameter
                {
                    ParameterName = "ResimAktifOk",
                    Value = DüzenlenecekResim.ResimAktifOk

                },
                  new SqlParameter
                {
                    ParameterName = "ResimAlternatifText",
                    Value = DüzenlenecekResim.ResimAlternatifText

                },

            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_UpdateResimler", ResimParametreleri, "sp");

            return etkilenenSatir;
        }
        //Var olan Resim verisini ID sine göre sil. (delete)
        public int DeleteResimler(ResimlerEntity SilinecekResim)
        {
            SqlParameter[] ResimParametreleri =
             {
                new SqlParameter {

                    ParameterName="ResimId",
                    Value=SilinecekResim.ResimId

                },
            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_DeleteResimler", ResimParametreleri, "sp");
            return etkilenenSatir;



        }
        #endregion
    }
}
