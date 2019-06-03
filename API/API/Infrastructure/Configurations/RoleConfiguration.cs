using CLERP.API.Domain.Models;
using CLERP.API.Infrastructure.Configurations.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace CLERP.API.Infrastructure.Configurations
{
    public class RoleConfiguration : EntityTypeConfiguration<Role>
    {
        public override void Configure(EntityTypeBuilder<Role> builder)
        {
            base.Configure(builder);

            builder.ToTable("Roles");
            builder.Property(x => x.Name).IsRequired();

            // Seed data
            var seedRoles = new List<Role>()
            {
                new Role()
                {
                    Guid = new Guid("90F17BBE-EDB8-4E0F-8492-B18D130EF058"),
                    CreatedBy = "system",
                    Creation = DateTime.Now,
                    LastModifiedBy = "system",
                    LastModified = DateTime.Now,
                    Name = "Logistic",
                    Description = "Employee from the logistics department"
                },
                new Role()
                {
                    Guid = new Guid("D34CE4A4-6FAE-4623-9CF9-7468A19781FB"),
                    CreatedBy = "system",
                    Creation = DateTime.Now,
                    LastModifiedBy = "system",
                    LastModified = DateTime.Now,
                    Name = "Finance",
                    Description = "Employee from the finances department"
                },
                new Role()
                {
                    Guid = new Guid("58457E73-DA9F-4F6E-B31B-7F89807E320C"),
                    CreatedBy = "system",
                    Creation = DateTime.Now,
                    LastModifiedBy = "system",
                    LastModified = DateTime.Now,
                    Name = "Purchase",
                    Description = "Employee from the purchases department"
                },
                new Role()
                {
                    Guid = new Guid("324270BA-FC55-41DE-95F2-943FC628C5EE"),
                    CreatedBy = "system",
                    Creation = DateTime.Now,
                    LastModifiedBy = "system",
                    LastModified = DateTime.Now,
                    Name = "SysAdmin",
                    Description = "Administrators of the app"
                },
                new Role()
                {
                    Guid = new Guid("B6BAB4DB-BD5D-4B34-A6E5-085204C16C79"),
                    CreatedBy = "system",
                    Creation = DateTime.Now,
                    LastModifiedBy = "system",
                    LastModified = DateTime.Now,
                    Name = "Sale",
                    Description = "Employee from the sales department"
                },
                new Role()
                {
                    Guid = new Guid("ED32B358-5EB5-41AD-8895-E65641F8D1BD"),
                    CreatedBy = "system",
                    Creation = DateTime.Now,
                    LastModifiedBy = "system",
                    LastModified = DateTime.Now,
                    Name = "Management",
                    Description = "Employee from the management"
                },
                new Role()
                {
                    Guid = new Guid("E0C8423A-581F-4BE9-8493-1B20AEE0673A"),
                    CreatedBy = "system",
                    Creation = DateTime.Now,
                    LastModifiedBy = "system",
                    LastModified = DateTime.Now,
                    Name = "HR",
                    Description = "Employee from the hr department"
                },
                new Role()
                {
                    Guid = new Guid("65231084-3178-4259-886C-4698A02C701D"),
                    CreatedBy = "system",
                    Creation = DateTime.Now,
                    LastModifiedBy = "system",
                    LastModified = DateTime.Now,
                    Name = "Production",
                    Description = "Employee from the production department"
                }
            };

            builder.HasData(seedRoles);
        }
    }
}
