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

public class SettingServicesService : MyServiceBase, ISettingServicesService 
{
    private IWebHostEnvironment hostingEnv;
    private readonly ILogger<ISettingServicesService> _log;
    private readonly string _ternantId;

    public SettingServicesService(IMyContext ctx, ILogger<SettingServicesService> logger, IWebHostEnvironment env) : base(ctx)
    {
        hostingEnv = env;
        _log = logger;
        //_ternantId = _ctx.TernantId;
    }
    public async Task<ResultOf<EntityVeternayServices>> Get(Guid guid)
    {
        if (!_ctx.CheckPermission(PERMISSION.FILE_CUSTOMER_VIEW))
            return ResultOf<EntityVeternayServices>.Error(_ctx.Text["You are not authorized!", "Bạn không có quyền!"]);
        try
        {
            var data = await _ctx.Repo<EntityVeternayServices>().Query(t => t.Guid == guid)
                .SingleOrDefaultAsync();

            return ResultOf<EntityVeternayServices>.Ok(data);
        }
        catch (Exception ex)
        {
            _log.LogError($"{_ctx.Summary} - {ex.Message}");
            return ResultOf<EntityVeternayServices>.Error("Đã có lỗi xảy ra!");
        }
    }

    public async Task<ResultsOf<EntityVeternayServices>> GetList()
    {
        if (!_ctx.CheckPermission(PERMISSION.CUSTOMER_VIEW))
            return ResultsOf<EntityVeternayServices>.Error(_ctx.Text["You are not authorized!", "Bạn không có quyền!"]);
        try
        {
            var data = await _ctx.Set<EntityVeternayServices>().ToListAsync();

            return ResultsOf<EntityVeternayServices>.Ok(data);
        }
        catch (Exception ex)
        {
            _log.LogError(ex.Message);
            return ResultsOf<EntityVeternayServices>.Error("Đã có lỗi xảy ra!");
        }
    }

    public async Task<Result> Save([Body] EntityVeternayServices info)
    {
        if (!_ctx.CheckPermission(PERMISSION.CUSTOMER_CREATE_UPDATE))
            return Result.Error(_ctx.Text["You are not authorized!", "Bạn không có quyền!"]);

        try
        {
            var check = await _ctx.Repo<EntityVeternayServices>().Query(x => x.Code == info.Code).FirstOrDefaultAsync(); 
            if (check != null)
            {
                return Result.Error(_ctx.Text["The code already exists !", "Mã đã tồn tại!"]);
            }
            if (info.Id > 0)
            {
                await _ctx.Repo<EntityVeternayServices>().Update(info);

            }
            else
            {
                info.Guid = Guid.NewGuid();
                await _ctx.Repo<EntityVeternayServices>().Insert(info);

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
            var item = await _ctx.Set<EntityVeternayServices>().FindAsync(id);

            await _ctx.Repo<EntityVeternayServices>().Remove(item);
            return Result.Ok();
        }
        catch (Exception ex)
        {
            _log.LogError($"{_ctx.Summary} - {ex.Message}");
            return Result.Error("Đã có lỗi xảy ra!");
        }
    }
}