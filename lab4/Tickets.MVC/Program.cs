using Tickets.BL;
using Tickets.DAL;
using Microsoft.EntityFrameworkCore;
using Tickets.Models.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.Configure<ImageOptions>(
    builder.Configuration.GetSection("ImagesOptions"));

var connectionString = builder.Configuration.GetConnectionString("tickets");
builder.Services.AddDbContext<TicketsContext>(options
    => options.UseSqlServer(connectionString));

builder.Services.AddScoped<ITicketsRepo, TicketsRepo>();
builder.Services.AddScoped<ITicketsManager, TicketsManager>();

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
