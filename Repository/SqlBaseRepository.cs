using System;
using System.Data.SqlClient;

namespace Repository
{
    public class SqlBaseRepository
    {
        private String connectionString;
        
        public SqlBaseRepository(String sqlServerConnectionString) => this.connectionString = sqlServerConnectionString;

        internal SqlConnection Connection { get => SqlServerConnection.GetConnection(this.connectionString); }
    }
}
