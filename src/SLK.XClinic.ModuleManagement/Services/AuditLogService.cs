using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RestEase;
using SLK.XClinic.Abstract;
using SLK.XClinic.Base;
using SLK.XClinic.ModuleManagementCore;

namespace SLK.XClinic.ModuleManagement;

public class AuditLogService : MyServiceBase, IAuditLogService
{
    private readonly ILogger<AuditLogService> _log;

    public AuditLogService(IMyContext ctx, ILogger<AuditLogService> logger) : base(ctx)
    {
        _log = logger;
    }

    public async Task<ResultsOf<AuditLog>> GetList()
    {
        var list = await _ctx.Repo<AuditLog>().Query().ToListAsync();

        return ResultsOf<AuditLog>.Ok(list);
    }

    
    public Task<bool> CheckAuditLog()
    {
        return Task.FromResult(_ctx.CheckPermission(PERMISSION.AUDIT_LOG));
    }
}