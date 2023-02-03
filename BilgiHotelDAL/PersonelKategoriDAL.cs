using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class PersonelKategoriDAL
    {
        #region CRUD Operations
        //ID ye göre Personel Kategori Getir.(select with ID)
        public PersonelKategoriEntity getPersonelKategoriwithID(int PersonelKategoriId)
        {
            SqlParameter[] PersonelKategoriParametreleri =
            {
                new SqlParameter {

                    ParameterName="PersonelKategoriId",
                    Value=PersonelKategoriId

                },
            };

            SqlDataReader PersonelKategoriRdr = BilgiHotelHelperSQL.myExecuteReader("PersonelKategoriListesiWithID", PersonelKategoriParametreleri, "sp");

            PersonelKategoriEntity myPersonelKategori = null;
            while (PersonelKategoriRdr.Read())
            {
                myPersonelKategori.PersonelKategoriId = Convert.ToInt32(PersonelKategoriRdr["PersonelKategoriId"]);
                myPersonelKategori.PersonelKategoriTip = PersonelKategoriRdr["PersonelKategoriTip"].ToString();
                myPersonelKategori.Aciklama = PersonelKategoriRdr["Aciklama"].ToString();
             
            }
            return myPersonelKategori;

        }
        //Tüm Personel Kategorileri Getir.(All)
        public PersonelKategoriEntity sp_PersonelKategoriListesiAll(int PersonelKategoriId)
        {

            SqlDataReader PersonelKategoriRdr = BilgiHotelHelperSQL.myExecuteReader("sp_PersonelKategoriListesiAll", null, "sp");

            PersonelKategoriEntity myPersonelKategori = null;
            while (PersonelKategoriRdr.Read())
            {
                myPersonelKategori.PersonelKategoriId = Convert.ToInt32(PersonelKategoriRdr["PersonelKategoriId"]);
                myPersonelKategori.PersonelKategoriTip = PersonelKategoriRdr["PersonelKategoriTip"].ToString();
                myPersonelKategori.Aciklama = PersonelKategoriRdr["Aciklama"].ToString();

            }
            return myPersonelKategori;

        }
        //Yeni Personel Kategori Verisi Gir.(insert)
        public int İnsertPersonelKategori(PersonelKategoriEntity EklenecekPersonelKategori)

        {
            SqlParameter[] PersonelKategoriParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "PersonelKategoriId",
                    Value = EklenecekPersonelKategori.PersonelKategoriId
                },
                new SqlParameter
                {
                    ParameterName = "PersonelKategoriTip",
                    Value = EklenecekPersonelKategori.PersonelKategoriTip
                },
                new SqlParameter
                {
                    ParameterName = "Aciklama",
                    Value = EklenecekPersonelKategori.Aciklama
                },
               
            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_InsertPersonelKategori", PersonelKategoriParametreleri, "sp");

            return etkilenenSatir;


        }
        //Var olan Personel Kategori verisini ID sine göre bul ve değiştir. (update)
        public int UpdatePersonelKategori(PersonelKategoriEntity DüzenlenecekPersonelKategori)

        {
            SqlParameter[] PersonelKategoriParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "PersonelKategoriId",
                    Value = DüzenlenecekPersonelKategori.PersonelKategoriId
                },
                new SqlParameter
                {
                    ParameterName = "PersonelKategoriTip",
                    Value = DüzenlenecekPersonelKategori.PersonelKategoriTip
                },
                new SqlParameter
                {
                    ParameterName = "Aciklama",
                    Value = DüzenlenecekPersonelKategori.Aciklama
                },

            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_UpdatePersonelKategori ", PersonelKategoriParametreleri, "sp");

            return etkilenenSatir;
        }
        //Var olan Personel Kategori verisini ID sine göre sil. (delete)
        public int DeletePersonelKategori(PersonelKategoriEntity SilinecekPersonelKategori)
        {
            SqlParameter[] PersonelKategoriParametreleri =
             {
                new SqlParameter {

                    ParameterName="PersonelKategoriId",
                    Value=SilinecekPersonelKategori.PersonelKategoriId

                },
            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_DeletePersonelKategori", PersonelKategoriParametreleri, "sp");
            return etkilenenSatir;



        }
        #endregion
    }
}
