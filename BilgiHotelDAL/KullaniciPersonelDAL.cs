using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class KullaniciPersonelDAL
    {
        #region CRUD Operations
        //ID ye göre Kullanici Personel Getir.(select with ID)
        public KullaniciPersonelEntity KullaniciPersonelGetir(int PersonelId, int KullaniciId, int YetkiId)
        {
            SqlParameter[] KullaniciPersonelParametreleri =
            {
                new SqlParameter {

                    ParameterName="PersonelId",
                    Value=PersonelId

                },
                 new SqlParameter {

                    ParameterName="KullaniciId",
                    Value=KullaniciId

                },
                  new SqlParameter {

                    ParameterName="YetkiId",
                    Value=YetkiId

                },
            };

            SqlDataReader KullaniciPersonelRdr = BilgiHotelHelperSQL.myExecuteReader("sp_KullaniciPersonelGetir", KullaniciPersonelParametreleri, "sp");

            KullaniciPersonelEntity myKullaniciPersonel = null;
            while (KullaniciPersonelRdr.Read())
            {
                myKullaniciPersonel.PersonelId = Convert.ToInt32(KullaniciPersonelRdr["PersonelId"]);
                myKullaniciPersonel.KullaniciId = Convert.ToInt32(KullaniciPersonelRdr["KullaniciId"]);
                myKullaniciPersonel.YetkiId = Convert.ToInt32(KullaniciPersonelRdr["YetkiId"]);


            }
            return myKullaniciPersonel;

        }
        //Tüm Verileri Getir.(All)
        public KullaniciPersonelEntity sp_KullaniciPersonelListesiAll(int PersonelId, int KullaniciId, int YetkiId)
        {

            SqlDataReader KullaniciPersonelRdr = BilgiHotelHelperSQL.myExecuteReader("sp_KullaniciPersonelListesiAll", null, "sp");

            KullaniciPersonelEntity myKullaniciPersonel = null;
            while (KullaniciPersonelRdr.Read())
            {
                myKullaniciPersonel.PersonelId = Convert.ToInt32(KullaniciPersonelRdr["PersonelId"]);
                myKullaniciPersonel.KullaniciId = Convert.ToInt32(KullaniciPersonelRdr["KullaniciId"]);
                myKullaniciPersonel.YetkiId = Convert.ToInt32(KullaniciPersonelRdr["YetkiId"]);


            }
            return myKullaniciPersonel;

        }
        //Yeni Kullanici Personel Verisi Gir.(insert)
        public int InsertKullaniciPersonel(KullaniciPersonelEntity EklenecekKullaniciPersonel)

        {
            SqlParameter[] KullaniciPersonelParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "PersonelId",
                    Value = EklenecekKullaniciPersonel.PersonelId
                },
                new SqlParameter
                {
                    ParameterName = "KullaniciId",
                    Value = EklenecekKullaniciPersonel.KullaniciId
                },
                 new SqlParameter {

                    ParameterName="YetkiId",
                    Value=EklenecekKullaniciPersonel.YetkiId

                },


            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_InsertKullaniciPersonel", KullaniciPersonelParametreleri, "sp");

            return etkilenenSatir;


        }
        #endregion
    }
}
