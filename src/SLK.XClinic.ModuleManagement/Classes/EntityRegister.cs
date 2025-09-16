﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Crypto.Prng;
using SLK.XClinic.Abstract;
using SLK.XClinic.Base;
using SLK.XClinic.ModuleManagementCore;
using Syncfusion.Blazor.Diagram;

namespace SLK.XClinic.ModuleManagement;

public class EntityRegister : IEntityRegister
{
    public void RegisterEntities(ModelBuilder modelBuilder)
    {
    }
    public void Seed(IDbContext db)
    {
    }
}