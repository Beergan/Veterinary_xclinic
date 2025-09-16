using Microsoft.EntityFrameworkCore;
using SLK.XClinic.Abstract;

namespace SLK.XClinic.Base;

public class EntityRegister : IEntityRegister
{
    public void RegisterEntities(ModelBuilder modelBuilder)
    {

    }

    public void Seed(IDbContext db)
    {
    }
}