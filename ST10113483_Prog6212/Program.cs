using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ST101113483_Prog6212.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ST101113483_Prog6212Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ST101113483_Prog6212Context") ?? throw new InvalidOperationException("Connection string 'ST101113483_Prog6212Context' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add authentication
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(option =>
    {
        option.LoginPath = "/Accounts/Login";
        option.ExpireTimeSpan= TimeSpan.FromMinutes(10);
    });
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Accounts}/{action=Login}/{id?}");

app.Run();
