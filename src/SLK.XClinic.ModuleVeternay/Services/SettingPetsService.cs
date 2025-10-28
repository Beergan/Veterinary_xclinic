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

public class SettingPetService : MyServiceBase, ISettingPetsService 
{
    private IWebHostEnvironment hostingEnv;
    private readonly ILogger<ISettingPetsService> _log;
    private readonly string _ternantId;

    public SettingPetService(IMyContext ctx, ILogger<SettingPetService> logger, IWebHostEnvironment env) : base(ctx)
    {
        hostingEnv = env;
        _log = logger;
        //_ternantId = _ctx.TernantId;
    }

    public async Task<ResultOf<EntityVeternayPetType>> Get(Guid guid)
    {
        if (!_ctx.CheckPermission(PERMISSION.FILE_CUSTOMER_VIEW))
            return ResultOf<EntityVeternayPetType>.Error(_ctx.Text["You are not authorized!", "Bạn không có quyền!"]);
        try
        {
            var data = await _ctx.Repo<EntityVeternayPetType>().Query(t => t.Guid == guid)
                .SingleOrDefaultAsync();

            return ResultOf<EntityVeternayPetType>.Ok(data);
        }
        catch (Exception ex)
        {
            _log.LogError($"{_ctx.Summary} - {ex.Message}");
            return ResultOf<EntityVeternayPetType>.Error("Đã có lỗi xảy ra!");
        }
    }

    public async Task<ResultsOf<EntityVeternayPetType>> GetList()
    {
        if (!_ctx.CheckPermission(PERMISSION.CUSTOMER_VIEW))
            return ResultsOf<EntityVeternayPetType>.Error(_ctx.Text["You are not authorized!", "Bạn không có quyền!"]);
        try
        {
            var data = await _ctx.Set<EntityVeternayPetType>().ToListAsync();

            return ResultsOf<EntityVeternayPetType>.Ok(data);
        }
        catch (Exception ex)
        {
            _log.LogError(ex.Message);
            return ResultsOf<EntityVeternayPetType>.Error("Đã có lỗi xảy ra!");
        }
    }

    public async Task<Result> Save([Body] EntityVeternayPetType info)
    {
        if (!_ctx.CheckPermission(PERMISSION.CUSTOMER_CREATE_UPDATE))
            return Result.Error(_ctx.Text["You are not authorized!", "Bạn không có quyền!"]);

        try
        {
            if (info.Id > 0)
            {
                await _ctx.Repo<EntityVeternayPetType>().Update(info);

            }
            else
            {
                info.Guid = Guid.NewGuid();
                await _ctx.Repo<EntityVeternayPetType>().Insert(info);

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
  
}