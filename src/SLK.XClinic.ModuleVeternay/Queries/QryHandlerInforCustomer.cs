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
    public class QryHandlerInforCustomer
        : MyServiceBase, IRequestHandler<QueryInforCustomer, ModelListCustomer>
    {
        public QryHandlerInforCustomer(IMyContext ctx) : base(ctx) { }

        public async Task<ModelListCustomer> Handle(QueryInforCustomer request, CancellationToken cancellationToken)
        {
            var customers = await _ctx.Repo<EntityVeternayCustomer>().Query(x => x.Guid == request.Guid)
                .Select(x => new ModelListCustomer
                {
                    Id = x.Id,
                    Guid = x.Guid,
                    FullName = x.FullName,
                    Email = x.Email,
                    Phone = x.Phone,
                    Avatar = x.Avatar,
                    Address = x.Address,
                    CitizenID = x.CitizenID,
                    DateOfBirth = x.DateOfBirth,
                    Note = x.Note,
                }).FirstOrDefaultAsync();
            return customers;
        }
    }
}
