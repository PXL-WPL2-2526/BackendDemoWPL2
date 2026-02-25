using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Infrastructure.Repositories
{
    public class Repository
    {
        private readonly string _connectionString =
            "Jouw_sql_connection_string";

        public Repository() { }

        protected IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
