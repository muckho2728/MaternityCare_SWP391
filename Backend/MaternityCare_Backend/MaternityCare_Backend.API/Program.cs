using Azure.Identity;
using MaternityCare_Backend.API.Extensions;
using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Service.AIServices;
using MaternityCare_Backend.Service.EmailServices;
using MaternityCare_Backend.Service.Extensions;
using MaternityCare_Backend.Service.SignalRServices;
using MaternityCare_Backend.Service.TransactionServices;
using Microsoft.AspNetCore.Identity;
using OfficeOpenXml;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options =>
{
	options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

//Azure Key Vault
var keyVaultUrl = new Uri(builder.Configuration.GetSection("KeyVaultUrl").Value!);
var azureCredential = new DefaultAzureCredential();
builder.Configuration.AddAzureKeyVault(keyVaultUrl, azureCredential);

builder.Services.AddScoped<IEmailSender, EmailSender>();
builder.Services.AddScoped<IAIService, AIService>();
builder.Services.ConfigureQuartz();
builder.Services.ConfigureSwaggerForAuthentication();
builder.Services.ConfigureDatabase(builder.Configuration);
builder.Services.ConfigureCors();
builder.Services.ConfigureJWT(builder.Configuration);
builder.Services.ConfigureAutomapper();
builder.Services.ConfigureManager();
builder.Services.ConfigureSignalR(builder.Configuration);
builder.Services.ConfigureGlobalException();
builder.Services.ConfigureBlobService(builder.Configuration);
builder.Services.AddScoped<IPasswordHasher<User>, PasswordHasher<User>>();
builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<Utils>();
//builder.Services.ConfigureRateLimitingOptions();



var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseExceptionHandler(opt => { });

app.UseHttpsRedirection();

//app.UseRateLimiter();

app.UseCors("CorsPolicy");

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.MapHub<NotificationHub>("/notification");

app.Run();