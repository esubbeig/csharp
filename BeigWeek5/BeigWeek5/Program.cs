using BeigWeek5.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//dependency injection for the Db context class:
//Step 1: get the outdirectory path for the application
var path = Directory.GetCurrentDirectory();

//Step 2: get the appsetting.json file where we have the connection string
IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build(); //gets the json file

//DI -- passing the connstring with correct path to the context class
builder.Services.AddDbContext<NPGoldContext>(options => options.UseSqlServer(configuration.GetConnectionString("NPGoldConnString").Replace("|DataDirectory|", path)));




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
