using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SLK.XClinic.Abstract;
using SLK.XClinic.Base;
using SLK.XClinic.ModuleEmployeeCore;

namespace SLK.XClinic.ModuleEmployee;

public class QryHandlerOptionEmployees : MyServiceBase, IRequestHandler<QueryOptionEmployees, List<OptionItem<Guid>>>
{
    public QryHandlerOptionEmployees(IMyContext ctx) : base(ctx)
    {

    }

    public async Task<List<OptionItem<Guid>>> Handle(QueryOptionEmployees request, CancellationToken cancellationToken)
    {
        return await _ctx.Repo<EntityEmployee>()
            .Query()
            .Select(x => new OptionItem<Guid> { Value = x.Guid, Text = x.FullName})
            .ToListAsync();
    }
}