﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Crypto.Prng;
using SLK.XClinic.Abstract;
using SLK.XClinic.Base;
using SLK.XClinic.ModuleSettingCore;
using Syncfusion.Blazor.Diagram;

namespace SLK.XClinic.ModuleSetting;

public class EntityRegister : IEntityRegister
{
    public void RegisterEntities(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EntityNoTifiCation>().HasAlternateKey(x => x.Guid);
        modelBuilder.Entity<EntityCompany>().HasAlternateKey(x => x.Guid);
        modelBuilder.Entity<EntityOffice>().HasAlternateKey(x => x.Guid);
        modelBuilder.Entity<EntityJob>().HasAlternateKey(x => x.Guid);
        modelBuilder.Entity<EntityNoTifiCation>()
           .Property(e => e.Guid_UserNoTify)
           .HasConversion(
               v => Newtonsoft.Json.JsonConvert.SerializeObject(v),
               v => Newtonsoft.Json.JsonConvert.DeserializeObject<Guid[]>(v)
           );
    }
    public void Seed(IDbContext db)
    {
        var company = new EntityCompany
        {
            Guid = Guid.NewGuid(),
            CompanyName = "Tên công ty",
            CompanyEmail = "info@gmail.com",
            CompanyLogo = "/assets/",
            CompanyPhone = "0123456789",
            CompanyWebSite = "WebSite công ty",
            CompanyOverview = "Giới thiệu về công ty",
        };

        db.Set<EntityCompany>().Add(company);

        db.Set<EntityOffice>().AddRange(
            new EntityOffice {Guid = Guid.Parse("15f0a586-a32f-457a-9523-7ab9c735ee83"), Name = "Sài Gòn", Address = "123 Phạm Văn Đồng, P. 3, Q. Gò Vấp", Email = "info@gmail.com", Phone = "0123456789", Active = true }
        );

        db.Set<EntityJob>().Add( new EntityJob
        {
            JobName = "Giám đốc"
        });
    }
}