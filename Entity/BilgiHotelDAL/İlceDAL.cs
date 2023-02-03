using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class İlceDAL
    {
        #region CRUD Operations
        //ID ye göre İlçe Getir.(select with ID)
        public İlceEntity getIlcewithID(int IlceId)
        {
            SqlParameter[] İlceParametreleri =
            {
                new SqlParameter {

                    ParameterName="IlceId",
                    Value=IlceId

                },
            };

            SqlDataReader İlceRdr = BilgiHotelHelperSQL.myExecuteReader("İlceListesiwithID", İlceParametreleri, "sp");

            İlceEntity myİlce = null;
            while (İlceRdr.Read())
            {
                myİlce.IlceId = Convert.ToInt32(İlceRdr["IlceId"]);
                myİlce.IlceAd = İlceRdr["IlceAd"].ToString();
                myİlce.IlceAciklama = İlceRdr["IlceAciklama"].ToString();
                myİlce.IlId = Convert.ToInt32(İlceRdr["IlId"]);


            }
            return myİlce;

        }
        //Tüm İlçeleri Getir
        public İlceEntity getIlceAll(int IlceId)
        {
            SqlDataReader İlceRdr = BilgiHotelHelperSQL.myExecuteReader("sp_IlceListesiAll", null, "sp");

            İlceEntity myİlce = null;
            while (İlceRdr.Read())
            {
                myİlce.IlceId = Convert.ToInt32(İlceRdr["IlceId"]);
                myİlce.IlceAd = İlceRdr["IlceAd"].ToString();
                myİlce.IlceAciklama = İlceRdr["IlceAciklama"].ToString();
                myİlce.IlId = Convert.ToInt32(İlceRdr["IlId"]);


            }
            return myİlce;

        }
        //Yeni İlçe Verisi Gir.(insert)
        public int İnsertIlce(İlceEntity EklenecekIlce)

        {
            SqlParameter[] IlceParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "IlceId",
                    Value = EklenecekIlce.IlceId
                },
                new SqlParameter
                {
                    ParameterName = "IlceAd",
                    Value = EklenecekIlce.IlceAd
                },
                new SqlParameter
                {
                    ParameterName = "IlceAciklama",
                    Value = EklenecekIlce.IlceAciklama
                },
                 new SqlParameter
                {
                    ParameterName = "IlId",
                    Value = EklenecekIlce.IlId
                },

            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_InsertIlce", IlceParametreleri, "sp");

            return etkilenenSatir;


        }
        //Var olan İlçe verisini ID sine göre bul ve değiştir. (update)
        public int UpdateIlce(İlceEntity DüzenlenecekIlce)

        {
            SqlParameter[] IlceParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "IlceId",
                    Value = DüzenlenecekIlce.IlceId
                },
                new SqlParameter
                {
                    ParameterName = "IlceAd",
                    Value = DüzenlenecekIlce.IlceAd
                },
                new SqlParameter
                {
                    ParameterName = "IlceAciklama",
                    Value = DüzenlenecekIlce.IlceAciklama
                },
                 new SqlParameter
                {
                    ParameterName = "IlId",
                    Value = DüzenlenecekIlce.IlId
                },

            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_UpdateIlce ", IlceParametreleri, "sp");

            return etkilenenSatir;
        }
        //Var olan İlçe verisini ID sine göre sil. (delete)
        public int DeleteIlce(İlceEntity SilinecekIlce)
        {
            SqlParameter[] IlceParametreleri =
             {
                new SqlParameter {

                    ParameterName="IlceId",
                    Value=SilinecekIlce.IlceId

                },
            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_DeleteIlce", IlceParametreleri, "sp");
            return etkilenenSatir;



        }
        #endregion
    }
}
