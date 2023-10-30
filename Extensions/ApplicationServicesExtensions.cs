using CitasAppAPI.Data;
using CitasAppAPI.Interfaces;
using CitasAppAPI.Services;
using Microsoft.EntityFrameworkCore;

namespace CitasAppAPI.Extensions;

public static class ApplicationServicesExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddDbContext<DataContext>(options => 
        {
            options.UseSqlite(config.GetConnectionString("DefaultConnection"));
        });

        services.AddCors();
        services.AddScoped<ITokenService, TokenService>();

        return services;
    }
}