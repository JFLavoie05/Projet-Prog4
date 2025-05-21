using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Projet_prog_4.Data;
using Serilog;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using static Projet_prog_4.Data.Projet_prog_4Context;
using System.Text;
using Projet_prog_4.Auth;

namespace Projet_prog_4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<Projet_prog_4Context>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("Projet_prog_4Context") ?? throw new InvalidOperationException("Connection string 'Projet_prog_4Context' not found.")));

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowFrontend", policy =>
                {
                    policy.WithOrigins("http://localhost:3000") 
                          .AllowAnyHeader()
                          .AllowAnyMethod();
                });
            });


            // Add services to the container.
            // For Identity
            builder.Services.AddIdentityCore<IdentityUser>()
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<Projet_prog_4Context>()
            .AddDefaultTokenProviders();
            // Adding Authentication
            builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            // Adding Jwt Bearer
            .AddJwtBearer(options =>
             {
                 options.SaveToken = true;
                 options.RequireHttpsMetadata = false;
                 options.TokenValidationParameters = new TokenValidationParameters()
                 {
                     ValidateIssuer = true,
                     ValidateAudience = true,
                     ValidAudience = builder.Configuration["JWT:Audience"],
                     ValidIssuer = builder.Configuration["JWT:Issuer"],
                     IssuerSigningKey = new
     SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Secret"]))
                 };
             });

            // avec DTO
            //builder.Services.AddAutoMapper(typeof(AutoMapperConfig));

            builder.Host.UseSerilog((context, config) => {
                config.WriteTo.Console()
                .ReadFrom.Configuration(context.Configuration)
                .Enrich.FromLogContext().Enrich.WithMachineName()
                .Enrich.WithEnvironmentName()
                .Enrich.WithProperty("ApplicationName", context.HostingEnvironment.ApplicationName);
            });

            builder.Services.AddScoped<IAuthManager, AuthManager>();



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors("AllowFrontend");
            app.UseHttpsRedirection();

            app.UseAuthentication();
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
