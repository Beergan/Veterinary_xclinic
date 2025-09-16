﻿using System.Linq;
using System.Security;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using SLK.XClinic.Base;
using SLK.XClinic.ModuleEmployeeCore;

namespace SLK.XClinic.ModuleEmployee;

public class ModuleAspNetRegister : IModuleAspNet
{
    public void BuildModule(IApplicationBuilder app)
    {
        GlobalPermissions.Register(typeof(PERMISSION));
    }

    public void ConfigureServices(IServiceCollection services, Microsoft.Extensions.Configuration.IConfiguration config)
    {
        services.AddScoped<IEmployeeService, EmployeeService>();
    }
}