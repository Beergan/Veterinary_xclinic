using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SLK.XClinic.Abstract;
using SLK.XClinic.Base;
using SLK.XClinic.ModuleVeternayCore;

namespace SLK.XClinic.ModuleVeternay
{
    public class QryHandlerListService
        : MyServiceBase, IRequestHandler<QueryListService, List<ModelService>>
    {
        public QryHandlerListService(IMyContext ctx) : base(ctx) { }

        public async Task<List<ModelService>> Handle(QueryListService request, CancellationToken cancellationToken)
        {
           var service = await _ctx.Repo<EntityVeternayServices>().Query().Where(x =>x.IsActive == true).ToListAsync();
            var result = service.Select(c => new ModelService
            {
                Id = c.Id,
                Guid = c.Guid,
                Name = c.Name,
                Price = c.Price,
                Description = c.Description,
                IsActive = c.IsActive
            }).ToList();
            return result;
        }
    }
}
