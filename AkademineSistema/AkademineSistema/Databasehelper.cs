using System;
using System.Data.SqlClient;

public class DatabaseHelper
{
    private readonly string _connectionString;

    public DatabaseHelper()
    {
        _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AkademineSistemaDB"].ConnectionString;
    }

    public SqlConnection GetConnection()
    {
        return new SqlConnection(_connectionString);
    }
}
