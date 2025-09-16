﻿using System.Linq;
using System.Security;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using SLK.XClinic.Base;
using SLK.XClinic.ModuleSettingCore;

namespace SLK.XClinic.ModuleSetting;

public class ModuleAspNetRegister : IModuleAspNet
{
    public void BuildModule(IApplicationBuilder app)
    {
        GlobalPermissions.Register(typeof(PERMISSION));
    }

    public void ConfigureServices(IServiceCollection services,
        Microsoft.Extensions.Configuration.IConfiguration config)
    {
        services.AddScoped<ISettingCompanyService, SettingCompanyService>();
        services.AddScoped<ISettingJobService, SettingJobService>();
        services.AddScoped<ISettingOfficeService, SettingOfficeService>();
    }
}