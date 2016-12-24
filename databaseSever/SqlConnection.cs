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
            string connectionString = @"server=DESKTOP-1TVQMNU\SQLEXPRESS;database=DataBase;uid=admin;pwd=12345678";
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //需要返回表的指令
        public SqlDataReader runS(string s)
        {
            SqlCommand sqlCommand = new SqlCommand(s);
            sqlCommand.Connection = connection;
            return sqlCommand.ExecuteReader();
        }

        //不需要返回表的指令
        public void runO(string s)
        {
            SqlCommand sqlCommand = new SqlCommand(s);
            sqlCommand.Connection = connection;
            sqlCommand.ExecuteReader();
        }
         ~DataBaseSql ()
        {
            connection.Close();
        }
    }
}
