using MaternityCare_Backend.Infrastructure.Persistence;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

namespace MaternityCare_Backend.API.Extensions
{
	public static class ServiceExtensions
	{
		public static void ConfigureDatabase(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddDbContext<RepositoryContext>(options =>
				options.UseSqlServer(configuration.GetConnectionString("DbString")));
		}

		public static void ConfigureCors(this IServiceCollection services) => services.AddCors(options =>
		{
			options.AddPolicy("CorsPolicy", builder =>
				builder.AllowAnyOrigin()
				.AllowAnyMethod()
				.AllowAnyHeader()
				.WithExposedHeaders("X-Pagination"));
		});

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
	}
}
