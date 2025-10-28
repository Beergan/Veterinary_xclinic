using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using RestEase;
using SLK.XClinic.Abstract;

namespace SLK.XClinic.ModuleVeternayCore;

[BasePath("api/SettingPets")]
public interface ISettingPetsService : IServiceBase
{
    [Get(nameof(Get))]
    Task<ResultOf<EntityVeternayPetType>> Get(Guid guid);

    [Get(nameof(GetList))]
    Task<ResultsOf<EntityVeternayPetType>> GetList();


    [Post(nameof(Save))]
    Task<Result> Save([Body] EntityVeternayPetType info);

    [Get(nameof(SetToActiveEmployee))]
    Task<Result> SetToActiveEmployee(int id, Guid guidEmployee);
}