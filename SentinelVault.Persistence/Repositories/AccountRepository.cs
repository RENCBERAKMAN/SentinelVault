using Microsoft.EntityFrameworkCore;
using SentinelVault.Application.Interfaces;
using SentinelVault.Domain.Entities;
using SentinelVault.Persistence.Contexts;

namespace SentinelVault.Persistence.Repositories;

public class AccountRepository : IAccountRepository
{
    private readonly SentinelVaultDbContext _context;

    public AccountRepository(SentinelVaultDbContext context)
    {
        _context = context;
    }

    public async Task<Account?> GetByIdAsync(Guid id)
    {
        return await _context.Accounts.FindAsync(id);
    }

    public async Task AddAsync(Account account)
    {
        await _context.Accounts.AddAsync(account);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Account account)
    {
        _context.Accounts.Update(account);
        await _context.SaveChangesAsync();
    }
}