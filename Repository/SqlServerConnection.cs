using System.Runtime.CompilerServices;
using System;
using System.Data.SqlClient;

namespace Repository
{
    public class SqlServerConnection
    {
        private static SqlConnection instance; 
        private SqlServerConnection() { }

        public static SqlConnection GetConnection(String connectionStr)
        {
            SqlConnection _conn;
            if(instance == null)
            {
                _conn = new SqlConnection(connectionStr);
            }
            else
            {
                _conn = instance;
            }

            _conn.Open();
            return _conn;
        }
    }
}
