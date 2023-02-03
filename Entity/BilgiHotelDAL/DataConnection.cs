using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class DataConnection
    {
        //MsSQLServer Bağlantı Stringi
        public static string Get_MsSqLConnecitonString
        {
            get { return "Server = .;Database = db_Bilgi_Hotel; Trusted_Connection = True;"; }
        }
        //MsSql Server Bağlantı Stringi
        public static string Get_MsSqlConnectionString
        {
            get { return "Server=mySqlServerim;Database=BilgiHotelMySql; Uid=111;Pwd=111;"; }
        }
        
    }
}
