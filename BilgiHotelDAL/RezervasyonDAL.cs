using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class RezervasyonDAL
    {
        #region CRUD Operations
        //ID ye göre Rezervasyon Getir.(select with ID)
        public RezervasyonEntity getRezervasyonwithID(int RezervasyonId)
        {
            SqlParameter[] RezervasyonParametreleri =
            {
                new SqlParameter {

                    ParameterName="KonaklamaTipNo",
                    Value=RezervasyonId

                },
            };

            SqlDataReader RezervasyonRdr = BilgiHotelHelperSQL.myExecuteReader("RezervasyonListesiwithID", RezervasyonParametreleri, "sp");

            RezervasyonEntity myRezervasyon = null;
            while (RezervasyonRdr.Read())
            {
                myRezervasyon.RezervasyonId = Convert.ToInt32(RezervasyonRdr["RezervasyonId"]);
                myRezervasyon.MusteriId = Convert.ToInt32(RezervasyonRdr["MusteriId"]);
                myRezervasyon.RezervasyonGecerlilikTarihi = Convert.ToDateTime(RezervasyonRdr["RezervasyonGecerlilikTarihi"]);
                myRezervasyon.RezervasyonGecerlilikSonTarihi = Convert.ToDateTime(RezervasyonRdr["RezervasyonGecerlilikSonTarihi"]);
                myRezervasyon.ErkenRezervasyonIndirim = Convert.ToInt32(RezervasyonRdr["ErkenRezervasyonIndirim"]);
                myRezervasyon.RezervasyonTipiId = Convert.ToInt32(RezervasyonRdr["RezervasyonTipiId"]);
                myRezervasyon.RezervasyonAciklama = RezervasyonRdr["RezervasyonAciklama"].ToString();
                myRezervasyon.RezervasyonIptalOk = Convert.ToBoolean(RezervasyonRdr["RezervasyonIptalOk"]);

            }
            return myRezervasyon;

        }
        //Tüm Rezervasyonları Getir(ALL)
        public RezervasyonEntity getRezervasyonAll(int RezervasyonId)
        {


            SqlDataReader RezervasyonRdr = BilgiHotelHelperSQL.myExecuteReader("sp_RezervasyonListesiAll", null, "sp");

            RezervasyonEntity myRezervasyon = null;
            while (RezervasyonRdr.Read())
            {
                myRezervasyon.RezervasyonId = Convert.ToInt32(RezervasyonRdr["RezervasyonId"]);
                myRezervasyon.MusteriId = Convert.ToInt32(RezervasyonRdr["MusteriId"]);
                myRezervasyon.RezervasyonGecerlilikTarihi = Convert.ToDateTime(RezervasyonRdr["RezervasyonGecerlilikTarihi"]);
                myRezervasyon.RezervasyonGecerlilikSonTarihi = Convert.ToDateTime(RezervasyonRdr["RezervasyonGecerlilikSonTarihi"]);
                myRezervasyon.ErkenRezervasyonIndirim = Convert.ToInt32(RezervasyonRdr["ErkenRezervasyonIndirim"]);
                myRezervasyon.RezervasyonTipiId = Convert.ToInt32(RezervasyonRdr["RezervasyonTipiId"]);
                myRezervasyon.RezervasyonAciklama = RezervasyonRdr["RezervasyonAciklama"].ToString();
                myRezervasyon.RezervasyonIptalOk = Convert.ToBoolean(RezervasyonRdr["RezervasyonIptalOk"]);

            }
            return myRezervasyon;


        }
        //Yeni Rezervasyon Verisi Gir.(insert)
        public int İnsertRezervasyon(RezervasyonEntity EklenecekRezervasyon)

        {
            SqlParameter[] RezervasyonParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "RezervasyonId",
                    Value = EklenecekRezervasyon.RezervasyonId
                },
                new SqlParameter
                {
                    ParameterName = "MusteriId",
                    Value = EklenecekRezervasyon.MusteriId
                },
                new SqlParameter
                {
                    ParameterName = "RezervasyonGecerlilikTarihi",
                    Value = EklenecekRezervasyon.RezervasyonGecerlilikTarihi
                },
                  new SqlParameter
                {
                    ParameterName = "RezervasyonGecerlilikSonTarihi",
                    Value = EklenecekRezervasyon.RezervasyonGecerlilikSonTarihi
                },
                   new SqlParameter
                {
                    ParameterName = "ErkenRezervasyonIndirim",
                    Value = EklenecekRezervasyon.ErkenRezervasyonIndirim
                },
                    new SqlParameter
                {
                    ParameterName = "RezervasyonTipiId",
                    Value = EklenecekRezervasyon.RezervasyonTipiId
                },
                     new SqlParameter
                {
                    ParameterName = "RezervasyonAciklama",
                    Value = EklenecekRezervasyon.RezervasyonAciklama
                },
                      new SqlParameter
                {
                    ParameterName = "RezervasyonIptalOk",
                    Value = EklenecekRezervasyon.RezervasyonIptalOk
                },


            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_RezervasyonEkle", RezervasyonParametreleri, "sp");

            return etkilenenSatir;


        }
        //Var olan Rezervasyon verisini ID sine göre bul ve değiştir. (update)
        public int UpdateRezervasyon(RezervasyonEntity DüzenlenecekRezervasyon)

        {
            SqlParameter[] RezervasyonParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "RezervasyonId",
                    Value = DüzenlenecekRezervasyon.RezervasyonId
                },
                new SqlParameter
                {
                    ParameterName = "MusteriId",
                    Value = DüzenlenecekRezervasyon.MusteriId
                },
                new SqlParameter
                {
                    ParameterName = "RezervasyonGecerlilikTarihi",
                    Value = DüzenlenecekRezervasyon.RezervasyonGecerlilikTarihi
                },
                  new SqlParameter
                {
                    ParameterName = "RezervasyonGecerlilikSonTarihi",
                    Value = DüzenlenecekRezervasyon.RezervasyonGecerlilikSonTarihi
                },
                   new SqlParameter
                {
                    ParameterName = "ErkenRezervasyonIndirim",
                    Value = DüzenlenecekRezervasyon.ErkenRezervasyonIndirim
                },
                    new SqlParameter
                {
                    ParameterName = "RezervasyonTipiId",
                    Value = DüzenlenecekRezervasyon.RezervasyonTipiId
                },
                     new SqlParameter
                {
                    ParameterName = "RezervasyonAciklama",
                    Value = DüzenlenecekRezervasyon.RezervasyonAciklama
                },
                      new SqlParameter
                {
                    ParameterName = "RezervasyonIptalOk",
                    Value = DüzenlenecekRezervasyon.RezervasyonIptalOk
                },




        };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_UpdateRezervasyon", RezervasyonParametreleri, "sp");

            return etkilenenSatir;
        }
        //Var olan Görev verisini ID sine göre sil. (delete)
        public int DeleteRezervasyon(RezervasyonEntity SilinecekRezervasyon)
        {
            SqlParameter[] RezervasyonParametreleri =
             {
                new SqlParameter {

                    ParameterName="RezervasyonId",
                    Value=SilinecekRezervasyon.RezervasyonId

                },
            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_DeleteRezervasyon", RezervasyonParametreleri, "sp");
            return etkilenenSatir;



        }
        #endregion
    }
}
