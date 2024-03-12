using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace GenericRepository.Dao
{
    internal class CommonDao
    {
        //public static string ConnectionString => ConfigurationManager.ConnectionStrings["cn"].ConnectionString;

        public static IDbConnection GetConnection()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        }
    }
}
