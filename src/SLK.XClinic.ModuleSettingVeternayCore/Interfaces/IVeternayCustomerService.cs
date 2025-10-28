using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using RestEase;
using SLK.XClinic.Abstract;

namespace SLK.XClinic.ModuleVeternayCore;

[BasePath("api/VeternayCustomer")]
public interface IVeternayCustomer : IServiceBase
{
    [Get(nameof(Get))]
    Task<ResultOf<EntityVeternayCustomer>> Get(Guid guid);

    [Get(nameof(GetList))]
    Task<ResultsOf<EntityVeternayCustomer>> GetList();


    [Post(nameof(Save))]
    Task<Result> Save([Body] EntityVeternayCustomer info);

    [Get(nameof(SetToActiveEmployee))]
    Task<Result> SetToActiveEmployee(int id, Guid guidEmployee);
}