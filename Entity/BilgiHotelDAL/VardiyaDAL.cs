using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class VardiyaDAL
    {
        #region CRUD Operations
        //ID ye göre Vardiya Getir.(select with ID)
        public VardiyalarEntity getVardiyaiwithID(int VardiyaId)
        {
            SqlParameter[] VardiyaParametreleri =
            {
                new SqlParameter {

                    ParameterName="VardiyaId",
                    Value=VardiyaId

                },
            };

            SqlDataReader VardiyaRdr = BilgiHotelHelperSQL.myExecuteReader("VardiyaListesiwithID", VardiyaParametreleri, "sp");

            VardiyalarEntity myVardiya = null;
            while (VardiyaRdr.Read())
            {
                myVardiya.VardiyaId = Convert.ToInt32(VardiyaRdr["VardiyaId"]);
                myVardiya.VardiyaTipi = VardiyaRdr["VardiyaTipi"].ToString();
                myVardiya.VardiyaBaslangicSaati = TimeSpan.Parse(VardiyaRdr["VardiyaBaslangicSaati"].ToString());
                myVardiya.VardiyaBitisSaati = TimeSpan.Parse(VardiyaRdr["VardiyaBitisSaati"].ToString());
            }
            return myVardiya;

        }
        //Tüm Vardiyaları Getir(ALL)
        public VardiyalarEntity getVardiyaAll(int VardiyaId)
        {

            SqlDataReader VardiyaRdr = BilgiHotelHelperSQL.myExecuteReader("sp_VardiyaListesiAll", null, "sp");

            VardiyalarEntity myVardiya = null;
            while (VardiyaRdr.Read())
            {
                myVardiya.VardiyaId = Convert.ToInt32(VardiyaRdr["VardiyaId"]);
                myVardiya.VardiyaTipi = VardiyaRdr["VardiyaTipi"].ToString();
                myVardiya.VardiyaBaslangicSaati = TimeSpan.Parse(VardiyaRdr["VardiyaBaslangicSaati"].ToString());
                myVardiya.VardiyaBitisSaati = TimeSpan.Parse(VardiyaRdr["VardiyaBitisSaati"].ToString());
            }
            return myVardiya;

        }
        //Yeni Vardiya Verisi Gir.(insert)
        public int İnsertVardiya(VardiyalarEntity EklenecekVardiya)

        {
            SqlParameter[] VardiyaParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "VardiyaId",
                    Value = EklenecekVardiya.VardiyaId
                },
                new SqlParameter
                {
                    ParameterName = "VardiyaTipi",
                    Value = EklenecekVardiya.VardiyaTipi
                },
                new SqlParameter
                {
                    ParameterName = "VardiyaBaslangicSaati",
                    Value = EklenecekVardiya.VardiyaBaslangicSaati
                },
                 new SqlParameter
                {
                    ParameterName = "VardiyaBitisSaati",
                    Value = EklenecekVardiya.VardiyaBitisSaati
                },


            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_InsertVardiyalar", VardiyaParametreleri, "sp");

            return etkilenenSatir;


        }
        //Var olan Vardiya verisini ID sine göre bul ve değiştir. (update)
        public int UpdateVardiya(VardiyalarEntity DüzenlenecekVardiya)

        {
            SqlParameter[] VardiyaParametreleri =
           {
                new SqlParameter
                {
                    ParameterName = "VardiyaId",
                    Value = DüzenlenecekVardiya.VardiyaId
                },
                new SqlParameter
                {
                    ParameterName = "VardiyaTipi",
                    Value = DüzenlenecekVardiya.VardiyaTipi
                },
                new SqlParameter
                {
                    ParameterName = "VardiyaBaslangicSaati",
                    Value = DüzenlenecekVardiya.VardiyaBaslangicSaati
                },
                 new SqlParameter
                {
                    ParameterName = "VardiyaBitisSaati",
                    Value = DüzenlenecekVardiya.VardiyaBitisSaati
                },




        };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_UpdateVardiya", VardiyaParametreleri, "sp");

            return etkilenenSatir;
        }
        //Var olan Vardiya verisini ID sine göre sil. (delete)
        public int DeleteVardiya(VardiyalarEntity SilinecekVardiya)
        {
            SqlParameter[] VardiyaParametreleri =
             {
                new SqlParameter {

                    ParameterName="VardiyaId",
                    Value=SilinecekVardiya.VardiyaId

                },
            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_DeleteVardiya", VardiyaParametreleri, "sp");
            return etkilenenSatir;



        }
        #endregion
    }
}
