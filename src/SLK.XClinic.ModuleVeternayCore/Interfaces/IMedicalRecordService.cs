using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using RestEase;
using SLK.XClinic.Abstract;

namespace SLK.XClinic.ModuleVeternayCore;

[BasePath("api/MedicalRecordService")]
public interface IMedicalRecordService : IServiceBase
{
    [Get(nameof(Get))]
    Task<ResultOf<EntityVeternayMedicalRecord>> Get(Guid guid);

    [Get(nameof(GetList))]
    Task<ResultsOf<EntityVeternayMedicalRecord>> GetList();


    [Post(nameof(Save))]
    Task<Result> Save([Body] EntityVeternayMedicalRecord info);

    [Get(nameof(SetToActiveEmployee))]
    Task<Result> SetToActiveEmployee(int id, Guid guidEmployee);
    [Post(nameof(Delete))]
    Task<Result> Delete (int id);
}