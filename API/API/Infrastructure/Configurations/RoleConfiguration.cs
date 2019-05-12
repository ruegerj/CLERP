using CLERP.API.Domain.Models;
using CLERP.API.Domain.Models.Abstract;
using CLERP.API.Infrastructure.Configurations.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
                    Guid = Guid.NewGuid(),
                    CreatedBy = "system",
                    Creation = DateTime.Now,
                    LastModifiedBy = "system",
                    LastModified = DateTime.Now,
                    Name = "Logistic",
                    Description = "Employee from the logistics department"
                },
                new Role()
                {
                    Guid = Guid.NewGuid(),
                    CreatedBy = "system",
                    Creation = DateTime.Now,
                    LastModifiedBy = "system",
                    LastModified = DateTime.Now,
                    Name = "Finance",
                    Description = "Employee from the finances department"
                },
                new Role()
                {
                    Guid = Guid.NewGuid(),
                    CreatedBy = "system",
                    Creation = DateTime.Now,
                    LastModifiedBy = "system",
                    LastModified = DateTime.Now,
                    Name = "Purchase",
                    Description = "Employee from the purchases department"
                },
                new Role()
                {
                    Guid = Guid.NewGuid(),
                    CreatedBy = "system",
                    Creation = DateTime.Now,
                    LastModifiedBy = "system",
                    LastModified = DateTime.Now,
                    Name = "SysAdmin",
                    Description = "Administrators of the app"
                },
                new Role()
                {
                    Guid = Guid.NewGuid(),
                    CreatedBy = "system",
                    Creation = DateTime.Now,
                    LastModifiedBy = "system",
                    LastModified = DateTime.Now,
                    Name = "Sale",
                    Description = "Employee from the sales department"
                },
                new Role()
                {
                    Guid = Guid.NewGuid(),
                    CreatedBy = "system",
                    Creation = DateTime.Now,
                    LastModifiedBy = "system",
                    LastModified = DateTime.Now,
                    Name = "Management",
                    Description = "Employee from the management"
                },
                new Role()
                {
                    Guid = Guid.NewGuid(),
                    CreatedBy = "system",
                    Creation = DateTime.Now,
                    LastModifiedBy = "system",
                    LastModified = DateTime.Now,
                    Name = "HR",
                    Description = "Employee from the hr department"
                },
                new Role()
                {
                    Guid = Guid.NewGuid(),
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
