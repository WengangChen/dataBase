using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Security;

namespace databaseSever
{
    class DataBaseSql
    {
        System.Data.SqlClient.SqlConnection connection;
        public DataBaseSql()
        {
            //Data Source = localhost; Initial Catalog = 数据库名; User ID = 用户名; Password = 密码
            string connectString = "Data Source=localHost;Initial Catalog=DataBase;User ID = admin;password = 0";
            connection = new SqlConnection(connectString);
            connection.Open();
        }
        public void run(string s)
        {
            SqlCommand sqlCommand = new SqlCommand(s);
            sqlCommand.ExecuteNonQuery();
        }
         ~DataBaseSql ()
        {
            connection.Close();
        }
    }
}
