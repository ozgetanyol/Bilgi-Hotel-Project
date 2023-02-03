using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class SehirDAL
    {
        #region CRUD Operations
        //ID ye göre Şehir Getir.(select with ID)
        public SehirEntity getIlwithID(int IlId)
        {
            SqlParameter[] IlParametreleri =
            {
                new SqlParameter {

                    ParameterName="IlId",
                    Value=IlId

                },
            };

            SqlDataReader IlRdr = BilgiHotelHelperSQL.myExecuteReader("sp_IlListesiWithID", IlParametreleri, "sp");

            SehirEntity myIl = null;
            while (IlRdr.Read())
            {
                myIl.IlId = Convert.ToInt32(IlRdr["IlId"]);
                myIl.IlAd = IlRdr["IlAd"].ToString();
                myIl.IlAciklama = IlRdr["IlAciklama"].ToString();
                myIl.UlkeId = Convert.ToInt32(IlRdr["UlkeId"]);


            }
            return myIl;

        }
        //Tüm Şehirleri Getir
        public SehirEntity getIlAll(int IlId)
        {

            SqlDataReader IlRdr = BilgiHotelHelperSQL.myExecuteReader("sp_IlListesiAll", null, "sp");

            SehirEntity myIl = null;
            while (IlRdr.Read())
            {
                myIl.IlId = Convert.ToInt32(IlRdr["IlId"]);
                myIl.IlAd = IlRdr["IlAd"].ToString();
                myIl.IlAciklama = IlRdr["IlAciklama"].ToString();
                myIl.UlkeId = Convert.ToInt32(IlRdr["UlkeId"]);


            }
            return myIl;

        }
        //Yeni Şehir Verisi Gir.(insert)
        public int İnsertIl(SehirEntity EklenecekIl)

        {
            SqlParameter[] IlParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "IlId",
                    Value = EklenecekIl.IlId
                },
                new SqlParameter
                {
                    ParameterName = "IlAd",
                    Value = EklenecekIl.IlAd
                },
                new SqlParameter
                {
                    ParameterName = "IlAciklama",
                    Value = EklenecekIl.IlAciklama
                },
                 new SqlParameter
                {
                    ParameterName = "UlkeId",
                    Value = EklenecekIl.UlkeId
                },

            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_InsertIl", IlParametreleri, "sp");

            return etkilenenSatir;


        }
        //Var olan Şehir verisini ID sine göre bul ve değiştir. (update)
        public int UpdateIl(SehirEntity DüzenlenecekIl)

        {
            SqlParameter[] IlParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "IlId",
                    Value = DüzenlenecekIl.IlId
                },
                new SqlParameter
                {
                    ParameterName = "IlAd",
                    Value = DüzenlenecekIl.IlAd
                },
                new SqlParameter
                {
                    ParameterName = "IlAciklama",
                    Value = DüzenlenecekIl.IlAciklama
                },
                 new SqlParameter
                {
                    ParameterName = "UlkeId",
                    Value = DüzenlenecekIl.UlkeId
                },

            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_UpdateIl", IlParametreleri, "sp");

            return etkilenenSatir;
        }
        //Var olan Şehir verisini ID sine göre sil. (delete)
        public int DeleteIl(SehirEntity SilinecekIl)
        {
            SqlParameter[] IlParametreleri =
             {
                new SqlParameter {

                    ParameterName="IlId",
                    Value=SilinecekIl.IlId

                },
            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_DeleteIl", IlParametreleri, "sp");
            return etkilenenSatir;



        }
        #endregion
    }
}
