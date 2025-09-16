using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using SLK.XClinic.Abstract;

namespace SLK.XClinic.Base;

public class ModuleAspNetRegister : IModuleAspNet
{
    public void BuildModule(IApplicationBuilder app)
    {
    }

    public void ConfigureServices(IServiceCollection services, Microsoft.Extensions.Configuration.IConfiguration config)
    {
        services.AddScoped<IServiceBase, MyServiceBase>();
    }
}