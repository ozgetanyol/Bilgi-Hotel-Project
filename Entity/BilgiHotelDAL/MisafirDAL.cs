using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class MisafirDAL
    {
        #region CRUD Operations
        //ID ye göre Misafir Getir.(select with ID)
        public MisafirEntity getMisafirwithID(int MisafirId)
        {
            SqlParameter[] MisafirParametreleri =
            {
                new SqlParameter {

                    ParameterName="MisafirId",
                    Value=MisafirId

                },
            };

            SqlDataReader MisafirRdr = BilgiHotelHelperSQL.myExecuteReader("MisafirListesiwithID", MisafirParametreleri, "sp");

            MisafirEntity myMisafir = null;
            while (MisafirRdr.Read())
            {
                myMisafir.MisafirId = Convert.ToInt32(MisafirRdr["MisafirId"]);
                myMisafir.MisafirAd = MisafirRdr["MisafirAd"].ToString();
                myMisafir.MisafirSoyad = MisafirRdr["MisafirSoyad"].ToString();
                myMisafir.MisafirTcKimlik = MisafirRdr["MisafirTcKimlik"].ToString();
                myMisafir.MisafirDogumTarihi = Convert.ToDateTime(MisafirRdr["MisafirDogumTarihi"]);
                myMisafir.MisafirUyrukId = Convert.ToInt32(MisafirRdr["MisafirUyrukId"]);
                myMisafir.MisafirEposta = MisafirRdr["MisafirEposta"].ToString();
                myMisafir.MisafirTelefon = MisafirRdr["MisafirTelefon"].ToString();
                myMisafir.MisafirPasaportNo = MisafirRdr["MisafirPasaportNo"].ToString();
                myMisafir.CinsiyetId = Convert.ToInt32(MisafirRdr["CinsiyetId"]);
                myMisafir.MisafirAdres = MisafirRdr["MisafirAdres"].ToString();
                myMisafir.IlId = Convert.ToInt32(MisafirRdr["IlId"]);
                myMisafir.IlceId = Convert.ToInt32(MisafirRdr["IlceId"]);
                myMisafir.UlkeId = Convert.ToInt32(MisafirRdr["UlkeId"]);
                myMisafir.MisafirAciklama = MisafirRdr["MisafirAciklama"].ToString();
                myMisafir.MisafirHesKod = MisafirRdr["MisafirHesKod"].ToString();
                myMisafir.dilId = Convert.ToInt32(MisafirRdr["dilId"]);
                myMisafir.KonaklamaTipNo = Convert.ToInt32(MisafirRdr["KonaklamaTipNo"]);


            }
            return myMisafir;

        }
        //Tüm Misafirleri Getir
        public MisafirEntity getMisafirAll(int MisafirId)
        {

            SqlDataReader MisafirRdr = BilgiHotelHelperSQL.myExecuteReader("sp_MisafirListesiAll", null, "sp");

            MisafirEntity myMisafir = null;
            while (MisafirRdr.Read())
            {
                myMisafir.MisafirId = Convert.ToInt32(MisafirRdr["MisafirId"]);
                myMisafir.MisafirAd = MisafirRdr["MisafirAd"].ToString();
                myMisafir.MisafirSoyad = MisafirRdr["MisafirSoyad"].ToString();
                myMisafir.MisafirTcKimlik = MisafirRdr["MisafirTcKimlik"].ToString();
                myMisafir.MisafirDogumTarihi = Convert.ToDateTime(MisafirRdr["MisafirDogumTarihi"]);
                myMisafir.MisafirUyrukId = Convert.ToInt32(MisafirRdr["MisafirUyrukId"]);
                myMisafir.MisafirEposta = MisafirRdr["MisafirEposta"].ToString();
                myMisafir.MisafirTelefon = MisafirRdr["MisafirTelefon"].ToString();
                myMisafir.MisafirPasaportNo = MisafirRdr["MisafirPasaportNo"].ToString();
                myMisafir.CinsiyetId = Convert.ToInt32(MisafirRdr["CinsiyetId"]);
                myMisafir.MisafirAdres = MisafirRdr["MisafirAdres"].ToString();
                myMisafir.IlId = Convert.ToInt32(MisafirRdr["IlId"]);
                myMisafir.IlceId = Convert.ToInt32(MisafirRdr["IlceId"]);
                myMisafir.UlkeId = Convert.ToInt32(MisafirRdr["UlkeId"]);
                myMisafir.MisafirAciklama = MisafirRdr["MisafirAciklama"].ToString();
                myMisafir.MisafirHesKod = MisafirRdr["MisafirHesKod"].ToString();
                myMisafir.dilId = Convert.ToInt32(MisafirRdr["dilId"]);
                myMisafir.KonaklamaTipNo = Convert.ToInt32(MisafirRdr["KonaklamaTipNo"]);


            }
            return myMisafir;
        }
        //Yeni Misafir Verisi Gir.(insert)
        public int İnsertMisafir(MisafirEntity EklenecekMisafir)

        {
            SqlParameter[] MisafirParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "MisafirId",
                    Value = EklenecekMisafir.MisafirId
                },
                new SqlParameter
                {
                    ParameterName = "MisafirAd",
                    Value = EklenecekMisafir.MisafirAd
                },
                new SqlParameter
                {
                    ParameterName = "MisafirSoyad",
                    Value = EklenecekMisafir.MisafirSoyad
                },
                 new SqlParameter
                {
                    ParameterName = "MisafirTcKimlik",
                    Value = EklenecekMisafir.MisafirTcKimlik
                },
                new SqlParameter
                {
                    ParameterName = "MisafirDogumTarihi",
                    Value = EklenecekMisafir.MisafirDogumTarihi
                },
                 new SqlParameter
                {
                    ParameterName = "MisafirUyrukId",
                    Value = EklenecekMisafir.MisafirUyrukId
                },
                 new SqlParameter
                {
                    ParameterName = "MisafirEposta",
                    Value = EklenecekMisafir.MisafirEposta
                },
                 new SqlParameter
                {
                    ParameterName = "MisafirTelefon",
                    Value = EklenecekMisafir.MisafirTelefon
                },
                 new SqlParameter
                {
                    ParameterName = "MisafirPasaportNo",
                    Value = EklenecekMisafir.MisafirPasaportNo
                },
                  new SqlParameter
                {
                    ParameterName = "CinsiyetId",
                    Value = EklenecekMisafir.CinsiyetId
                },
                  new SqlParameter
                {
                    ParameterName = "MisafirAdres",
                    Value = EklenecekMisafir.MisafirAdres
                },
               new SqlParameter
                {
                    ParameterName = "IlId",
                    Value = EklenecekMisafir.IlId
                },
                new SqlParameter
                {
                    ParameterName = "IlceId",
                    Value = EklenecekMisafir.IlceId
                },
                  new SqlParameter
                {
                    ParameterName = "UlkeId",
                    Value = EklenecekMisafir.UlkeId
                },
                new SqlParameter
                {
                    ParameterName = "MisafirAciklama",
                    Value = EklenecekMisafir.MisafirAciklama
                },
                 new SqlParameter
                {
                    ParameterName = "MisafirHesKod",
                    Value = EklenecekMisafir.MisafirHesKod
                },
                  new SqlParameter
                {
                    ParameterName = "dilId",
                    Value = EklenecekMisafir.dilId
                },
                   new SqlParameter
                {
                    ParameterName = "KonaklamaTipNo",
                    Value = EklenecekMisafir.KonaklamaTipNo
                },


            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_InsertMisafirler", MisafirParametreleri, "sp");

            return etkilenenSatir;


        }
        //Var olan Misafir verisini ID sine göre bul ve değiştir. (update)
        public int UpdateMisafir(MisafirEntity DüzenlenecekMisafir)

        {
            SqlParameter[] MisafirParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "MisafirId",
                    Value = DüzenlenecekMisafir.MisafirId
                },
                new SqlParameter
                {
                    ParameterName = "MisafirAd",
                    Value = DüzenlenecekMisafir.MisafirAd
                },
                new SqlParameter
                {
                    ParameterName = "MisafirSoyad",
                    Value = DüzenlenecekMisafir.MisafirSoyad
                },
                 new SqlParameter
                {
                    ParameterName = "MisafirTcKimlik",
                    Value = DüzenlenecekMisafir.MisafirTcKimlik
                },
                new SqlParameter
                {
                    ParameterName = "MisafirDogumTarihi",
                    Value = DüzenlenecekMisafir.MisafirDogumTarihi
                },
                 new SqlParameter
                {
                    ParameterName = "MisafirUyrukId",
                    Value = DüzenlenecekMisafir.MisafirUyrukId
                },
                 new SqlParameter
                {
                    ParameterName = "MisafirEposta",
                    Value = DüzenlenecekMisafir.MisafirEposta
                },
                 new SqlParameter
                {
                    ParameterName = "MisafirTelefon",
                    Value = DüzenlenecekMisafir.MisafirTelefon
                },
                 new SqlParameter
                {
                    ParameterName = "MisafirPasaportNo",
                    Value = DüzenlenecekMisafir.MisafirPasaportNo
                },
                  new SqlParameter
                {
                    ParameterName = "CinsiyetId",
                    Value = DüzenlenecekMisafir.CinsiyetId
                },
                  new SqlParameter
                {
                    ParameterName = "MisafirAdres",
                    Value = DüzenlenecekMisafir.MisafirAdres
                },
               new SqlParameter
                {
                    ParameterName = "IlId",
                    Value = DüzenlenecekMisafir.IlId
                },
                new SqlParameter
                {
                    ParameterName = "IlceId",
                    Value = DüzenlenecekMisafir.IlceId
                },
                  new SqlParameter
                {
                    ParameterName = "UlkeId",
                    Value = DüzenlenecekMisafir.UlkeId
                },
                new SqlParameter
                {
                    ParameterName = "MisafirAciklama",
                    Value = DüzenlenecekMisafir.MisafirAciklama
                },
                 new SqlParameter
                {
                    ParameterName = "MisafirHesKod",
                    Value = DüzenlenecekMisafir.MisafirHesKod
                },
                  new SqlParameter
                {
                    ParameterName = "dilId",
                    Value = DüzenlenecekMisafir.dilId
                },
                   new SqlParameter
                {
                    ParameterName = "KonaklamaTipNo",
                    Value = DüzenlenecekMisafir.KonaklamaTipNo
                },


            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_UpdateMisafirler", MisafirParametreleri, "sp");

            return etkilenenSatir;
        }
        //Var olan Misafir verisini ID sine göre sil. (delete)
        public int DeleteMisafir(MisafirEntity SilinecekMisafir)
        {
            SqlParameter[] MisafirParametreleri =
             {
                new SqlParameter {

                    ParameterName="MisafirId",
                    Value=SilinecekMisafir.MisafirId

                },
            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("DeleteMisafir", MisafirParametreleri, "sp");
            return etkilenenSatir;



        }
        #endregion
    }
}

