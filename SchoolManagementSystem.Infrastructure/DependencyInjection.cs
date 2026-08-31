using Microsoft.Extensions.DependencyInjection;
using SchoolManagementSystem.Application.Common.Interfaces;
using SchoolManagementSystem.Infrastructure.Authentication;
using SchoolManagementSystem.Infrastructure.FileStorage;
using SchoolManagementSystem.Infrastructure.Persistence.Connection;

namespace SchoolManagementSystem.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services)
    {
        services.AddScoped<
            IDbConnectionFactory,
            DbConnectionFactory>();

        services.AddScoped<
            IFileStorageService,
            LocalFileStorageService>();

        services.AddScoped<
            IJwtService,
            JwtService>();

        return services;
    }
}