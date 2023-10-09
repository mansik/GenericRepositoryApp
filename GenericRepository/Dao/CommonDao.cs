using System;
using System.Collections.Generic;
using System.Configuration;
using System.Configuration.Internal;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
