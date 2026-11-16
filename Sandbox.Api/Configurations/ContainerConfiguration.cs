using System;
using System.Configuration;
using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Sandbox.Application;
using Sandbox.Domain;
using Sandbox.Infrastructure;

namespace Sandbox.Api;

public static class ContainerConfiguration
{
    public static void AddInfrastructure(this IServiceCollection services)
    {
        services.AddOptions();
        services.AddPersistence();
        
        services.AddScoped<ICurrentUser, CurrentApiUser>();
        services.AddScoped<IAuthTokenGenerator, JwtTokenGenerator>();
    }

    public static void AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IUserService, UserService>();
    }
    
    public static void AddPersistence(this IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>();
        
        services.AddScoped<IApplicationDbContext>(serviceProvider
            => serviceProvider.GetRequiredService<AppDbContext>());
    }
    
    public static void AddOptions(this IServiceCollection services)
    {
        var configuration = services
            .BuildServiceProvider()
            .GetRequiredService<IConfiguration>();
        
        services.Configure<SqliteOptions>(configuration.GetSection(SqliteOptions.Section));
        services.AddSingleton(s => s.GetRequiredService<IOptions<SqliteOptions>>().Value);
       
        services.Configure<JwtOptions>(configuration.GetSection(JwtOptions.Section));
        services.AddSingleton(s => s.GetRequiredService<IOptions<JwtOptions>>().Value);
    }
}