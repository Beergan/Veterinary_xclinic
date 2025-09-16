using Microsoft.EntityFrameworkCore;

namespace SLK.XClinic.Base;

public interface IEntityRegister
{
    void RegisterEntities(ModelBuilder modelbuilder);

    void Seed(IDbContext db);
}