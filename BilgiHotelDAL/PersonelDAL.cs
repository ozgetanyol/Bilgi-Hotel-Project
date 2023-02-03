using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class PersonelDAL
    {
        #region CRUD Operations

        //ID ye göre Personel Getir.(select with ID)
        public PersonelEntity getPersonelwithID(int PersonelId)
        {
            SqlParameter[] PersonelParametreleri =
            {
                new SqlParameter {

                    ParameterName="PersonelId",
                    Value=PersonelId

                },
            };

            SqlDataReader PersonelRdr = BilgiHotelHelperSQL.myExecuteReader("PersonelListesiwithID", PersonelParametreleri, "sp");

            PersonelEntity myPersonel = null;
            while (PersonelRdr.Read())
            {
                myPersonel.PersonelId = Convert.ToInt32(PersonelRdr["PersonelId"]);
                myPersonel.PersonelAd = PersonelRdr["PersonelAd"].ToString();
                myPersonel.PersonelSoyad = PersonelRdr["PersonelSoyad"].ToString();
                myPersonel.PersonelTcKimlik = PersonelRdr["PersonelTcKimlik"].ToString();
                myPersonel.PersonelDogumTarihi = Convert.ToDateTime(PersonelRdr["PersonelDogumTarihi"]);
                myPersonel.PersonelUyrukId = Convert.ToInt32(PersonelRdr["PersonelUyrukId"]);
                myPersonel.PersonelEposta = PersonelRdr["PersonelEposta"].ToString();
                myPersonel.PersonelTelefon = PersonelRdr["PersonelTelefon"].ToString();
                myPersonel.PersonelPasaportNo = PersonelRdr["PersonelPasaportNo "].ToString();
                myPersonel.CinsiyetId = Convert.ToInt32(PersonelRdr["CinsiyetId"]);
                myPersonel.PersonelIseGirisTarihi = Convert.ToDateTime(PersonelRdr["PersonelIseGirisTarihi"]);
                myPersonel.PersonelIstenCikisTarihi = Convert.ToDateTime(PersonelRdr["PersonelIstenCikisTarihi"]);
                myPersonel.PersonelSaatlikUcret = Convert.ToDecimal(PersonelRdr["PersonelSaatlikUcret"]);
                myPersonel.PersonelMaas = Convert.ToDecimal(PersonelRdr["PersonelMaas"]);
                myPersonel.PersonelSicilNo = PersonelRdr["PersonelSicilNo"].ToString();
                myPersonel.GorevId = Convert.ToInt32(PersonelRdr["GorevId"]);
                myPersonel.PersonelKategoriID = Convert.ToInt32(PersonelRdr["PersonelKategoriID"]);
                myPersonel.PersonelEngelDurumu = Convert.ToBoolean(PersonelRdr["PersonelEngelDurumu"]);
                myPersonel.PersonelHesKodu = PersonelRdr["PersonelHesKodu"].ToString();
                myPersonel.IlId = Convert.ToInt32(PersonelRdr["IlId"]);
                myPersonel.IlceId = Convert.ToInt32(PersonelRdr["IlceId"]);
                myPersonel.UlkeId = Convert.ToInt32(PersonelRdr["UlkeId"]);
                myPersonel.PersonelAdres = PersonelRdr["PersonelAdres"].ToString();
                myPersonel.PersonelAcilDurumKisiAd = PersonelRdr["PersonelAcilDurumKisiAd"].ToString();
                myPersonel.PersonelAcilDurumKisiTelefon = PersonelRdr["PersonelAcilDurumKisiTelefon"].ToString();
                myPersonel.ResimId = Convert.ToInt32(PersonelRdr["ResimId "]);
                myPersonel.VardiyaId = Convert.ToInt32(PersonelRdr["VardiyaId"]);


            }
            return myPersonel;




        }
        //Tüm Personelleri Getir.(select all)
        public PersonelEntity getPersonelAll()
        {
            SqlDataReader PersonelRdr = BilgiHotelHelperSQL.myExecuteReader("sp_PersonelListesiAll", null, "sp");
            PersonelEntity  myPersonel = null;
            while (PersonelRdr.Read())
            {
                myPersonel.PersonelId = Convert.ToInt32(PersonelRdr["PersonelId"]);
                myPersonel.PersonelAd = PersonelRdr["PersonelAd"].ToString();
                myPersonel.PersonelSoyad = PersonelRdr["PersonelSoyad"].ToString();
                myPersonel.PersonelTcKimlik = PersonelRdr["PersonelTcKimlik"].ToString();
                myPersonel.PersonelDogumTarihi = Convert.ToDateTime(PersonelRdr["PersonelDogumTarihi"]);
                myPersonel.PersonelUyrukId = Convert.ToInt32(PersonelRdr["PersonelUyrukId"]);
                myPersonel.PersonelEposta = PersonelRdr["PersonelEposta"].ToString();
                myPersonel.PersonelTelefon = PersonelRdr["PersonelTelefon"].ToString();
                myPersonel.PersonelPasaportNo = PersonelRdr["PersonelPasaportNo "].ToString();
                myPersonel.CinsiyetId = Convert.ToInt32(PersonelRdr["CinsiyetId"]);
                myPersonel.PersonelIseGirisTarihi = Convert.ToDateTime(PersonelRdr["PersonelIseGirisTarihi"]);
                myPersonel.PersonelIstenCikisTarihi = Convert.ToDateTime(PersonelRdr["PersonelIstenCikisTarihi"]);
                myPersonel.PersonelSaatlikUcret = Convert.ToDecimal(PersonelRdr["PersonelSaatlikUcret"]);
                myPersonel.PersonelMaas = Convert.ToDecimal(PersonelRdr["PersonelMaas"]);
                myPersonel.PersonelSicilNo = PersonelRdr["PersonelSicilNo"].ToString();
                myPersonel.GorevId = Convert.ToInt32(PersonelRdr["GorevId"]);
                myPersonel.PersonelKategoriID = Convert.ToInt32(PersonelRdr["PersonelKategoriID"]);
                myPersonel.PersonelEngelDurumu = Convert.ToBoolean(PersonelRdr["PersonelEngelDurumu"]);
                myPersonel.PersonelHesKodu = PersonelRdr["PersonelHesKodu"].ToString();
                myPersonel.IlId = Convert.ToInt32(PersonelRdr["IlId"]);
                myPersonel.IlceId = Convert.ToInt32(PersonelRdr["IlceId"]);
                myPersonel.UlkeId = Convert.ToInt32(PersonelRdr["UlkeId"]);
                myPersonel.PersonelAdres = PersonelRdr["PersonelAdres"].ToString();
                myPersonel.PersonelAcilDurumKisiAd = PersonelRdr["PersonelAcilDurumKisiAd"].ToString();
                myPersonel.PersonelAcilDurumKisiTelefon = PersonelRdr["PersonelAcilDurumKisiTelefon"].ToString();
                myPersonel.ResimId = Convert.ToInt32(PersonelRdr["ResimId "]);
                myPersonel.VardiyaId = Convert.ToInt32(PersonelRdr["VardiyaId"]);


            }
            return myPersonel;

        }
        //Yeni Personel Verisi Gir.(insert)
        public int İnsertPersonel(PersonelEntity EklenecekPersonel)
        {
            SqlParameter[] PersonelParametreleri =
            {
              
                new SqlParameter
                {
                    ParameterName="PersonelAd",
                    Value=EklenecekPersonel.PersonelAd
                },
                new SqlParameter
                {
                    ParameterName="PersonelSoyad",
                    Value=EklenecekPersonel.PersonelSoyad
                },
                 new SqlParameter
                {
                    ParameterName="PersonelTcKimlik",
                    Value=EklenecekPersonel.PersonelTcKimlik
                },
                  new SqlParameter
                {
                    ParameterName="PersonelDogumTarihi",
                    Value=EklenecekPersonel.PersonelDogumTarihi
                },
                   new SqlParameter
                {
                    ParameterName="PersonelUyrukId",
                    Value=EklenecekPersonel.PersonelUyrukId
                },
                    new SqlParameter
                {
                    ParameterName="PersonelEposta",
                    Value=EklenecekPersonel.PersonelEposta
                },
                     new SqlParameter
                {
                    ParameterName="PersonelTelefon",
                    Value=EklenecekPersonel.PersonelTelefon
                },
                      new SqlParameter
                {
                    ParameterName="PersonelPasaportNo",
                    Value=EklenecekPersonel.PersonelPasaportNo
                },
                       new SqlParameter
                {
                    ParameterName="CinsiyetId",
                    Value=EklenecekPersonel.CinsiyetId
                },
                       new SqlParameter
                {
                    ParameterName="PersonelIseGirisTarihi",
                    Value=EklenecekPersonel.PersonelIseGirisTarihi
                },
                       new SqlParameter
                {
                    ParameterName="PersonelIstenCikisTarihi",
                    Value=EklenecekPersonel.PersonelIstenCikisTarihi
                },
                        new SqlParameter
                {
                    ParameterName="PersonelSaatlikUcret",
                    Value=EklenecekPersonel.PersonelSaatlikUcret
                },
                         new SqlParameter
                {
                    ParameterName="PersonelMaas",
                    Value=EklenecekPersonel.PersonelMaas
                },
                           new SqlParameter
                {
                    ParameterName="PersonelSicilNo",
                    Value=EklenecekPersonel.PersonelSicilNo
                },
                          new SqlParameter
                {
                    ParameterName="GorevId",
                    Value=EklenecekPersonel.GorevId
                },

                          new SqlParameter
                {
                    ParameterName="PersonelKategoriID",
                    Value=EklenecekPersonel.PersonelKategoriID
                },
                 new SqlParameter
                {
                    ParameterName="PersonelEngelDurumu",
                    Value=EklenecekPersonel.PersonelEngelDurumu
                },
                        new SqlParameter
                {
                    ParameterName="PersonelHesKodu",
                    Value=EklenecekPersonel.PersonelHesKodu
                },
                     new SqlParameter
                {
                    ParameterName="IlId",
                    Value=EklenecekPersonel.IlId
                },
                            new SqlParameter
                {
                    ParameterName="IlceId",
                    Value=EklenecekPersonel.IlceId
                },
                                   new SqlParameter
                {
                    ParameterName="UlkeId",
                    Value=EklenecekPersonel.UlkeId
                },
                 new SqlParameter
                {
                    ParameterName="PersonelAdres",
                    Value=EklenecekPersonel.PersonelAdres
                },
                  new SqlParameter
                {
                    ParameterName="PersonelAcilDurumKisiAd",
                    Value=EklenecekPersonel.PersonelAcilDurumKisiAd
                },
                   new SqlParameter
                {
                    ParameterName="PersonelAcilDurumKisiTelefon",
                    Value=EklenecekPersonel.PersonelAcilDurumKisiTelefon
                },
                    new SqlParameter
                {
                    ParameterName="ResimId",
                    Value=EklenecekPersonel.ResimId
                },
                     new SqlParameter
                {
                    ParameterName="VardiyaId",
                    Value=EklenecekPersonel.VardiyaId
                },



            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_PersonelEkle", PersonelParametreleri, "sp");

            return etkilenenSatir;
        }
        //Var olan Personel verisini ID sine göre bul ve değiştir. (update)
        public int UpdatePersonel(PersonelEntity DuzenlenecekPersonel)
        {
            SqlParameter[] PersonelParametreleri =
           {
                new SqlParameter
                {
                    ParameterName="PersonelId",
                    Value=DuzenlenecekPersonel.PersonelId
                },
                new SqlParameter
                {
                    ParameterName="PersonelAd",
                    Value=DuzenlenecekPersonel.PersonelAd
                },
                new SqlParameter
                {
                    ParameterName="PersonelSoyad",
                    Value=DuzenlenecekPersonel.PersonelSoyad
                },
                 new SqlParameter
                {
                    ParameterName="PersonelTcKimlik",
                    Value=DuzenlenecekPersonel.PersonelTcKimlik
                },
                  new SqlParameter
                {
                    ParameterName="PersonelDogumTarihi",
                    Value=DuzenlenecekPersonel.PersonelDogumTarihi
                },
                   new SqlParameter
                {
                    ParameterName="PersonelUyrukId",
                    Value=DuzenlenecekPersonel.PersonelUyrukId
                },
                    new SqlParameter
                {
                    ParameterName="PersonelEposta",
                    Value=DuzenlenecekPersonel.PersonelEposta
                },
                     new SqlParameter
                {
                    ParameterName="PersonelTelefon",
                    Value=DuzenlenecekPersonel.PersonelTelefon
                },
                      new SqlParameter
                {
                    ParameterName="PersonelPasaportNo",
                    Value=DuzenlenecekPersonel.PersonelPasaportNo
                },
                       new SqlParameter
                {
                    ParameterName="CinsiyetId",
                    Value=DuzenlenecekPersonel.CinsiyetId
                },
                       new SqlParameter
                {
                    ParameterName="PersonelIseGirisTarihi",
                    Value=DuzenlenecekPersonel.PersonelIseGirisTarihi
                },
                       new SqlParameter
                {
                    ParameterName="PersonelIstenCikisTarihi",
                    Value=DuzenlenecekPersonel.PersonelIstenCikisTarihi
                },
                        new SqlParameter
                {
                    ParameterName="PersonelSaatlikUcret",
                    Value=DuzenlenecekPersonel.PersonelSaatlikUcret
                },
                         new SqlParameter
                {
                    ParameterName="PersonelMaas",
                    Value=DuzenlenecekPersonel.PersonelMaas
                },
                           new SqlParameter
                {
                    ParameterName="PersonelSicilNo",
                    Value=DuzenlenecekPersonel.PersonelSicilNo
                },
                          new SqlParameter
                {
                    ParameterName="GorevId",
                    Value=DuzenlenecekPersonel.GorevId
                },

                          new SqlParameter
                {
                    ParameterName="PersonelKategoriID",
                    Value=DuzenlenecekPersonel.PersonelKategoriID
                },
                 new SqlParameter
                {
                    ParameterName="PersonelEngelDurumu",
                    Value=DuzenlenecekPersonel.PersonelEngelDurumu
                },
                        new SqlParameter
                {
                    ParameterName="PersonelHesKodu",
                    Value=DuzenlenecekPersonel.PersonelHesKodu
                },
                     new SqlParameter
                {
                    ParameterName="IlId",
                    Value=DuzenlenecekPersonel.IlId
                },
                            new SqlParameter
                {
                    ParameterName="IlceId",
                    Value=DuzenlenecekPersonel.IlceId
                },
                                   new SqlParameter
                {
                    ParameterName="UlkeId",
                    Value=DuzenlenecekPersonel.UlkeId
                },
                 new SqlParameter
                {
                    ParameterName="PersonelAdres",
                    Value=DuzenlenecekPersonel.PersonelAdres
                },
                  new SqlParameter
                {
                    ParameterName="PersonelAcilDurumKisiAd",
                    Value=DuzenlenecekPersonel.PersonelAcilDurumKisiAd
                },
                   new SqlParameter
                {
                    ParameterName="PersonelAcilDurumKisiTelefon",
                    Value=DuzenlenecekPersonel.PersonelAcilDurumKisiTelefon
                },
                    new SqlParameter
                {
                    ParameterName="ResimId",
                    Value=DuzenlenecekPersonel.ResimId
                },
                     new SqlParameter
                {
                    ParameterName="VardiyaId",
                    Value=DuzenlenecekPersonel.VardiyaId
                },



            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_UpdatePersonel", PersonelParametreleri, "sp");

            return etkilenenSatir;
        }
        //Var olan Müşteri verisini ID sine göre sil. (delete) 
        public int DeletePersonel(PersonelEntity SilinecekPersonel)
        {
            SqlParameter[] PersonelParametreleri =
            {
                new SqlParameter
                {
                    ParameterName="PersonelId",
                    Value=SilinecekPersonel.PersonelId
                },
            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_DeletePersonel", PersonelParametreleri, "sp");
            return etkilenenSatir;


            #endregion
        }
    }


}       

       
      









