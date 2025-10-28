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
        modelBuilder.Entity<EntityVeternayBookingService>().HasAlternateKey(k => k.Guid);
        modelBuilder.Entity<EntityVeternayServices>().HasAlternateKey(k => k.Guid);
        modelBuilder.Entity<EntityVeternayDisease>().HasAlternateKey(k => k.Guid);
        modelBuilder.Entity<EntityVeternayDiseaseType>().HasAlternateKey(k => k.Guid);
        modelBuilder.Entity<EntityVeternayMedicalAttachment>().HasAlternateKey(k => k.Guid);
        modelBuilder.Entity<EntityVeternayMedicalDisease>().HasAlternateKey(k => k.Guid);
        modelBuilder.Entity<EntityVeternayMedicalPrescription>().HasAlternateKey(k => k.Guid);
        modelBuilder.Entity<EntityVeternayMedicalRecord>().HasAlternateKey(k => k.Guid);
        modelBuilder.Entity<EntityVeternayMedicalService>().HasAlternateKey(k => k.Guid);
        modelBuilder.Entity<EntityVeternayMedication>().HasAlternateKey(k => k.Guid);
        modelBuilder.Entity<EntityVeternayPetType>().HasAlternateKey(k => k.Guid);
        modelBuilder.Entity<EntityVeternayMedicationCategory>().HasAlternateKey(k => k.Guid);
    }

    public void Seed(IDbContext db)
    {
        
    }
}