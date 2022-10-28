using Microsoft.EntityFrameworkCore;
using MVCDemo.Data;
using MVCDemo.Infrastucture;
using MVCDemo.Interfaces;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddTransient<IRepository, Repository>();
//Dodanie konfiguracji DemoDbContext
builder.Services.AddDbContext<DemoDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("OwneDB")));
//(options => options.UseInMemoryDatabase("OwneDB"));
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
