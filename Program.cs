using Microsoft.EntityFrameworkCore;
using BaiKiemTraKy072025.Data; 
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<BaiKiemTraKy072025ApplicationDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("BaiKiemTraKy072025ApplicationDbContext") ?? throw new InvalidOperationException("Connection string 'BaiKiemTraKy072025ApplicationDbContext' not found.")));


builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
