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
    public class QryHandlerListCustomer
        : MyServiceBase, IRequestHandler<QueryListCustomer, List<ModelListCustomer>>
    {
        public QryHandlerListCustomer(IMyContext ctx) : base(ctx) { }

        public async Task<List<ModelListCustomer>> Handle(QueryListCustomer request, CancellationToken cancellationToken)
        {
            var customers = await _ctx.Set<EntityVeternayCustomer>()
                .Include(c => c.Pets)
                .ThenInclude(p => p.PetType)
                .Where(c => !c.IsDeleted)
                .ToListAsync(cancellationToken);
            var result = customers.Select(c => new ModelListCustomer
            {
                Id = c.Id,
                Guid = c.Guid,
                FullName = c.FullName,
                Email = c.Email,
                Phone = c.Phone,
                Avatar = c.Avatar,
                Address = c.Address,
                CitizenID = c.CitizenID,
                DateOfBirth = c.DateOfBirth,
                Note = c.Note,
                Pets = c.Pets.Where(p => !p.IsDeleted).Select(p => new ModelPets
                {
                    Id = p.Id,
                    Guid = p.Guid,
                    Name = p.Name,
                    Species = p.Species,
                    Breed = p.Breed,
                    Age = p.Age,
                    Gender = p.Gender,
                    Color = p.Color,
                    Microchip = p.Microchip,
                    MedicalNotes = p.MedicalNotes,
                    PetTypeGuid = p.PetTypeGuid,
                }).ToList()
            }).ToList();
            return result;
        }
    }
}
