using KutuphaneOtomasyonMVC.Models.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Veritabaný baðlantý dizesini al
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// DbContext'i servis koleksiyonuna ekle
builder.Services.AddDbContext<KutuphaneContext>(options =>
    options.UseSqlServer(connectionString)); // MSSQL kullanacaðýmýzý belirtiyoruz

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
