using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SLK.XClinic.Abstract;
using SLK.XClinic.Base;
using SLK.XClinic.ModuleVeternayCore;

namespace SLK.XClinic.ModuleVeternay;
 
public class EntityRegister : IEntityRegister
{
    public void RegisterEntities(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EntityVeternayCustomer>().HasAlternateKey(k => k.Guid);
        modelBuilder.Entity<EntityveternayPet>().HasAlternateKey(k => k.Guid);
        modelBuilder.Entity<EntityVeternayBooking>().HasAlternateKey(k => k.Guid);
        modelBuilder.Entity<EntityVeternayServices>().HasAlternateKey(k => k.Guid);
        modelBuilder.Entity<EntityVeternayVisit>().HasAlternateKey(k => k.Guid);
    }
    public void Seed(IDbContext db)
    {
        
    }
}