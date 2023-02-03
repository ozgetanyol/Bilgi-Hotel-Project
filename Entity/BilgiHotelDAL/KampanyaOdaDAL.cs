using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class KampanyaOdaDAL
    {
        #region CRUD Operations
        

        
        //Tüm Verileri Getir
        public KampanyaOdaEntity sp_KampanyaOdaListesiAll(int KampanyaId)
        {

            SqlDataReader KampanyaOdaRdr = BilgiHotelHelperSQL.myExecuteReader("sp_KampanyaOdaListesiAll", null, "sp");

            KampanyaOdaEntity myKampanyaOda = null;
            while (KampanyaOdaRdr.Read())
            {
                myKampanyaOda.KampanyaId = Convert.ToInt32(KampanyaOdaRdr["KampanyaId"]);
                myKampanyaOda.OdaId = Convert.ToInt32(KampanyaOdaRdr["OdaId"]);


            }
            return myKampanyaOda;

        }
        //Yeni Kampanya Oda Verisi Gir.(insert)
        public int InsertKampanyaOda(KampanyaOdaEntity EklenecekKampanyaOda)

        {
            SqlParameter[] KampanyaOdaParametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "KampanyaId",
                    Value = EklenecekKampanyaOda.KampanyaId
                },
                new SqlParameter
                {
                    ParameterName = "OdaId",
                    Value = EklenecekKampanyaOda.OdaId
                },
              

            };
            int etkilenenSatir = BilgiHotelHelperSQL.myExecuteNonQuery("sp_InsertGorevler", KampanyaOdaParametreleri, "sp");

            return etkilenenSatir;


        }
        #endregion
    }
}

