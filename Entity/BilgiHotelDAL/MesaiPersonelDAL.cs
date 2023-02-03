using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class MesaiPersonelDAL
    {
        #region CRUD Operations
        //ID ye göre Mesai Getir.(select with ID)
        public MesaiPersonelEntity getMesaipPersonelwithID(int MesaiId)
        {
            SqlParameter[] MesaiPersonelParametreleri =
            {
                new SqlParameter {

                    ParameterName="MesaiId",
                    Value=MesaiId

                },
            };

            SqlDataReader MesaiPersonelRdr = BilgiHotelHelperSQL.myExecuteReader("MesaiPersonelListesiWithID", MesaiPersonelParametreleri, "sp");

            MesaiPersonelEntity myMesaiPersonel = null;
            while (MesaiPersonelRdr.Read())
            {
                myMesaiPersonel.MesaiId = Convert.ToInt32(MesaiPersonelRdr["MesaiId"]);
                myMesaiPersonel.MesaiBaslangicTarihi = Convert.ToDateTime(MesaiPersonelRdr["MesaiBaslangicTarihi"]);
                myMesaiPersonel.MesaiBitisTarihi = Convert.ToDateTime(MesaiPersonelRdr["MesaiBitisTarihi"]);
                myMesaiPersonel.PersonelId = Convert.ToInt32(MesaiPersonelRdr["PersonelId"]);
                myMesaiPersonel.MesaiSaatFark = Convert.ToDecimal(MesaiPersonelRdr["MesaiSaatFark"]);



            }
            return myMesaiPersonel;

        }
        //Tüm Mesaileri Getir.(All)
        public MesaiPersonelEntity getMesaiPersonelAll(int MesaiId)
        {

            SqlDataReader MesaiPersonelRdr = BilgiHotelHelperSQL.myExecuteReader("sp_MesaiPersonelListesiAll", null, "sp");

            MesaiPersonelEntity myMesaiPersonel = null;
            while (MesaiPersonelRdr.Read())
            {
                myMesaiPersonel.MesaiId = Convert.ToInt32(MesaiPersonelRdr["MesaiId"]);
                myMesaiPersonel.MesaiBaslangicTarihi = Convert.ToDateTime(MesaiPersonelRdr["MesaiBaslangicTarihi"]);
                myMesaiPersonel.MesaiBitisTarihi = Convert.ToDateTime(MesaiPersonelRdr["MesaiBitisTarihi"]);
                myMesaiPersonel.PersonelId = Convert.ToInt32(MesaiPersonelRdr["PersonelId"]);
                myMesaiPersonel.MesaiSaatFark = Convert.ToDecimal(MesaiPersonelRdr["MesaiSaatFark"]);



            }
            return myMesaiPersonel;


        }
        //Yeni Mesai Verisi Gir.(insert)
        public int İnsertMesaiPersonel(MesaiPersonelEntity EklenecekMesai)

        {
            SqlParameter[] MesaiPersonelParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "MesaiId",
                    Value = EklenecekMesai.MesaiId
                },
                new SqlParameter
                {
                    ParameterName = "MesaiBaslangicTarihi",
                    Value = EklenecekMesai.MesaiBaslangicTarihi
                },
                new SqlParameter
                {
                    ParameterName = "MesaiBitisTarihi",
                    Value = EklenecekMesai.MesaiBitisTarihi
                },
                 new SqlParameter
                {
                    ParameterName = "PersonelId",
                    Value = EklenecekMesai.PersonelId
                },
                 new SqlParameter
                {
                    ParameterName = "MesaiSaatFark",
                    Value = EklenecekMesai.MesaiSaatFark
                },

            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_InsertMesaiPersonel", MesaiPersonelParametreleri, "sp");

            return etkilenenSatir;


        }
        //Var olan Mesai verisini ID sine göre bul ve değiştir. (update)
        public int UpdateMesaiPersonel(MesaiPersonelEntity DüzenlenecekMesai)

        {
            SqlParameter[] MesaiPersonelParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "MesaiId",
                    Value = DüzenlenecekMesai.MesaiId
                },
                new SqlParameter
                {
                    ParameterName = "MesaiBaslangicTarihi",
                    Value = DüzenlenecekMesai.MesaiBaslangicTarihi
                },
                new SqlParameter
                {
                    ParameterName = "MesaiBitisTarihi",
                    Value = DüzenlenecekMesai.MesaiBitisTarihi
                },
                 new SqlParameter
                {
                    ParameterName = "PersonelId",
                    Value = DüzenlenecekMesai.PersonelId
                },
                 new SqlParameter
                {
                    ParameterName = "MesaiSaatFark",
                    Value = DüzenlenecekMesai.MesaiSaatFark
                },

            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_UpdateMesaiPersonel", MesaiPersonelParametreleri, "sp");

            return etkilenenSatir;
        }
        //Var olan MesaiPersonel verisini ID sine göre sil. (delete)
        public int DeleteMesaiPersonel(MesaiPersonelEntity SilinecekMesaiPersonel)
        {
            SqlParameter[] MesaiPersonelParametreleri =
             {
                new SqlParameter {

                    ParameterName="MesaiId",
                    Value=SilinecekMesaiPersonel.MesaiId

                },
            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_DeleteMesaiPersonel", MesaiPersonelParametreleri, "sp");
            return etkilenenSatir;



        }
        #endregion
    }
}
