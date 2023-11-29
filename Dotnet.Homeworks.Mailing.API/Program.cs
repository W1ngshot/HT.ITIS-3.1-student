using Dotnet.Homeworks.Mailing.API.ServicesExtensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMailingService();
builder.Services.AddMasstransitRabbitMq(builder.Configuration);

var app = builder.Build();

app.Run();