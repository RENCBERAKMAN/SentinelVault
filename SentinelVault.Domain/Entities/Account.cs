namespace SentinelVault.Domain.Entities;

public class Account // Burayı 'public' yaptık
{
    // Hesabın kimlik numarası (Eşsiz)
    public Guid Id { get; set; }

    // Hesap sahibinin adı
    public string OwnerName { get; set; } = string.Empty;

    // Hesap numarası (Örn: TR1234...)
    public string AccountNumber { get; set; } = string.Empty;

    // Mevcut bakiye
    public decimal Balance { get; set; }

    // Hesabın oluşturulma tarihi
    public DateTime CreatedDate { get; set; }

    // Hesap aktif mi?
    public bool IsActive { get; set; } = true;
}