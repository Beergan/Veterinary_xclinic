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

public class QryHandlerCheckJobExists : MyServiceBase, IRequestHandler<CheckJobExists, bool>
{
    public QryHandlerCheckJobExists(IMyContext ctx) : base(ctx)
    {

    }

    public Task<bool> Handle(CheckJobExists request, CancellationToken cancellationToken)
    {
        bool result = _ctx.Repo<EntityEmployee>()
            .Query(x => x.JobGuid == request.JobGuid)
            .Any();

        return Task.FromResult(result);
    }
}