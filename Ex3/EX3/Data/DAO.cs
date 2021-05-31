using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3.Data
{
      class DAO
    {
        private SqlConnection sc;
        public SqlConnection connect()
        {
           string str = @"Data Source=ANDAUD;Initial Catalog=game;Integrated Security=SSPI";
            //数据库链接字符串
            sc = new SqlConnection(str);
            sc.Open();
            return sc;
        }
        public SqlCommand command(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, connect());
            return cmd;
        }
        public int Execute(String sql) //更新操作
        {
            return command(sql).ExecuteNonQuery();
        }
        public SqlDataReader read(String sql) //读取操作
        {
            return command(sql).ExecuteReader();
        }
        public void DAOClose()
        {
            sc.Close();
        }
    }
}
