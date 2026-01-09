using SentinelVault.Persistence; // Persistence katmanýndaki servisleri tanýmak için þart!

var builder = WebApplication.CreateBuilder(args);

// --- SERVÝS KAYITLARI (Dependency Injection) ---

builder.Services.AddControllers();

// Dün hazýrladýðýmýz Persistence servislerini (DbContext ve Repository) sisteme tanýtýyoruz.
// Eskisi: builder.Services.AddPersistenceServices();
// Yenisi:
builder.Services.AddPersistenceServices(builder.Configuration);

// Swagger/OpenAPI ayarlarý (Test ekraný için)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// --- HTTP REQUEST PIPELINE (Ýstek Hattý) ---

// Geliþtirme aþamasýnda Swagger (Test arayüzü) aktif olsun
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();