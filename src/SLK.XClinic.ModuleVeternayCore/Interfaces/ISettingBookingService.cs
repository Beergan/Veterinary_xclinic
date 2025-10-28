using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using RestEase;
using SLK.XClinic.Abstract;

namespace SLK.XClinic.ModuleVeternayCore;

[BasePath("api/SettingBooking")]
public interface ISettingBookingService : IServiceBase
{
    [Get(nameof(Get))]
    Task<ResultOf<EntityVeternayBooking>> Get(Guid guid);

    [Get(nameof(GetList))]
    Task<ResultsOf<EntityVeternayBooking>> GetList();


    [Post(nameof(Save))]
    Task<Result> Save([Body] EntityVeternayBooking info);

    Task<Result> SaveMediicalRecord(int id);

    [Get(nameof(SetToActiveEmployee))]
    Task<Result> SetToActiveEmployee(int id, Guid guidEmployee);
    [Post(nameof(Delete))]
    Task<Result> Delete (int id);
}