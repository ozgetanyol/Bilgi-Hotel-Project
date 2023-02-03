using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class RezervasyonTipDAL
    {
         #region CRUD Operations
            //ID ye göre Rezervasyon Tipi Getir.(select with ID)
            public RezervasyonTipEntity getRezervasyonTipwithID(int RezervasyonTipId)
            {
                SqlParameter[] RezervasyonTipParametreleri =
                {
                new SqlParameter {

                    ParameterName="RezervasyonTipId",
                    Value=RezervasyonTipId

                },
            };

                SqlDataReader RezervasyonTipRdr = BilgiHotelHelperSQL.myExecuteReader("RezervasyonTipListesiwithID", RezervasyonTipParametreleri, "sp");

                RezervasyonTipEntity myRezervasyonTip = null;
                while (RezervasyonTipRdr.Read())
                {
                    myRezervasyonTip.RezervasyonTipId = Convert.ToInt32(RezervasyonTipRdr["RezervasyonTipId"]);
                    myRezervasyonTip.RezervasyonTanım = RezervasyonTipRdr["RezervasyonTanım"].ToString();
                    myRezervasyonTip.RezervasyonAciklama = RezervasyonTipRdr["RezervasyonAciklama"].ToString();

                }
                return myRezervasyonTip;

            }
            //Tüm Rezervasyon Tiplerini Getir(ALL)
            public RezervasyonTipEntity getRezervasyonTipAll(int RezervasyonTipId)
            {


                SqlDataReader RezervasyonTipRdr = BilgiHotelHelperSQL.myExecuteReader("sp_RezervasyonTipListesiAll", null, "sp");

                RezervasyonTipEntity myRezervasyonTip = null;
                while (RezervasyonTipRdr.Read())
                {
                    myRezervasyonTip.RezervasyonTipId = Convert.ToInt32(RezervasyonTipRdr["RezervasyonTipId"]);
                    myRezervasyonTip.RezervasyonTanım = RezervasyonTipRdr["RezervasyonTanım"].ToString();
                    myRezervasyonTip.RezervasyonAciklama = RezervasyonTipRdr["RezervasyonAciklama"].ToString();

                }
                return myRezervasyonTip;

            }
            //Yeni Rezervasyon Tipi Verisi Gir.(insert)
            public int İnsertRezervasyonTip(RezervasyonTipEntity EklenecekRezervasyonTip)

            {
                SqlParameter[] RezervasyonTipParametreleri =
                {
                new SqlParameter
                {
                    ParameterName = "RezervasyonTipId",
                    Value = EklenecekRezervasyonTip.RezervasyonTipId
                },
                new SqlParameter
                {
                    ParameterName = "RezervasyonTanım",
                    Value = EklenecekRezervasyonTip.RezervasyonTanım
                },
                new SqlParameter
                {
                    ParameterName = "RezervasyonAciklama",
                    Value = EklenecekRezervasyonTip.RezervasyonAciklama
                },


            };
                int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_InsertRezervasyonTip", RezervasyonTipParametreleri, "sp");

                return etkilenenSatir;


            }
            //Var olan Rezervasyon Tip verisini ID sine göre bul ve değiştir. (update)
            public int UpdateRezervasyonTip(RezervasyonTipEntity DüzenlenecekRezervasyonTip)

            {
                SqlParameter[] RezervasyonTipParametreleri =
                {
                new SqlParameter
                {
                    ParameterName = "RezervasyonTipId",
                    Value = DüzenlenecekRezervasyonTip.RezervasyonTipId
                },
                new SqlParameter
                {
                    ParameterName = "RezervasyonTanım",
                    Value = DüzenlenecekRezervasyonTip.RezervasyonTanım
                },
                new SqlParameter
                {
                    ParameterName = "RezervasyonAciklama",
                    Value = DüzenlenecekRezervasyonTip.RezervasyonAciklama
                },




        };
                int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_UpdateRezervasyonTip", RezervasyonTipParametreleri, "sp");

                return etkilenenSatir;
            }
            //Var olan Rezervasyon Tip verisini ID sine göre sil. (delete)
            public int DeleteRezervasyonTip(RezervasyonTipEntity SilinecekRezervasyonTip)
            {
                SqlParameter[] RezervasyonTipParametreleri =
                 {
                new SqlParameter {

                    ParameterName="RezervasyonTipId",
                    Value=SilinecekRezervasyonTip.RezervasyonTipId

                },
            };
                int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_DeleteRezervasyonTip", RezervasyonTipParametreleri, "sp");
                return etkilenenSatir;



            }
            #endregion
        }
    }

