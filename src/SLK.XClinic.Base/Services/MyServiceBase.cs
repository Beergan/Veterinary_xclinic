using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SLK.XClinic.Abstract;
using Syncfusion.Blazor;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SLK.XClinic.Base;

public class MyServiceBase : IServiceBase
{
    protected readonly IMyContext _ctx;

    public MyServiceBase(IMyContext ctx)
    {
        _ctx = ctx;
    }

    [HttpGet]
    public Task<List<KeyValuePair<FeatureModel, Tuple<long, string, string>[]>>> GetListPermissions()
    {
        var list = GlobalPermissions.Dictionary.ToList();
        return Task.FromResult(list);
    }

    [HttpGet]
    public Task<List<OptionItem<Guid>>> GetOptionOffices()
    {
        return _ctx.Mediator.Send(new QueryOptionOffices());
    }

    [HttpGet]
    public Task<List<OptionItem<Guid>>> GetOptionJob()
    {
        return _ctx.Mediator.Send(new QueryOptionJob());
    }

    [HttpGet]
    public Task<OptionItem<Guid>> GetOptionCompany()
    {
        return _ctx.Mediator.Send(new QueryOptionCompany());
    }

    [HttpGet]
    public Task<ModelInfoEmployee> GetInfoEmployee(Guid guid)
    {
        return _ctx.Mediator.Send(new QueryInfoEmployee { Guid = guid });
    }
}