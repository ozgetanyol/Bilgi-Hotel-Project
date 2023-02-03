using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class MusterilerDAL
    {
        #region CRUD Operations

        //ID ye göre Müşteri Getir.(select with ID)
        public MusterilerEntity getMusterilerwithID(int MusteriID)
        {
            SqlParameter[] MusterilerParametreleri =
            {
                new SqlParameter {

                    ParameterName="MusteriID",
                    Value=MusteriID

                },
            };

            SqlDataReader MusterilerRdr = BilgiHotelHelperSQL.myExecuteReader("MusterilerListesiwithID", MusterilerParametreleri, "sp");

            MusterilerEntity myMusteriler = null;
            while (MusterilerRdr.Read())
            {
                myMusteriler.MusteriID = Convert.ToInt32(MusterilerRdr["MusteriID"]);
                myMusteriler.MusteriAd = MusterilerRdr["MusteriAd"].ToString();
                myMusteriler.MusteriSoyad = MusterilerRdr["MusteriSoyad"].ToString();
                myMusteriler.MusteriTCKimlik = MusterilerRdr["MusteriTCKimlik"].ToString();
                myMusteriler.MusteriPasaportNo = MusterilerRdr["MusteriPasaportNo"].ToString();
                myMusteriler.MusteriUnvan = MusterilerRdr["MusteriUnvan"].ToString();
                myMusteriler.MusteriYetkiliAdSoyad = MusterilerRdr["MusteriYetkiliAdSoyad"].ToString();
                myMusteriler.MusteriVergiNo = MusterilerRdr["MusteriVergiNo"].ToString();
                myMusteriler.MusteriVergiDairesi = MusterilerRdr["MusteriVergiDairesi"].ToString() ;
                myMusteriler.MusteriTelefon = MusterilerRdr["MusteriTelefon"].ToString() ;
                myMusteriler.MusteriPosta = MusterilerRdr["MusteriPosta"].ToString();
                myMusteriler.MusteriAdres = MusterilerRdr["MusteriAdres"].ToString() ;
                myMusteriler.IlID = Convert.ToInt32(MusterilerRdr["IlID"]);
                myMusteriler.IlceID = Convert.ToInt32(MusterilerRdr["IlceID"]);
                myMusteriler.UlkeID = Convert.ToInt32(MusterilerRdr["UlkeID"]);
                myMusteriler.MusteriAciklama = MusterilerRdr["MusteriAciklama"].ToString();
                myMusteriler.MusteriKurumsalOK = Convert.ToBoolean(MusterilerRdr["MusteriKurumsalOK"]);
                myMusteriler.DilID = Convert.ToInt32(MusterilerRdr["DilID"]);

            }
            return myMusteriler;
        }

        //Tüm Müşterileri Getir.(select all)
        public MusterilerEntity getMusterilerAll()
        {
            SqlDataReader MusterilerRdr = BilgiHotelHelperSQL.myExecuteReader(" sp_MusterilerListesiAll", null, "sp");

            MusterilerEntity myMusteriler = null;
            while (MusterilerRdr.Read())
            {
                myMusteriler.MusteriID = Convert.ToInt32(MusterilerRdr["MusteriID"]);
                myMusteriler.MusteriAd = MusterilerRdr["MusteriAd"].ToString();
                myMusteriler.MusteriSoyad = MusterilerRdr["MusteriSoyad"].ToString();
                myMusteriler.MusteriTCKimlik = MusterilerRdr["MusteriTCKimlik"].ToString();
                myMusteriler.MusteriPasaportNo = MusterilerRdr["MusteriPasaportNo"].ToString();
                myMusteriler.MusteriUnvan = MusterilerRdr["MusteriUnvan"].ToString();
                myMusteriler.MusteriYetkiliAdSoyad = MusterilerRdr["MusteriYetkiliAdSoyad"].ToString();
                myMusteriler.MusteriVergiNo = MusterilerRdr["MusteriVergiNo"].ToString();
                myMusteriler.MusteriVergiDairesi = MusterilerRdr["MusteriVergiDairesi"].ToString();
                myMusteriler.MusteriTelefon = MusterilerRdr["MusteriTelefon"].ToString();
                myMusteriler.MusteriPosta = MusterilerRdr["MusteriPosta"].ToString();
                myMusteriler.MusteriAdres = MusterilerRdr["MusteriAdres"].ToString();
                myMusteriler.IlID = Convert.ToInt32(MusterilerRdr["IlID"]);
                myMusteriler.IlceID = Convert.ToInt32(MusterilerRdr["IlceID"]);
                myMusteriler.UlkeID = Convert.ToInt32(MusterilerRdr["UlkeID"]);
                myMusteriler.MusteriAciklama = MusterilerRdr["MusteriAciklama"].ToString();
                myMusteriler.MusteriKurumsalOK = Convert.ToBoolean(MusterilerRdr["MusteriKurumsalOK"]);
                myMusteriler.DilID = Convert.ToInt32(MusterilerRdr["DilID"]);
            }

            return myMusteriler;

        }


        //Yeni Müşteri Verisi Gir.(insert)
        public int İnsertMusteriler(MusterilerEntity EklenecekMusteri)
        {
            SqlParameter[] MusterilerParametreleri =
            {
                new SqlParameter
                {
                    ParameterName="MusteriID",
                    Value=EklenecekMusteri.MusteriID
                },
                new SqlParameter
                {
                    ParameterName="MusteriAd",
                    Value=EklenecekMusteri.MusteriAd
                },
                new SqlParameter
                {
                    ParameterName ="MusteriSoyad",
                    Value=EklenecekMusteri.MusteriSoyad
                },
                new SqlParameter
                {
                    ParameterName="MusteriTCKimlik",
                    Value = EklenecekMusteri.MusteriTCKimlik
                },
                 new SqlParameter
                {
                    ParameterName="MusteriPasaportNo",
                    Value = EklenecekMusteri.MusteriPasaportNo
                },
                  new SqlParameter
                {
                    ParameterName="MusteriUnvan",
                    Value = EklenecekMusteri.MusteriUnvan
                },
                   new SqlParameter
                {
                    ParameterName="MusteriYetkiliAdSoyad",
                    Value = EklenecekMusteri.MusteriYetkiliAdSoyad
                },
                    new SqlParameter
                {
                    ParameterName="MusteriVergiNo",
                    Value = EklenecekMusteri.MusteriVergiNo
                },
                     new SqlParameter
                {
                    ParameterName="MusteriVergiDairesi",
                    Value = EklenecekMusteri.MusteriVergiDairesi
                },
                      new SqlParameter
                {
                    ParameterName="MusteriTelefon",
                    Value = EklenecekMusteri.MusteriTelefon
                },
                       new SqlParameter
                {
                    ParameterName="MusteriPosta",
                    Value = EklenecekMusteri.MusteriPosta
                },
                        new SqlParameter
                {
                    ParameterName="MusteriAdres",
                    Value = EklenecekMusteri.MusteriAdres
                },
                         new SqlParameter
                {
                    ParameterName="IlID",
                    Value = EklenecekMusteri.IlID
                },
                          new SqlParameter
                {
                    ParameterName="IlceID",
                    Value = EklenecekMusteri.IlceID
                },
                           new SqlParameter
                {
                    ParameterName="UlkeID",
                    Value = EklenecekMusteri.UlkeID
                },
                            new SqlParameter
                {
                    ParameterName="MusteriAciklama",
                    Value = EklenecekMusteri.MusteriAciklama
                },
                             new SqlParameter
                {
                    ParameterName="MusteriKurumsalOK",
                    Value = EklenecekMusteri.MusteriKurumsalOK
                },
                              new SqlParameter
                {
                    ParameterName="DilID",
                    Value = EklenecekMusteri.DilID
                },

            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_MusteriKaydet", MusterilerParametreleri, "sp");

            return etkilenenSatir;
        }



        //Var olan Müşteri verisini ID sine göre bul ve değiştir. (update)
        public int UpdateMusteriler(MusterilerEntity DuzenlenecekMusteri)
        {
            SqlParameter[] MusterilerParametreleri =
            {
                new SqlParameter
                {
                    ParameterName= "MusteriID",
                    Value=DuzenlenecekMusteri.MusteriID
                },
                new SqlParameter
                {
                    ParameterName="MusteriAd",
                    Value=DuzenlenecekMusteri.MusteriAd
                },
                new SqlParameter
                {
                    ParameterName ="MusteriSoyad",
                    Value=DuzenlenecekMusteri.MusteriSoyad
                },
                new SqlParameter
                {
                    ParameterName="MusteriTCKimlik",
                    Value = DuzenlenecekMusteri.MusteriTCKimlik
                },
                 new SqlParameter
                {
                    ParameterName="MusteriPasaportNo",
                    Value = DuzenlenecekMusteri.MusteriPasaportNo
                },
                  new SqlParameter
                {
                    ParameterName="MusteriUnvan",
                    Value = DuzenlenecekMusteri.MusteriUnvan
                },
                   new SqlParameter
                {
                    ParameterName="MusteriYetkiliAdSoyad",
                    Value = DuzenlenecekMusteri.MusteriYetkiliAdSoyad
                },
                    new SqlParameter
                {
                    ParameterName="MusteriVergiNo",
                    Value = DuzenlenecekMusteri.MusteriVergiNo
                },
                     new SqlParameter
                {
                    ParameterName="MusteriVergiDairesi",
                    Value = DuzenlenecekMusteri.MusteriVergiDairesi
                },
                      new SqlParameter
                {
                    ParameterName="MusteriTelefon",
                    Value = DuzenlenecekMusteri.MusteriTelefon
                },
                       new SqlParameter
                {
                    ParameterName="MusteriPosta",
                    Value = DuzenlenecekMusteri.MusteriPosta
                },
                        new SqlParameter
                {
                    ParameterName="MusteriAdres",
                    Value = DuzenlenecekMusteri.MusteriAdres
                },
                         new SqlParameter
                {
                    ParameterName="IlID",
                    Value = DuzenlenecekMusteri.IlID
                },
                          new SqlParameter
                {
                    ParameterName="IlceID",
                    Value = DuzenlenecekMusteri.IlceID
                },
                           new SqlParameter
                {
                    ParameterName="UlkeID",
                    Value = DuzenlenecekMusteri.UlkeID
                },
                            new SqlParameter
                {
                    ParameterName="MusteriAciklama",
                    Value = DuzenlenecekMusteri.MusteriAciklama
                },
                             new SqlParameter
                {
                    ParameterName="MusteriKurumsalOK",
                    Value = DuzenlenecekMusteri.MusteriKurumsalOK
                },
                              new SqlParameter
                {
                    ParameterName="DilID",
                    Value = DuzenlenecekMusteri.DilID
                },

            };

            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_UpdateMusteriler", MusterilerParametreleri, "sp");
            return etkilenenSatir;
        }


        //Var olan Müşteri verisini ID sine göre sil. (delete) 
        public int DeleteMusteriler(MusterilerEntity SilinecekMusteri)
        {
            SqlParameter[] MusterilerParametreleri =
            {
                new SqlParameter
                {
                    ParameterName="MusteriID",
                    Value=SilinecekMusteri.MusteriID
                },
            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_DeleteMusteriwithID", MusterilerParametreleri, "sp");
            return etkilenenSatir;


            #endregion
        }
    }
}
