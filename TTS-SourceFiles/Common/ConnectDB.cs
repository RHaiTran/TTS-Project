using System;
using System.Data.SqlClient;
using TTS_SourceFiles.Common;

namespace TTS_SourceFiles.Common
{
    public static class ConnectDB
    {
        public static SqlConnection ConnectDataBase()
        {
            string connectionString = GetConnectionString.ConnectionStrings;
            using(var conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                }
                catch(SqlException)
                {
                    throw new Exception("SQL_EXCEPTION");
                }
                catch(InvalidOperationException)
                {
                    throw new Exception("INVALID_OPERATION_EXCEPTION");
                }
            }
            return new SqlConnection(connectionString);
        }
    }
}