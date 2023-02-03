using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    internal class BilgiHotelHelperSQL
    {
        //SqlConnection
      private static SqlConnection myConnection()
        {
            return new SqlConnection(DataConnection.Get_MsSqLConnecitonString);
        }
      //private SqlConnection myConnection(string MyProvider)
      //  {
      //      //switch (MyProvider)
      //      //{
      //      //    case "sql": return new SqlConnection(DataConnection.Get_MsSqlConnectionString); break;
      //      //    //case "oracle":
      //      //    //    return new SqlConnection(DataConnection.Get_MsSqlConnectionString); break;
      //      //    default:
      //      //        return new SqlConnection(DataConnection.Get_MsSqlConnectionString); break;
      //      //        break;
      //      }
      //  }

        //SqlCommand

        public static SqlCommand mySqlCommand(string mySqlScript, string myCommandType, SqlParameter[] myParameters)
        {
            SqlCommand cmd = new SqlCommand(mySqlScript, myConnection());
            if (myCommandType=="sp")
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
            }
            if (myParameters != null)
            {
                cmd.Parameters.AddRange(myParameters);
            }
            return cmd;
        }

        //Execute Metodlar 
        //SqlCommand, ExecuteNonQuery
        public static int myExecuteNonQuery (string spName, SqlParameter[] cmdParams, string myCommandType)
        {
            SqlCommand cmd = mySqlCommand(spName, myCommandType, cmdParams);

            cmd.Connection.Open();
            int donensatir = cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            return donensatir;  
        }
             
        // SqlCommand, ExecuteScalar
        public static object myExecuteScalar(string spName, SqlParameter[] cmdParams, string myCommandType)
        {
            SqlCommand cmd = mySqlCommand(spName, myCommandType,cmdParams);
            cmd.Connection.Open();
            object donenDeger = cmd.ExecuteScalar();
            cmd.Connection.Close();
            return donenDeger;
        }
        //SqlCommand, ExecuteReader
        public static SqlDataReader myExecuteReader(string spName, SqlParameter[] cmdParams, string myCommandType)
        {
            
            SqlCommand cmd = mySqlCommand(spName, myCommandType, cmdParams);
            cmd.Connection.Open();
            SqlDataReader read = cmd.ExecuteReader();

           
            return read;
        }

        

      
    }
}
