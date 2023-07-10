using System.Data.SqlClient;

namespace FMS.Services.AzueFileUploadAPI.DbContext
{
    public class DbConnection
    {
        private readonly string connectionString;

        public DbConnection(IConfiguration configuration)
        {
            connectionString = configuration.GetValue<string>("ConnectionStrings:DefaultConnection");
        }

        public SqlConnection EstablishConnection()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                return connection;
            }

        }
    }
}
