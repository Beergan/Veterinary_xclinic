﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SLK.XClinic.Abstract;
using SLK.XClinic.Base;
using SLK.XClinic.ModuleEmployeeCore;

namespace SLK.XClinic.ModuleEmployee;

public class EntityRegister : IEntityRegister
{
    public void RegisterEntities(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EntityEmployee>().HasAlternateKey(k => k.Guid);
        modelBuilder.Entity<EntityEmployeeDocument>().HasAlternateKey(k => k.Guid);
    }
    public void Seed(IDbContext db)
    {
        
    }
}