using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class DurumKategoriDAL
    {
        #region CRUD Operations
        //ID ye göre Durum Kategori Getir.(select with ID)
        public DurumKategoriEntity getDurumKategoriiwithID(int DurumKategoriId)
        {
            SqlParameter[] DurumKategoriParametreleri =
            {
                new SqlParameter {

                    ParameterName="DurumKategoriId",
                    Value=DurumKategoriId

                },
            };

            SqlDataReader DurumKategoriRdr = BilgiHotelHelperSQL.myExecuteReader("DurumKategoriListesiwithID", DurumKategoriParametreleri, "sp");

            DurumKategoriEntity myDurumKategori = null;
            while (DurumKategoriRdr.Read())
            {
                myDurumKategori.DurumKategoriId = Convert.ToInt32(DurumKategoriRdr["DurumKategoriId"]);
                myDurumKategori.DurumKategoriAd = DurumKategoriRdr["DurumKategoriAd"].ToString();
                myDurumKategori.DurumKategoriAciklama = DurumKategoriRdr["DurumKategoriAciklama"].ToString();

            }
            return myDurumKategori;

        }
        //Tüm Durum Kategorilerini Getir(ALL)
        public DurumKategoriEntity getDurumKategoriAll(int DurumKategoriId)
        {

            SqlDataReader DurumKategoriRdr = BilgiHotelHelperSQL.myExecuteReader(" sp_DurumKategoriListesiAll", null, "sp");

            DurumKategoriEntity myDurumKategori = null;
            while (DurumKategoriRdr.Read())
            {
                myDurumKategori.DurumKategoriId = Convert.ToInt32(DurumKategoriRdr["DurumKategoriId"]);
                myDurumKategori.DurumKategoriAd = DurumKategoriRdr["DurumKategoriAd"].ToString();
                myDurumKategori.DurumKategoriAciklama = DurumKategoriRdr["DurumKategoriAciklama"].ToString();


            }
            return myDurumKategori;

        }
        //Yeni Durum Kategori Verisi Gir.(insert)
        public int İnsertDurumKategori(DurumKategoriEntity EklenecekDurumKategori)

        {
            SqlParameter[] DurumKategoriParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "DurumKategoriId",
                    Value = EklenecekDurumKategori.DurumKategoriId
                },
                new SqlParameter
                {
                    ParameterName = "DurumKategoriAd",
                    Value = EklenecekDurumKategori.DurumKategoriAd
                },
                new SqlParameter
                {
                    ParameterName = "DurumKategoriAciklama",
                    Value = EklenecekDurumKategori.DurumKategoriAciklama
                },


            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_İnsertDurumKategori", DurumKategoriParametreleri, "sp");

            return etkilenenSatir;


        }
        //Var olan Durum Kategori verisini ID sine göre bul ve değiştir. (update)
        public int UpdateDurumKategori(DurumKategoriEntity DüzenlenecekDurumKategori)

        {
            SqlParameter[] DurumKategoriParametreleri =
             {
                new SqlParameter
                {
                    ParameterName = "DurumKategoriId",
                    Value = DüzenlenecekDurumKategori.DurumKategoriId
                },
                new SqlParameter
                {
                    ParameterName = "DurumKategoriAd",
                    Value = DüzenlenecekDurumKategori.DurumKategoriAd
                },
                new SqlParameter
                {
                    ParameterName = "DurumKategoriAciklama",
                    Value = DüzenlenecekDurumKategori.DurumKategoriAciklama
                },




        };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_UpdateOdaDurumKategori", DurumKategoriParametreleri, "sp");

            return etkilenenSatir;
        }
        //Var olan Durum Kategori verisini ID sine göre sil. (delete)
        public int DeleteDurumKategori(DurumKategoriEntity SilinecekDurumKategori)
        {
            SqlParameter[] DurumKategoriParametreleri =
             {
                new SqlParameter {

                    ParameterName="DurumKategoriId",
                    Value=SilinecekDurumKategori.DurumKategoriId

                },
            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_DeleteOdaDurumKategori", DurumKategoriParametreleri, "sp");
            return etkilenenSatir;



        }
        #endregion
    }
}
