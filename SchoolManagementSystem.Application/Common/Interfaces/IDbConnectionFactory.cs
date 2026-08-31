using System.Data;

namespace SchoolManagementSystem.Application.Common.Interfaces;

public interface IDbConnectionFactory
{
    IDbConnection CreateConnection();
}