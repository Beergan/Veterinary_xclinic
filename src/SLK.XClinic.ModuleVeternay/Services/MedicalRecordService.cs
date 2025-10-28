using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RestEase;
using SLK.XClinic.Abstract;
using SLK.XClinic.Base;
using SLK.XClinic.ModuleVeternayCore;

public class MedicalRecordService : MyServiceBase, IMedicalRecordService
{
    private IWebHostEnvironment hostingEnv;
    private readonly ILogger<IMedicalRecordService> _log;
    private readonly string _ternantId;

    public MedicalRecordService(IMyContext ctx, ILogger<MedicalRecordService> logger, IWebHostEnvironment env) : base(ctx)
    {
        hostingEnv = env;
        _log = logger;
        //_ternantId = _ctx.TernantId;
    }
    public async Task<ResultOf<EntityVeternayMedicalRecord>> Get(Guid guid)
    {
        if (!_ctx.CheckPermission(PERMISSION.FILE_CUSTOMER_VIEW))
            return ResultOf<EntityVeternayMedicalRecord>.Error(_ctx.Text["You are not authorized!", "Bạn không có quyền!"]);
        try
        {
            var data = await _ctx.Repo<EntityVeternayMedicalRecord>().Query(t => t.Guid == guid)
                .SingleOrDefaultAsync();

            return ResultOf<EntityVeternayMedicalRecord>.Ok(data);
        }
        catch (Exception ex)
        {
            _log.LogError($"{_ctx.Summary} - {ex.Message}");
            return ResultOf<EntityVeternayMedicalRecord>.Error("Đã có lỗi xảy ra!");
        }
    }

    public async Task<ResultsOf<EntityVeternayMedicalRecord>> GetList()
    {
        if (!_ctx.CheckPermission(PERMISSION.CUSTOMER_VIEW))
            return ResultsOf<EntityVeternayMedicalRecord>.Error(_ctx.Text["You are not authorized!", "Bạn không có quyền!"]);
        try
        {
            var data = await _ctx.Set<EntityVeternayMedicalRecord>().Include(x=>x.Services).ThenInclude(x=>x.Service).Include(x=>x.Prescriptions).Include(x=>x.Pet).ToListAsync();

            return ResultsOf<EntityVeternayMedicalRecord>.Ok(data);
        }
        catch (Exception ex)
        {
            _log.LogError(ex.Message);
            return ResultsOf<EntityVeternayMedicalRecord>.Error("Đã có lỗi xảy ra!");
        }
    }

    public async Task<Result> Save([Body] EntityVeternayMedicalRecord info)
    {
        if (!_ctx.CheckPermission(PERMISSION.CUSTOMER_CREATE_UPDATE))
            return Result.Error(_ctx.Text["You are not authorized!", "Bạn không có quyền!"]);

        try
        {
          
            if (info.Id > 0)
            {
              
                await _ctx.Repo<EntityVeternayMedicalRecord>().Update(info);
            }
            else
            {
             
                await _ctx.Repo<EntityVeternayMedicalRecord>().Insert(info);

            }

            return Result.Ok();
        }
        catch (Exception ex)
        {
            _log.LogError(ex, _ctx.Summary);
            return Result.Error("Đã có lỗi xảy ra!");
        }
    }
    public Task<Result> SetToActiveEmployee(int id, Guid guidEmployee)
    {
        throw new NotImplementedException();
    }

    public async Task<Result> Delete(int id)
    {
        if (!_ctx.CheckPermission(PERMISSION.CUSTOMER_CREATE_UPDATE))
            return Result.Error(_ctx.Text["You are not authorized!", "Bạn không có quyền!"]);

        try
        {
            var item = await _ctx.Set<EntityVeternayMedicalRecord>().FindAsync(id);

            await _ctx.Repo<EntityVeternayMedicalRecord>().Remove(item);
            return Result.Ok();
        }
        catch (Exception ex)
        {
            _log.LogError($"{_ctx.Summary} - {ex.Message}");
            return Result.Error("Đã có lỗi xảy ra!");
        }
    }

}