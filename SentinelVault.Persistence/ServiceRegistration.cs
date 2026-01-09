using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration; // Bunu eklemeyi unutma
using Microsoft.Extensions.DependencyInjection;
using SentinelVault.Application.Interfaces;
using SentinelVault.Persistence.Contexts;
using SentinelVault.Persistence.Repositories;

namespace SentinelVault.Persistence;

public static class ServiceRegistration
{
    // Artık parametre olarak 'IConfiguration' alıyoruz
    public static void AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        // appsettings.json dosyasındaki "DefaultConnection" adresini kullan diyoruz
        services.AddDbContext<SentinelVaultDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        services.AddScoped<IAccountRepository, AccountRepository>();
    }
}