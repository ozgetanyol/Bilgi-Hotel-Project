using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class PersonelYetkiDAL
    {
        #region CRUD Operations
        //ID ye göre Personel Yetki Getir.(select with ID)
        public PersonelYetkiEntity getPersonelYetkiwithID(int PersonelId, int YetkiId)
        {
            SqlParameter[] PersonelYetkiParametreleri =
            {
                new SqlParameter {

                    ParameterName="PersonelId",
                    Value=PersonelId

                },
                 new SqlParameter {

                    ParameterName="YetkiId",
                    Value=YetkiId

                },
            };

            SqlDataReader PersonelYetkiRdr = BilgiHotelHelperSQL.myExecuteReader("PersonelYetkiListesiWithID", PersonelYetkiParametreleri, "sp");

            PersonelYetkiEntity myPersonelYetki = null;
            while (PersonelYetkiRdr.Read())
            {
                myPersonelYetki.PersonelId = Convert.ToInt32(PersonelYetkiRdr["PersonelId"]);
                myPersonelYetki.YetkiId = Convert.ToInt32(PersonelYetkiRdr["YetkiId"]);
                myPersonelYetki.PersonelYetkiEnSonGirisTarihi = Convert.ToDateTime(PersonelYetkiRdr["PersonelYetkiEnSonGirisTarihi"]);
                myPersonelYetki.PersonelYetkiAciklama = PersonelYetkiRdr["PersonelYetkiAciklama"].ToString();
                myPersonelYetki.PersonelYetkiAktifMi = Convert.ToBoolean(PersonelYetkiRdr["PersonelYetkiAktifMi"]);


            }
            return myPersonelYetki;

        }
        //Tüm Personel Yetkileri Getir.(All)
        public PersonelYetkiEntity sp_PersonelYetkiListesiAll(int PersonelId, int YetkiId)
        {

            SqlDataReader PersonelYetkiRdr = BilgiHotelHelperSQL.myExecuteReader("sp_PersonelYetkiListesiAll", null, "sp");

            PersonelYetkiEntity myPersonelYetki = null;
            while (PersonelYetkiRdr.Read())
            {
                myPersonelYetki.PersonelId = Convert.ToInt32(PersonelYetkiRdr["PersonelId"]);
                myPersonelYetki.YetkiId = Convert.ToInt32(PersonelYetkiRdr["YetkiId"]);
                myPersonelYetki.PersonelYetkiEnSonGirisTarihi = Convert.ToDateTime(PersonelYetkiRdr["PersonelYetkiEnSonGirisTarihi"]);
                myPersonelYetki.PersonelYetkiAciklama = PersonelYetkiRdr["PersonelYetkiAciklama"].ToString();
                myPersonelYetki.PersonelYetkiAktifMi = Convert.ToBoolean(PersonelYetkiRdr["PersonelYetkiAktifMi"]);


            }
            return myPersonelYetki;

        }
        //Yeni Personel Yetki Verisi Gir.(insert)
        public int İnsertPersonelYetki(PersonelYetkiEntity EklenecekPersonelYetki)

        {
            SqlParameter[] PersonelYetkiParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "PersonelId",
                    Value = EklenecekPersonelYetki.PersonelId
                },
                new SqlParameter
                {
                    ParameterName = "YetkiId",
                    Value = EklenecekPersonelYetki.YetkiId
                },
                new SqlParameter
                {
                    ParameterName = "PersonelYetkiEnSonGirisTarihi",
                    Value = EklenecekPersonelYetki.PersonelYetkiEnSonGirisTarihi
                },
                 new SqlParameter
                {
                    ParameterName = "PersonelYetkiAciklama",
                    Value = EklenecekPersonelYetki.PersonelYetkiAciklama
                },
                   new SqlParameter
                {
                    ParameterName = "PersonelYetkiAktifMi",
                    Value = EklenecekPersonelYetki.PersonelYetkiAktifMi
                },
            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_InsertPersonelYetki", PersonelYetkiParametreleri, "sp");

            return etkilenenSatir;


        }
        //Var olan Personel Yetki verisini ID sine göre bul ve değiştir. (update)
        public int UpdatePersonelYetki(PersonelYetkiEntity DüzenlenecekPersonelYetki)

        {
            SqlParameter[] PersonelYetkiParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "PersonelId",
                    Value = DüzenlenecekPersonelYetki.PersonelId
                },
                new SqlParameter
                {
                    ParameterName = "YetkiId",
                    Value = DüzenlenecekPersonelYetki.YetkiId
                },
                new SqlParameter
                {
                    ParameterName = "PersonelYetkiEnSonGirisTarihi",
                    Value = DüzenlenecekPersonelYetki.PersonelYetkiEnSonGirisTarihi
                },
                 new SqlParameter
                {
                    ParameterName = "PersonelYetkiAciklama",
                    Value = DüzenlenecekPersonelYetki.PersonelYetkiAciklama
                },
                   new SqlParameter
                {
                    ParameterName = "PersonelYetkiAktifMi",
                    Value = DüzenlenecekPersonelYetki.PersonelYetkiAktifMi
                },

            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_UpdatePersonelYetki ", PersonelYetkiParametreleri, "sp");

            return etkilenenSatir;
        }
        //Var olan Personel Yetki verisini ID sine göre sil. (delete)
        public int DeletePersonelYetki(PersonelYetkiEntity SilinecekPersonelYetki)
        {
            SqlParameter[] PersonelYetkiParametreleri =
             {
                new SqlParameter {

                    ParameterName="PersonelId",
                    Value=SilinecekPersonelYetki.PersonelId

                },
                 new SqlParameter {

                    ParameterName="YetkiId",
                    Value=SilinecekPersonelYetki.YetkiId

                },
            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_DeletePersonelYetki", PersonelYetkiParametreleri, "sp");
            return etkilenenSatir;



        }
        #endregion
    }
}
