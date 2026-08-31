using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using SchoolManagementSystem.Application.Common.Interfaces;
using System.Data;

namespace SchoolManagementSystem.Infrastructure.Persistence.Connection;

public class DbConnectionFactory : IDbConnectionFactory
{
    private readonly string _connectionString;

    public DbConnectionFactory(IConfiguration configuration)
    {
        _connectionString =
            configuration.GetConnectionString("DefaultConnection")
            ?? throw new InvalidOperationException(
                "DefaultConnection is missing.");
    }

    public IDbConnection CreateConnection()
    {
        return new SqlConnection(_connectionString);
    }
}