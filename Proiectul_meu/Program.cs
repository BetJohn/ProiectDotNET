using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Proiectul_meu.Data;
using Proiectul_meu.Models;
using Proiectul_meu.Repositories;
using Proiectul_meu.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Proiectul_meu.Repositories.Interfaces;
using Proiectul_meu.Services.Interfaces;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<Contextul>(options => options.UseSqlServer(connectionString));

//builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true);

builder.Services.AddRazorPages();

builder.Services.AddTransient<ITricouRepository, TricouRepository>();
builder.Services.AddTransient<IBluzaRepository, BluzaRepository>();
builder.Services.AddTransient<ISoseteRepository, SoseteRepository>();
builder.Services.AddTransient<ITreningRepository, TreningRepository>();
builder.Services.AddTransient<IPantaloniRepository, PantaloniRepository>();
builder.Services.AddTransient<ITricouLaTreningRepository, TricouLaTreningRepository>();

builder.Services.AddTransient<ITricouService, TricouService>();
builder.Services.AddTransient<IBluzaService, BluzaService>();
builder.Services.AddTransient<ISoseteService, SoseteService>();
builder.Services.AddTransient<ITreningService, TreningService>();
builder.Services.AddTransient<IPantaloniService, PantaloniService>();
builder.Services.AddTransient<ITricouLaTreningService, TricouLaTreningService>();

/*builder.Services.AddIdentity<IdentityUser, IdentityRole>()*/

/*       .AddDefaultTokenProviders();*/
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.Configure<IdentityOptions>(options =>
{
    // Password settings.
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequireUppercase = true;
    options.Password.RequiredLength = 6;
    options.Password.RequiredUniqueChars = 1;

    // Lockout settings.
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.AllowedForNewUsers = true;

    // User settings.
    options.User.AllowedUserNameCharacters =
    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
    options.User.RequireUniqueEmail = false;
});

builder.Services.ConfigureApplicationCookie(options =>
{
    // Cookie settings
    options.Cookie.HttpOnly = true;
    options.ExpireTimeSpan = TimeSpan.FromMinutes(60);

    options.LoginPath = "/Identity/Account/Login";
    options.AccessDeniedPath = "/Identity/Account/AccessDenied";
    options.SlidingExpiration = true;
});

var app = builder.Build();


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action}/{id?}");

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();