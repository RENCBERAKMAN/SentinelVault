using Microsoft.Extensions.DependencyInjection;
using SentinelVault.Application.Interfaces;
using SentinelVault.Persistence.Repositories;

namespace SentinelVault.Persistence;

public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        // Sisteme diyoruz ki: "Birisi IAccountRepository arayüzünü çağırırsa, 
        // ona gerçek işi yapan AccountRepository sınıfını ver."
        services.AddScoped<IAccountRepository, AccountRepository>();
    }
}