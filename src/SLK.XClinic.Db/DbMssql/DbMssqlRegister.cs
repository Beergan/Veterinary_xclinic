﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using SLK.XClinic.Base;
using SLK.XClinic.Db.DbMssql;
using SLK.XClinic.Abstract;

namespace SLK.XClinic.Db;

public class DbMssqlRegister
{
    public static void ConfigureServices(IServiceCollection services, IConfiguration config, Action<ModelBuilder> setup)
    {
        DbMssqlContext.SetupAction = setup;

        services.AddDbContext<DbMssqlContext>((sp, options) =>
        {
            var config = sp.GetRequiredService<IConfiguration>();
            options.UseSqlServer(config.GetConnectionString("DbMssqlConnection"));
        }, ServiceLifetime.Transient, ServiceLifetime.Transient);

        services.AddIdentity<SA_USER, IdentityRole>(options =>
        {
            options.SignIn.RequireConfirmedAccount = false;
            options.Lockout.AllowedForNewUsers = false;
            options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(2);
            options.Lockout.MaxFailedAccessAttempts = 3;
        })
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<DbMssqlContext>()
            .AddDefaultTokenProviders();

        services.AddTransient<IDbContext>(provider => provider.GetService(typeof(DbMssqlContext)) as IDbContext);

        using (var scope = services.BuildServiceProvider().CreateScope())
        {
            var db = scope.ServiceProvider.GetRequiredService<DbMssqlContext>();
            /* if (db.Database.EnsureCreated())
            {
            } */
        }
    }
}