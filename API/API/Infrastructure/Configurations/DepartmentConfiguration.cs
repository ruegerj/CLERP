using CLERP.API.Domain.Models;
using CLERP.API.Infrastructure.Configurations.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

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
                    Guid = new Guid("C0A1D8DC-9D37-4B68-AD4E-420E14FD29AF"),
                    Title = "Management",
                    Description = "The management of the firm"
                },
                new Department()
                {
                    Creation = DateTime.Now,
                    CreatedBy = "system",
                    LastModified = DateTime.Now,
                    LastModifiedBy = "system",
                    Guid = new Guid("4B7F2FB2-2726-49B3-B8AB-6F7B42120DEE"),
                    Title = "Finance",
                    Description = "The finance department of the firm"
                },
                new Department()
                {
                    Creation = DateTime.Now,
                    CreatedBy = "system",
                    LastModified = DateTime.Now,
                    LastModifiedBy = "system",
                    Guid = new Guid("98EB6FFE-57BB-4D49-AD13-23195A1325EE"),
                    Title = "HR",
                    Description = "The hr department of the firm"
                },
                new Department()
                {
                    Creation = DateTime.Now,
                    CreatedBy = "system",
                    LastModified = DateTime.Now,
                    LastModifiedBy = "system",
                    Guid = new Guid("426A9547-086D-4847-A80E-00140DA99723"),
                    Title = "Sales",
                    Description = "The sales department of the firm"
                },
                new Department()
                {
                    Creation = DateTime.Now,
                    CreatedBy = "system",
                    LastModified = DateTime.Now,
                    LastModifiedBy = "system",
                    Guid = new Guid("273A60CE-7282-4141-9676-1C3040EC1303"),
                    Title = "Purchase",
                    Description = "The purchase department of the firm"
                },
                new Department()
                {
                    Creation = DateTime.Now,
                    CreatedBy = "system",
                    LastModified = DateTime.Now,
                    LastModifiedBy = "system",
                    Guid = new Guid("7E645FD7-25DF-4BAA-898D-59963C4F4D43"),
                    Title = "Logistic",
                    Description = "The logistics department of the firm"
                },
                new Department()
                {
                    Creation = DateTime.Now,
                    CreatedBy = "system",
                    LastModified = DateTime.Now,
                    LastModifiedBy = "system",
                    Guid = new Guid("2D08DE41-25F6-4369-BACB-DE75F90CF2EA"),
                    Title = "Production",
                    Description = "The production department of the firm"
                }
            };

            builder.HasData(seedDepartments);
        }
    }
}
