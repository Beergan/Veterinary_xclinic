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
using System.Net.WebSockets;
using Syncfusion.Blazor.Schedule.Internal;

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
            var data = await _ctx.Repo<EntityVeternayCustomer>().Query(t => t.Guid == guid).Include(x=>x.Pets)
                .SingleOrDefaultAsync();

            return ResultOf<EntityVeternayCustomer>.Ok(data);
        }
        catch (Exception ex)
        {
            _log.LogError($"{_ctx.Summary} - {ex.Message}");
            return ResultOf<EntityVeternayCustomer>.Error($"Đã có lỗi xảy ra! {ex.Message}");
        }
    }

    public async Task<ResultsOf<EntityVeternayCustomer>> GetList()
    {
        if (!_ctx.CheckPermission(PERMISSION.CUSTOMER_VIEW))
            return ResultsOf<EntityVeternayCustomer>.Error(_ctx.Text["You are not authorized!", "Bạn không có quyền!"]);
        try
        {
            var data = await _ctx.Set<EntityVeternayCustomer>().Include(x => x.Pets).ToListAsync();

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
                using ( var db = _ctx.ConnectDb())
                {
                    if (info.Pets != null)
                    {
                        var petscustomer = await db.Repo<EntityVeternayCustomer>()
                            .Query()
                            .AsNoTracking()
                            .Include(x => x.Pets)
                            .FirstOrDefaultAsync(x => x.Guid == info.Guid);
                        if (petscustomer != null)
                        {
                            var currentPetGuids = info.Pets.Select(x => x.Guid).ToList();
                            var petGuidsToRemove = petscustomer.Pets
                                .Where(x => !currentPetGuids.Contains(x.Guid))
                                .Select(x => x.Guid)
                                .ToList();

                            if (petGuidsToRemove.Any())
                            {
                                await db.Repo<EntityveternayPet>()
                                    .Query()
                                    .Where(x => petGuidsToRemove.Contains(x.Guid))
                                    .ExecuteDeleteAsync();
                            }
                        }
                    }
                    await db.Repo<EntityVeternayCustomer>().Update(info);
                    await db.SaveChangesAsync();
                }
            }
            else
            {
                await _ctx.Repo<EntityVeternayCustomer>().Insert(info);
            }
            return Result.Ok();
        }
        catch (Exception ex)
        {
            _log.LogError(ex, _ctx.Summary);
            return Result.Error($"Đã có lỗi xảy ra! {ex.Message}");
        }
    }
    public async Task<Result> SavePet([Body] EntityveternayPet pet)
    {
        if (!_ctx.CheckPermission(PERMISSION.CUSTOMER_CREATE_UPDATE))
            return Result.Error(_ctx.Text["You are not authorized!", "Bạn không có quyền!"]);

        try
        {
            if (pet.Id > 0)
            {
                await _ctx.Repo<EntityveternayPet>().Update(pet);
            }
            else
            {
                await _ctx.Repo<EntityveternayPet>().Insert(pet);
            }
            return Result.Ok();
        }
        catch (Exception ex)
        {
            _log.LogError(ex, _ctx.Summary);
            return Result.Error($"Đã có lỗi xảy ra! {ex.Message}");
        }
    }
    public async Task<ResultsOf<EntityVeternayPetType>> GetListPetsType()
    {
        if (!_ctx.CheckPermission(PERMISSION.CUSTOMER_VIEW))
            return new List<EntityVeternayPetType>();
        try
        {
            var data = await _ctx.Set<EntityVeternayPetType>().ToListAsync();
            return data;
        }
        catch (Exception ex)
        {
            _log.LogError(ex.Message);
            return new List<EntityVeternayPetType>();
        }
    }
    public Task<Result> SetToActiveEmployee(int id, Guid guidEmployee)
    {
        throw new NotImplementedException();
    }
    public async Task<Result> DeletePet(int id)
    {

        if (!_ctx.CheckPermission(PERMISSION.CUSTOMER_CREATE_UPDATE))
            return Result.Error(_ctx.Text["You are not authorized!", "Bạn không có quyền!"]);

        try
        {
            var item = await _ctx.Set<EntityveternayPet>().FindAsync(id);

            await _ctx.Repo<EntityveternayPet>().Remove(item);
            return Result.Ok();
        }
        catch (Exception ex)
        {
            _log.LogError($"{_ctx.Summary} - {ex.Message}");
            return Result.Error("Đã có lỗi xảy ra!");
        }
    }

}