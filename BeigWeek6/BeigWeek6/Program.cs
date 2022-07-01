using BeigWeek6.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//Get current path
var path = Directory.GetCurrentDirectory();

// Get access to the connection string object through configuration settings
IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

//DI passes the connstring to context object with correct output derectory path.
builder.Services.AddDbContext<HogwartsContext>(option => option.UseSqlServer(configuration.GetConnectionString("HogwartsConnString").Replace("|DataDirectory|", path)));


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
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
