using CLERP.API.Domain.Models;
using CLERP.API.Infrastructure.Configurations.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Infrastructure.Configurations
{
    public class DepartmentConfiguration : EntityTypeConfiguration<Department>
    {
        public override void Configure(EntityTypeBuilder<Department> builder)
        {
            base.Configure(builder);

            builder.ToTable("Departments");
            builder.Property(x => x.Title).IsRequired();

            // Seed data
            var seedDepartments = new List<Department>()
            {
                new Department()
                {
                    Creation = DateTime.Now,
                    CreatedBy = "system",
                    LastModified = DateTime.Now,
                    LastModifiedBy = "system",
                    Guid = Guid.NewGuid(),
                    Title = "Management",
                    Description = "The management of the firm"
                },
                new Department()
                {
                    Creation = DateTime.Now,
                    CreatedBy = "system",
                    LastModified = DateTime.Now,
                    LastModifiedBy = "system",
                    Guid = Guid.NewGuid(),
                    Title = "Finance",
                    Description = "The finance department of the firm"
                },
                new Department()
                {
                    Creation = DateTime.Now,
                    CreatedBy = "system",
                    LastModified = DateTime.Now,
                    LastModifiedBy = "system",
                    Guid = Guid.NewGuid(),
                    Title = "HR",
                    Description = "The hr department of the firm"
                },
                new Department()
                {
                    Creation = DateTime.Now,
                    CreatedBy = "system",
                    LastModified = DateTime.Now,
                    LastModifiedBy = "system",
                    Guid = Guid.NewGuid(),
                    Title = "Sales",
                    Description = "The sales department of the firm"
                },
                new Department()
                {
                    Creation = DateTime.Now,
                    CreatedBy = "system",
                    LastModified = DateTime.Now,
                    LastModifiedBy = "system",
                    Guid = Guid.NewGuid(),
                    Title = "Purchase",
                    Description = "The purchase department of the firm"
                },
                new Department()
                {
                    Creation = DateTime.Now,
                    CreatedBy = "system",
                    LastModified = DateTime.Now,
                    LastModifiedBy = "system",
                    Guid = Guid.NewGuid(),
                    Title = "Logistic",
                    Description = "The logistics department of the firm"
                },
                new Department()
                {
                    Creation = DateTime.Now,
                    CreatedBy = "system",
                    LastModified = DateTime.Now,
                    LastModifiedBy = "system",
                    Guid = Guid.NewGuid(),
                    Title = "Production",
                    Description = "The production department of the firm"
                }
            };

            builder.HasData(seedDepartments);
        }
    }
}
