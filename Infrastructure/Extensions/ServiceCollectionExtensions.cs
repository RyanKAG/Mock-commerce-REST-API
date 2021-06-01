using System;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using personalAPI.Data;
using personalAPI.Helper.SwaggerUtils;

namespace personalAPI.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDatabaseService(this IServiceCollection services, IConfiguration configuration)
        {
            string mySqlConnectionStr = configuration.GetConnectionString("CommanderConnection");
            services.AddDbContext<Context>(x => x.UseMySql(mySqlConnectionStr, ServerVersion.AutoDetect(mySqlConnectionStr)));
        }
        public static void AddJwtAuthService(this IServiceCollection services)
        {
            services.AddAuthentication(opt =>
                        {
                            opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                            opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                        })
                            .AddJwtBearer(options =>
                            {
                                options.SaveToken = true;
                                options.TokenValidationParameters = new TokenValidationParameters
                                {
                                    ValidateIssuer = false,
                                    ValidateAudience = false,
                                    ValidateLifetime = true,
                                    ValidateIssuerSigningKey = true,
                                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Environment.GetEnvironmentVariable("LOGIN_SECRET_KEY")))
                                };
                            });
        }

        public static void AddSwaggerService(this IServiceCollection services){
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "My Awesome API",
                    Version = "v1"
                });
                c.OperationFilter<HeaderFilter>();
            });
        }
    }
}