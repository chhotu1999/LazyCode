using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data; 

namespace MeroPasal.DataAccess
{
    public class DataAccessService : IDataAccessService
    {
        private readonly IConfiguration _configuration;
        public DataAccessService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<IDbConnection> GetConnection()
        {
            try
            {
                var connectionString = _configuration.GetConnectionString("DefaultConnection");
                SqlConnection conn = new(connectionString);
                conn.Open();
                return conn;
            }

            catch (Exception)
            {
                throw;
            }

        }
    }
}
