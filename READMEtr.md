## Proje Başlığı: SentinelVault — Güvenli Finansal Cüzdan API

Kısa Özet: SentinelVault, banka seviyesinde güvenlik, veri bütünlüğü ve yüksek performans odaklı geliştirilmiş bir backend cüzdan simülasyonudur. Bu proje, "Clean Architecture" prensiplerini temel alarak, karmaşık finansal süreçlerin nasıl güvenli ve sürdürülebilir bir mimariyle yönetileceğini göstermek amacıyla inşa edilmiştir.

🏗️ Mimari Yapı (Temiz Mimari) Proje, bağımlılıkları minimize eden ve merkezi iş mantığını (Business Logic) koruyan 4 ana katmandan oluşur:

Core (Domain & Application): Sistemin kalbi ve beyni. Hiçbir dış teknolojiye bağımlı olmayan saf iş kuralları burada yer alır.

Infrastructure (Persistence): Veritabanı ve dış servislerin yönetildiği katman.

Presentation (Web API): Dış dünya ile iletişimi sağlayan, RESTful standartlarında geliştirilmiş giriş kapısı.

<hr style="border: 50px solid #4CAF50; margin: 20px 0;">

🛠️ Kullanılan Teknolojiler

.NET 8 (LTS): Modern ve yüksek performanslı runtime.

C# 12: En güncel dil özellikleri.

Entity Framework Core: Veritabanı yönetim sistemi (ORM).

JWT & Argon2: Kimlik doğrulama ve üst düzey şifreleme standartları.

🛡️ Neden SentinelVault? Bu proje sadece "veri ekleme-çıkarma" (CRUD) işlemi yapmaz. Şunlara odaklanır:

Veri Tutarlılığı (ACID): Para transferi gibi kritik işlemlerde asla veri kaybı yaşanmaz.

Güvenlik: Tüm hassas veriler şifrelenir, brute-force ve DDoS gibi saldırılara karşı savunma mekanizmaları içerir.

İzlenebilirlik (Audit Logging): Sistemdeki her kritik hareketin "kim, ne zaman, ne yaptı" şeklinde kaydı tutulur.

<hr style="border: 50px solid #4CAF50; margin: 20px 0;">

🚀 Mevcut Durum

[x] Proje mimarisinin ve katmanların oluşturulması.

[x] Domain modellerinin (Account Entity) tasarımı.

[ ] İş mantığı ve servis katmanlarının geliştirilmesi (Devam ediyor).