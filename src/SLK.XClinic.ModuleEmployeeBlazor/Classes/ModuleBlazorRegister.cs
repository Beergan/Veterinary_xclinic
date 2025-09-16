using Microsoft.Extensions.DependencyInjection;
using RestEase.HttpClientFactory;
using SLK.XClinic.Abstract;
using SLK.XClinic.ModuleEmployeeCore;

namespace SLK.XClinic.ModuleEmployeeBlazor;

public class ModuleBlazorRegister : IModuleBlazor
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddRestEaseClient<IEmployeeService>(AppStatic.BaseAddress);
    }
}