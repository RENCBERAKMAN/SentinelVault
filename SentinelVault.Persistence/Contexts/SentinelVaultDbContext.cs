using Microsoft.EntityFrameworkCore;
using SentinelVault.Domain.Entities;
using System.Collections.Generic;

namespace SentinelVault.Persistence.Contexts;

// 1. Başına 'public' ekledik.
// 2. ': DbContext' ekleyerek EF Core yeteneklerini aldık.
public class SentinelVaultDbContext : DbContext
{
    public SentinelVaultDbContext(DbContextOptions<SentinelVaultDbContext> options) : base(options)
    {
    }

    // Veritabanındaki 'Accounts' tablomuz
    public DbSet<Account> Accounts { get; set; }
}