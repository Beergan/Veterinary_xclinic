using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using RestEase;
using SLK.XClinic.Abstract;

namespace SLK.XClinic.ModuleVeternayCore;

[BasePath("api/SettingMedication")]
public interface ISettingMedicationService : IServiceBase
{
    [Get(nameof(Get))]
    Task<ResultOf<EntityVeternayMedication>> Get(Guid guid);

    [Get(nameof(GetList))]
    Task<ResultsOf<EntityVeternayMedication>> GetList();
    [Get(nameof(GetListCategory))]
    Task<ResultsOf<EntityVeternayMedicationCategory>> GetListCategory();

    [Post(nameof(Save))]
    Task<Result> Save([Body] EntityVeternayMedication info);

    [Post(nameof(SaveCategory))]
    Task<Result> SaveCategory([Body] EntityVeternayMedicationCategory info);

    [Get(nameof(SetToActiveEmployee))]
    Task<Result> SetToActiveEmployee(int id, Guid guidEmployee);

    [Post(nameof(Delete))]
    Task<Result> Delete(int Id);
    [Post(nameof(DeleteCat))]
    Task<Result> DeleteCat(int Id);

}