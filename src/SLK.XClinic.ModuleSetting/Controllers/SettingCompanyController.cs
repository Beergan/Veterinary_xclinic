using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SLK.XClinic.Base;
using SLK.XClinic.ModuleSetting;
using SLK.XClinic.ModuleSettingCore;

namespace SLK.XClinic.ModuleSetting.Controllers;

[ApiAuthorize]
[Route("api/setting/[controller]/[action]")]
[ApiController]
public class SettingCompanyController : SettingCompanyService, ISettingCompanyService
{
    public SettingCompanyController(IMyContext ctx, ILogger<SettingCompanyService> log) : base(ctx, log)
    {
    }
}