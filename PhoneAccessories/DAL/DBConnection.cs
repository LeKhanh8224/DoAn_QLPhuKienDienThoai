using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBConnection
    {
        public static string connection = "Data Source=DESKTOP-LRSJBGM\\SQLEXPRESS;Initial Catalog=QL_PKDIENTHOAI;";
        public SqlConnection conn = new SqlConnection(connection);
    }
}
