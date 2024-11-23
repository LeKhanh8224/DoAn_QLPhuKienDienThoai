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
        static string server_name = "DESKTOP-LRSJBGM\\SQLEXPRESS";
        public static string connection = "Data Source=" + server_name + ";Initial Catalog=QL_PKDIENTHOAI;Integrated Security=True";
        public SqlConnection conn = new SqlConnection(connection);
    }
}
