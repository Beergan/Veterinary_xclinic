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
using Syncfusion.Blazor.Gantt.Internal;

public class SettingBookingService : MyServiceBase, ISettingBookingService
{
    private IWebHostEnvironment hostingEnv;
    private readonly ILogger<ISettingBookingService> _log;
    private readonly string _ternantId;

    public SettingBookingService(IMyContext ctx, ILogger<SettingBookingService> logger, IWebHostEnvironment env) : base(ctx)
    {
        hostingEnv = env;
        _log = logger;
        //_ternantId = _ctx.TernantId;
    }
    public async Task<ResultOf<EntityVeternayBooking>> Get(Guid guid)
    {
        if (!_ctx.CheckPermission(PERMISSION.FILE_CUSTOMER_VIEW))
            return ResultOf<EntityVeternayBooking>.Error(_ctx.Text["You are not authorized!", "Bạn không có quyền!"]);
        try
        {
            var data = await _ctx.Repo<EntityVeternayBooking>().Query(t => t.Guid == guid)
                .SingleOrDefaultAsync();

            return ResultOf<EntityVeternayBooking>.Ok(data);
        }
        catch (Exception ex)
        {
            _log.LogError($"{_ctx.Summary} - {ex.Message}");
            return ResultOf<EntityVeternayBooking>.Error("Đã có lỗi xảy ra!");
        }
    }

    public async Task<ResultsOf<EntityVeternayBooking>> GetList()
    {
        if (!_ctx.CheckPermission(PERMISSION.CUSTOMER_VIEW))
            return ResultsOf<EntityVeternayBooking>.Error(_ctx.Text["You are not authorized!", "Bạn không có quyền!"]);
        try
        {
            var data = await _ctx.Repo<EntityVeternayBooking>().Query().Include(x => x.BookingServices).Include(x=>x.Customer).ToListAsync();

            return ResultsOf<EntityVeternayBooking>.Ok(data);
        }
        catch (Exception ex)
        {
            _log.LogError(ex.Message);
            return ResultsOf<EntityVeternayBooking>.Error("Đã có lỗi xảy ra!");
        }
    }

    public async Task<Result> Save([Body] EntityVeternayBooking info)
    {
        if (!_ctx.CheckPermission(PERMISSION.CUSTOMER_CREATE_UPDATE))
            return Result.Error(_ctx.Text["You are not authorized!", "Bạn không có quyền!"]);

        try
        {
          
            if (info.Id > 0)
            {
                using (var db = _ctx.ConnectDb())
                {
                    if (info.BookingServices != null)
                    {
                        var checkbookingService = await db.Repo<EntityVeternayBookingService>().Query(x => x.GuidBooking == info.Guid).Select(x => x.Guid).ToListAsync();
                        var newGuid = info.BookingServices.Select(x => x.Guid).ToHashSet();
                        var checkservice = info.BookingServices.ToList();
                        var removeService = checkbookingService.Where(x => !newGuid.Contains(x)).ToList();
                        if (removeService.Any())
                        {
                            await db.Repo<EntityVeternayBookingService>().Query(x => removeService.Contains(x.Guid)).ExecuteDeleteAsync();
                        }
                        await db.Repo<EntityVeternayBooking>().Update(info, commit: false);
                        await db.SaveChangesAsync();
                    }
                }
            }
            else
            {
                info.GuidEmployee = _ctx.GuidEmployee;
                if (info.BookingServices != null)
                {
                    foreach (var svc in info.BookingServices)
                    {
                        svc.GuidBooking = info.Guid;
                    }
                }
                await _ctx.Repo<EntityVeternayBooking>().Insert(info);

            }

            return Result.Ok();
        }
        catch (Exception ex)
        {
            _log.LogError(ex, _ctx.Summary);
            return Result.Error($"Đã có lỗi xảy ra!{ex.Message}");
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
            var item = await _ctx.Set<EntityVeternayBooking>().FindAsync(id);

            await _ctx.Repo<EntityVeternayBooking>().Remove(item);
            return Result.Ok();
        }
        catch (Exception ex)
        {
            _log.LogError($"{_ctx.Summary} - {ex.Message}");
            return Result.Error("Đã có lỗi xảy ra!");
        }
    }

    public async Task<Result> SaveMediicalRecord(int id)
    {
        if (!_ctx.CheckPermission(PERMISSION.CUSTOMER_CREATE_UPDATE))
            return Result.Error(_ctx.Text["You are not authorized!", "Bạn không có quyền!"]);

        try
        {
            using ( var db = _ctx.ConnectDb())
            {
                var item = await db.Repo<EntityVeternayBooking>().Query().Include(x=>x.BookingServices).FirstOrDefaultAsync(x=>x.Id == id);
              
                var medicalrecord = new EntityVeternayMedicalRecord()
                {
                    Guid = Guid.NewGuid(),
                    GuidPet = item.GuidPet,
                    VisitDate = item.AppointmentDate,
                    Notes = item.Notes,
                    TotalAmount = item.TotalAmount,
                    GuidCustomer = item.GuidCustomer,
                    PetId = item.PetId,
                    CustomerName = item.CustomerName,
                    Services = item.BookingServices.Select(x => new EntityVeternayMedicalService()
                    {
                        GuidService = x.GuidService,
                        Price = x.Price,
                        ServiceId = x.ServiceId,
                    }).ToList()
                };
                await db.Repo<EntityVeternayMedicalRecord>().Insert(medicalrecord, commit: false);
                item.GuidMedicalRecord = medicalrecord.Guid;
                item.MedicalRecord = medicalrecord;
                item.Status = "completed";
                await db.Repo<EntityVeternayBooking>().Update(item, commit: false);
                await db.SaveChangesAsync();

            }
            return Result.Ok();

        }
        catch (Exception ex)
        {
            _log.LogError($"{_ctx.Summary} - {ex.Message}");
            return Result.Error("Đã có lỗi xảy ra!");
        }
    }
}