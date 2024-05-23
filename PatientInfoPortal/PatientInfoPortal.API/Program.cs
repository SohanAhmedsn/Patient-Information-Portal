using Microsoft.EntityFrameworkCore;
using PatientInfoPortal.API.Data;
using PatientInfoPortal.API.DBMigrationSeedServices;
using PatientInfoPortal.API.HostedServices;
using PatientInfoPortal.API.Repositories.IRepositories;
using PatientInfoPortal.API.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages()
    .AddRazorRuntimeCompilation();
// ConnectionString setup
builder.Services.AddDbContext<AppDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("db"), ma => ma.MigrationsAssembly("PatientInfoPortal.API")));

// Services
builder.Services.AddScoped<DbMigrationAndSeederService>();
builder.Services.AddHostedService<DbMigrationAndSeederHostedService>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddControllersWithViews().AddNewtonsoftJson(
    settings =>
    {
        settings.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize;
        settings.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;
    }
    );

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseStaticFiles();
app.MapDefaultControllerRoute();

app.Run();