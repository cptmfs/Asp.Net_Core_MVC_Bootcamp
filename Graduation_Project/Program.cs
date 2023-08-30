using DataAccess.EntityFramework;
using DataAccess.Mappings;
using Entity;
using Graduation_Project.ViewModels;
using Graduation_Project.Views.Shared.ViewComponents;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ShoppingContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("shoppingCartDB")));
builder.Services.AddIdentity<AppUser,IdentityRole>().AddEntityFrameworkStores<ShoppingContext>();
builder.Services.AddScoped<CategoriesViewComponent>();
builder.Services.AddSession();
builder.Services.AddSingleton<IFileProvider>(new PhysicalFileProvider(Directory.GetCurrentDirectory()));
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.UseSession();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

ShoppingDbInitializer.SeedUsersAndRolesAsync(app).Wait();
app.Run();
