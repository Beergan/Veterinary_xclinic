using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using RestEase;
using SLK.XClinic.Abstract;

namespace SLK.XClinic.ModuleVeternayCore;

[BasePath("api/SettingServices")]
public interface ISettingServicesService : IServiceBase
{
    [Get(nameof(Get))]
    Task<ResultOf<EntityVeternayServices>> Get(Guid guid);

    [Get(nameof(GetList))]
    Task<ResultsOf<EntityVeternayServices>> GetList();


    [Post(nameof(Save))]
    Task<Result> Save([Body] EntityVeternayServices info);

    [Get(nameof(SetToActiveEmployee))]
    Task<Result> SetToActiveEmployee(int id, Guid guidEmployee);
    [Post(nameof(Delete))]
    Task<Result> Delete (int id);



}