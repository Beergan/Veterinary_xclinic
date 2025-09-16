using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using RestEase;
using SLK.XClinic.Abstract;
using SLK.XClinic.ModuleVeternayCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using SLK.XClinic.Base;
using System.Data;
using Syncfusion.XlsIO;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace SLK.XClinic.ModuleVeternay;

public class VeternayCustomersService : MyServiceBase, IVeternayCustomer
{
    private IWebHostEnvironment hostingEnv;
    private readonly ILogger<VeternayCustomersService> _log;
    private readonly string _ternantId;

    public VeternayCustomersService(IMyContext ctx, ILogger<VeternayCustomersService> logger, IWebHostEnvironment env) : base(ctx)
    {
        hostingEnv = env;
        _log = logger;
        //_ternantId = _ctx.TernantId;
    }

    public async Task<ResultOf<EntityVeternayCustomer>> Get(Guid guid)
    {
        if (!_ctx.CheckPermission(PERMISSION.FILE_CUSTOMER_VIEW))
            return ResultOf<EntityVeternayCustomer>.Error(_ctx.Text["You are not authorized!", "Bạn không có quyền!"]);
        try
        {
            var data = await _ctx.Repo<EntityVeternayCustomer>().Query(t => t.Guid == guid)
                .SingleOrDefaultAsync();

            return ResultOf<EntityVeternayCustomer>.Ok(data);
        }
        catch (Exception ex)
        {
            _log.LogError($"{_ctx.Summary} - {ex.Message}");
            return ResultOf<EntityVeternayCustomer>.Error("Đã có lỗi xảy ra!");
        }
    }

    public async Task<ResultsOf<EntityVeternayCustomer>> GetList()
    {
        if (!_ctx.CheckPermission(PERMISSION.CUSTOMER_VIEW))
            return ResultsOf<EntityVeternayCustomer>.Error(_ctx.Text["You are not authorized!", "Bạn không có quyền!"]);
        try
        {
            var data = await _ctx.Set<EntityVeternayCustomer>().ToListAsync();

            return ResultsOf<EntityVeternayCustomer>.Ok(data);
        }
        catch (Exception ex)
        {
            _log.LogError(ex.Message);
            return ResultsOf<EntityVeternayCustomer>.Error("Đã có lỗi xảy ra!");
        }
    }

    public async Task<Result> Save([Body] EntityVeternayCustomer info)
    {
        if (!_ctx.CheckPermission(PERMISSION.CUSTOMER_CREATE_UPDATE))
            return Result.Error(_ctx.Text["You are not authorized!", "Bạn không có quyền!"]);

        try
        {
            if (info.Id > 0)
            {
                await _ctx.Repo<EntityVeternayCustomer>().Update(info);

                if(info.Pets != null)
                {
                    foreach (var pet in info.Pets)
                    {
                        if (pet.Id > 0)
                        {
                            await _ctx.Repo<EntityveternayPet>().Update(pet);
                        }
                        else
                        {
                            await _ctx.Repo<EntityveternayPet>().Insert(pet);
                        }
                    }
                }
            }
            else
            {
                if (info.Guid == Guid.Empty)
                {
                    foreach(var item in info.Pets.EmptyIfNull())
                    {
                        item.GuidCustomer = info.Guid;
                    }
                    await _ctx.Repo<EntityVeternayCustomer>().Insert(info);
                }
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