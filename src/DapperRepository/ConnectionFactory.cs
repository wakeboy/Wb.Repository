using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DapperRepository
{
    public static class ConnectionFactory
    {
        public static SqlConnection GetConnection()
        {
            try
            {
                var connection = new SqlConnection();
                connection.ConnectionString = "";
                return connection;
            }
            catch (Exception ex)
            {
                // TODO: Log exception
                throw;
            }
        }
    }
}
