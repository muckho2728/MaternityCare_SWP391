using Azure.Storage.Blobs;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Infrastructure.Persistence;
using MaternityCare_Backend.Infrastructure.Repositories;
using MaternityCare_Backend.Service.IServices;
using MaternityCare_Backend.Service.Jobs;
using MaternityCare_Backend.Service.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Quartz;
using Quartz.Simpl;
using System.Text;
using System.Threading.RateLimiting;

namespace MaternityCare_Backend.API.Extensions
{
	public static class ServiceExtensions
	{

		public static void ConfigureQuartz(this IServiceCollection services)
		{
			services.AddQuartz(q =>
			{
				q.UseJobFactory<MicrosoftDependencyInjectionJobFactory>();
				q.ScheduleJob<NotificationJob>(trigger => trigger
					.WithIdentity("notificationTrigger", "group1")
					.StartNow()
					.WithSimpleSchedule(schedule => schedule.WithIntervalInSeconds(10)
					.RepeatForever()));
			});
			services.AddQuartzHostedService(opt =>
			{
				opt.WaitForJobsToComplete = true;
			});
		}
		public static void ConfigureDatabase(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddDbContext<RepositoryContext>(options =>
				options.UseSqlServer(configuration.GetSection("DbString").Value));
		}

		public static void ConfigureSignalR(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddSignalR().AddAzureSignalR(configuration.GetSection("SignalR").Value);
		}

		public static void ConfigureCors(this IServiceCollection services) => services.AddCors(options =>
		{
			//options.AddPolicy("CorsPolicy", builder =>
			//	builder.WithOrigins("http://localhost:5173")
			//	.AllowAnyMethod()
			//	.AllowAnyHeader()
			//	.AllowCredentials()
			//	.WithExposedHeaders("X-Pagination"));

			options.AddPolicy("CorsPolicy", builder =>
				builder.AllowAnyOrigin()
				.AllowAnyMethod()
				.AllowAnyHeader()
				.WithExposedHeaders("X-Pagination"));
		});

		public static void ConfigureManager(this IServiceCollection services)
		{
			services.AddScoped<IRepositoryManager, RepositoryManager>();
			services.AddScoped<IServiceManager, ServiceManager>();
		}

		public static void ConfigureGlobalException(this IServiceCollection services)
		{
			services.AddProblemDetails();
			services.AddExceptionHandler<GlobalExceptionHandler>();
		}

		public static void ConfigureJWT(this IServiceCollection services, IConfiguration configuration)
		{
			var jwtSettings = configuration.GetSection("JwtSettings");
			var secretKey = jwtSettings["secretKey"];

			services.AddAuthentication(opt =>
			{
				opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
				opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
			})
			.AddJwtBearer(options =>
			{
				options.TokenValidationParameters = new TokenValidationParameters
				{
					ValidateIssuer = true,
					ValidateAudience = true,
					ValidateLifetime = true,
					ValidateIssuerSigningKey = true,

					ValidIssuer = jwtSettings["validIssuer"],
					ValidAudience = jwtSettings["validAudience"],
					IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey))
				};
			});
		}

		public static void ConfigureSwaggerForAuthentication(this IServiceCollection services)
		{
			services.AddSwaggerGen(option =>
			{
				option.AddSecurityDefinition(JwtBearerDefaults.AuthenticationScheme, new Microsoft.OpenApi.Models.OpenApiSecurityScheme()
				{
					Description =
						"JWT Authorization header using the Bearer scheme. \r\n\r\n" +
						"Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\n" +
						"Example: \"Bearer 12345abcdef\"",
					Name = "Authorization",
					In = ParameterLocation.Header,
					Scheme = JwtBearerDefaults.AuthenticationScheme,
					Type = SecuritySchemeType.Http,
					BearerFormat = "JWT",
				});
				option.AddSecurityRequirement(new OpenApiSecurityRequirement()
				{
					{
						new OpenApiSecurityScheme()
						{
							Reference = new OpenApiReference()
							{
								Type = ReferenceType.SecurityScheme,
								Id = "Bearer"
							},
							Scheme = "oath2",
							Name = "Bearer",
							In = ParameterLocation.Header
						},
						new List<string>()
					}
				});
			});
		}

		public static void ConfigureBlobService(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddSingleton(u => new BlobServiceClient(configuration.GetSection("StorageAccount").Value));
			services.AddSingleton<IBlobService, BlobService>();
		}

		public static void ConfigureRateLimitingOptions(this IServiceCollection services)
		{
			services.AddRateLimiter(opt =>
			{
				opt.GlobalLimiter = PartitionedRateLimiter.Create<HttpContext, string>(context =>
					RateLimitPartition.GetFixedWindowLimiter("GlobalLimiter",
					partition => new FixedWindowRateLimiterOptions
					{
						AutoReplenishment = true,
						PermitLimit = 10,
						QueueLimit = 0,
						Window = TimeSpan.FromMinutes(1)
					}));

				opt.OnRejected = async (context, token) =>
				{
					context.HttpContext.Response.StatusCode = StatusCodes.Status429TooManyRequests;
					if (context.Lease.TryGetMetadata(MetadataName.RetryAfter, out var retryAfter))
						await context.HttpContext.Response
							.WriteAsync($"Too many requests. " +
							$"Please try again after {retryAfter.TotalSeconds} second(s).", token);
					else
						await context.HttpContext.Response
							.WriteAsync("Too many requests. Please try again later.", token);
				};
			});
		}
	}
}
