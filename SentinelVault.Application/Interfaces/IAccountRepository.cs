using SentinelVault.Domain.Entities;
using System.Security.Principal;

namespace SentinelVault.Application.Interfaces;

public interface IAccountRepository
{
    // Bir hesabı Id'sine göre getir
    Task<Account?> GetByIdAsync(Guid id);

    // Yeni bir hesap oluştur
    Task AddAsync(Account account);

    // Hesap bilgilerini güncelle (Örn: Bakiye değişince)
    Task UpdateAsync(Account account);
}