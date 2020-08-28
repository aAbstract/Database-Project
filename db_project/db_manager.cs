using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace db_project
{
    class db_manager
    {
        private string conn_string = @"Data Source=" + System.Net.Dns.GetHostName() + @"\SQLEXPRESS;Initial Catalog=health_db;Integrated Security=True;";
        public SqlConnection conn_obj;
        public db_manager()
        {
            this.conn_obj = new SqlConnection(conn_string);
            conn_obj.Open();
        }
        public SqlDataReader execute_reader(SqlCommand cmd)
        {
            return cmd.ExecuteReader();
        }
        public void execute_nonreader(SqlCommand cmd)
        {
            cmd.ExecuteNonQuery();
        }
        public System.Data.ConnectionState get_conn_state()
        {
            return this.conn_obj.State;
        }
    }
}
