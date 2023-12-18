using Dotnet.Homeworks.DataAccess.Bootstrap;
using Dotnet.Homeworks.MainProject.ServicesExtensions.Database;
using Dotnet.Homeworks.MainProject.ServicesExtensions.FeatureServices;
using Dotnet.Homeworks.MainProject.ServicesExtensions.Masstransit;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddEnvironmentVariables();

builder.Services.AddControllers();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie();

builder.Services.AddFeatureServices();
builder.Services.AddRepositories();
builder.Services.AddDatabaseContext(builder.Configuration);
builder.Services.AddMasstransitRabbitMq(builder.Configuration);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

await app.TryMigrateDatabaseAsync();

app.MapGet("/", () => "Hello World!");

app.MapControllers();

app.Run();