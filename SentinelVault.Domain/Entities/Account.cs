using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentinelVault.Domain.Entities
{
    internal class Account
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

        // Hesap aktif mi? (Siber güvenlik için veriyi silmeyiz, pasife çekeriz)
        public bool IsActive { get; set; } = true;
    }
}
