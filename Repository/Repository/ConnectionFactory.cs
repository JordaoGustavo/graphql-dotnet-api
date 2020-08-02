using System.Data.SqlClient;

namespace Repository.Repository
{
    internal static class ConnectionFactory
    {
        internal static SqlConnection CreateConnection(string dbProviderName, string connectionString)
        {
            SqlConnection sqlConnection = null;

            if (!string.IsNullOrWhiteSpace(dbProviderName) && !string.IsNullOrWhiteSpace(connectionString))
                sqlConnection = new SqlConnection(string.Format(connectionString, dbProviderName));

            return sqlConnection;
        }
    }
}
