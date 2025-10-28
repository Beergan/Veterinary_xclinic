using Microsoft.AspNetCore.Mvc;
using SLK.XClinic.ModuleVeternayCore;
using Microsoft.Extensions.Logging;
using SLK.XClinic.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using System;

namespace SLK.XClinic.ModuleVeternay.Controllers; 

[Authorize]
[Route("api/VeternayCustomers/[action]")]
[ApiController]
public class VeternayCustomersController : VeternayCustomersService, IVeternayCustomer
{
    [Obsolete]
    public VeternayCustomersController(IMyContext ctx, ILogger<VeternayCustomersService> log, IWebHostEnvironment env) : base(ctx, log, env)
    {
    }
}