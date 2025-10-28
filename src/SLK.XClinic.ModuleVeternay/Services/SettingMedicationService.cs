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

public class SettingMedicationService : MyServiceBase, ISettingMedicationService
{
    private IWebHostEnvironment hostingEnv;
    private readonly ILogger<SettingMedicationService> _log;
    private readonly string _ternantId;

    public SettingMedicationService(IMyContext ctx, ILogger<SettingMedicationService> logger, IWebHostEnvironment env) : base(ctx)
    {
        hostingEnv = env;
        _log = logger;
        //_ternantId = _ctx.TernantId;
    }

    public async Task<ResultOf<EntityVeternayMedication>> Get(Guid guid)
    {
        if (!_ctx.CheckPermission(PERMISSION.FILE_CUSTOMER_VIEW))
            return ResultOf<EntityVeternayMedication>.Error(_ctx.Text["You are not authorized!", "Bạn không có quyền!"]);
        try
        {
            var data = await _ctx.Repo<EntityVeternayMedication>().Query(t => t.Guid == guid)
                .SingleOrDefaultAsync();

            return ResultOf<EntityVeternayMedication>.Ok(data);
        }
        catch (Exception ex)
        {
            _log.LogError($"{_ctx.Summary} - {ex.Message}");
            return ResultOf<EntityVeternayMedication>.Error("Đã có lỗi xảy ra!");
        }
    }

    public async Task<ResultsOf<EntityVeternayMedication>> GetList()
    {
        if (!_ctx.CheckPermission(PERMISSION.CUSTOMER_VIEW))
            return ResultsOf<EntityVeternayMedication>.Error(_ctx.Text["You are not authorized!", "Bạn không có quyền!"]);
        try
        {
            var data = await _ctx.Set<EntityVeternayMedication>().Include(x => x.Category).ToListAsync();

            return ResultsOf<EntityVeternayMedication>.Ok(data);
        }
        catch (Exception ex)
        {
            _log.LogError(ex.Message);
            return ResultsOf<EntityVeternayMedication>.Error("Đã có lỗi xảy ra!");
        }
    }

    public async Task<Result> Save([Body] EntityVeternayMedication info)
    {
        if (!_ctx.CheckPermission(PERMISSION.CUSTOMER_CREATE_UPDATE))
            return Result.Error(_ctx.Text["You are not authorized!", "Bạn không có quyền!"]);

        try
        {
            if (info.Id > 0)
            {
                await _ctx.Repo<EntityVeternayMedication>().Update(info);

            }
            else
            {
                info.Guid = Guid.NewGuid();
                await _ctx.Repo<EntityVeternayMedication>().Insert(info);

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

    public async Task<ResultsOf<EntityVeternayMedicationCategory>> GetListCategory()
    {
        if (!_ctx.CheckPermission(PERMISSION.CUSTOMER_VIEW))
            return ResultsOf<EntityVeternayMedicationCategory>.Error(_ctx.Text["You are not authorized!", "Bạn không có quyền!"]);
        try
        {
            var data = await _ctx.Set<EntityVeternayMedicationCategory>().ToListAsync();

            return ResultsOf<EntityVeternayMedicationCategory>.Ok(data);
        }
        catch (Exception ex)
        {
            _log.LogError(ex.Message);
            return ResultsOf<EntityVeternayMedicationCategory>.Error("Đã có lỗi xảy ra!");
        }
    }

    public async Task<Result> SaveCategory([Body] EntityVeternayMedicationCategory info)
    {
        if (!_ctx.CheckPermission(PERMISSION.CUSTOMER_CREATE_UPDATE))
            return Result.Error(_ctx.Text["You are not authorized!", "Bạn không có quyền!"]);

        try
        {
            if (info.Id > 0)
            {
                await _ctx.Repo<EntityVeternayMedicationCategory>().Update(info);

            }
            else
            {
                await _ctx.Repo<EntityVeternayMedicationCategory>().Insert(info);

            }
            return Result.Ok();
        }
        catch (Exception ex)
        {
            _log.LogError(ex, _ctx.Summary);
            return Result.Error("Đã có lỗi xảy ra!");
        }
    }
    public async Task<Result> DeleteCat(int id)
    {
        if (!_ctx.CheckPermission(PERMISSION.CUSTOMER_CREATE_UPDATE))
            return Result.Error(_ctx.Text["You are not authorized!", "Bạn không có quyền!"]);

        try
        {
            var item = await _ctx.Set<EntityVeternayMedicationCategory>().FindAsync(id);

            await _ctx.Repo<EntityVeternayMedicationCategory>().Remove(item);
            return Result.Ok();
        }
        catch (Exception ex)
        {
            _log.LogError($"{_ctx.Summary} - {ex.Message}");
            return Result.Error("Đã có lỗi xảy ra!");
        }
    }
    public async Task<Result> Delete(int id)
    {
        if (!_ctx.CheckPermission(PERMISSION.CUSTOMER_CREATE_UPDATE))
            return Result.Error(_ctx.Text["You are not authorized!", "Bạn không có quyền!"]);

        try
        {
            var item = await _ctx.Set<EntityVeternayMedication>().FindAsync(id);

            await _ctx.Repo<EntityVeternayMedication>().Remove(item);
            return Result.Ok();
        }
        catch (Exception ex)
        {
            _log.LogError($"{_ctx.Summary} - {ex.Message}");
            return Result.Error("Đã có lỗi xảy ra!");
        }
    }
}