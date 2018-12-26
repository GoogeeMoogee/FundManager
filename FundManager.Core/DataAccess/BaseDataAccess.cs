using System.Data;
using System.Data.SqlClient;

namespace FundManager.Core.DataAccess
{
    public class BaseDataAccess
    {
        private readonly string _connectionString;

        public BaseDataAccess()
        {
            _connectionString = ConfigurationManager.Vault["DBConnectionString"] as string;
        }

        public IDbConnection DbConnection => new SqlConnection(_connectionString);
    }
}
