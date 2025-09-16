using Microsoft.AspNetCore.Mvc;
using SLK.XClinic.ModuleEmployeeCore;
using Microsoft.Extensions.Logging;
using SLK.XClinic.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using System;

namespace SLK.XClinic.ModuleEmployee.Controllers;

[Authorize]
[Route("api/Employee/[action]")]
[ApiController]
public class EmployeeController : EmployeeService, IEmployeeService
{
    [Obsolete]
    public EmployeeController(IMyContext ctx, ILogger<EmployeeService> log, IWebHostEnvironment env) : base(ctx, log, env)
    {
    }
}