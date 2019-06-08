using CLERP.API.Domain.Models.Link;
using CLERP.API.Infrastructure.Configurations.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace CLERP.API.Infrastructure.Configurations.Link
{
    public class RoleDepartmentConfiguration : LinkEntityTypeConfiguration<RoleDepartment>
    {
        public override void Configure(EntityTypeBuilder<RoleDepartment> builder)
        {
            base.Configure(builder);

            builder.ToTable("Roles_Departments");

            // Role m-m Department
            builder.HasKey(x => new { x.RoleGuid, x.DepartmentGuid }).ForSqlServerIsClustered();
            builder.HasOne(x => x.Role)
                .WithMany(y => y.Departments)
                .HasForeignKey(x => x.RoleGuid);
            builder.HasOne(x => x.Department)
                .WithMany(y => y.Roles)
                .HasForeignKey(x => x.DepartmentGuid);

            var linksDepartmentsRoles = new List<RoleDepartment>()
            {
                new RoleDepartment()
                {
                    DepartmentGuid = new Guid("C0A1D8DC-9D37-4B68-AD4E-420E14FD29AF"), // Management department
                    RoleGuid = new Guid("ED32B358-5EB5-41AD-8895-E65641F8D1BD"), // Management role
                    Creation = DateTime.Now,
                    CreatedBy = "system",
                    LastModified = DateTime.Now,
                    LastModifiedBy = "system"
                },
                new RoleDepartment()
                {
                    DepartmentGuid = new Guid("4B7F2FB2-2726-49B3-B8AB-6F7B42120DEE"), // Finance department
                    RoleGuid = new Guid("D34CE4A4-6FAE-4623-9CF9-7468A19781FB"), // Finance role
                    Creation = DateTime.Now,
                    CreatedBy = "system",
                    LastModified = DateTime.Now,
                    LastModifiedBy = "system"
                },
                new RoleDepartment()
                {
                    DepartmentGuid = new Guid("98EB6FFE-57BB-4D49-AD13-23195A1325EE"), // HR department
                    RoleGuid = new Guid("E0C8423A-581F-4BE9-8493-1B20AEE0673A"), // HR role
                    Creation = DateTime.Now,
                    CreatedBy = "system",
                    LastModified = DateTime.Now,
                    LastModifiedBy = "system"
                },
                new RoleDepartment()
                {
                    DepartmentGuid = new Guid("426A9547-086D-4847-A80E-00140DA99723"), // Sales department
                    RoleGuid = new Guid("B6BAB4DB-BD5D-4B34-A6E5-085204C16C79"), // Sales role
                    Creation = DateTime.Now,
                    CreatedBy = "system",
                    LastModified = DateTime.Now,
                    LastModifiedBy = "system"
                },
                new RoleDepartment()
                {
                    DepartmentGuid = new Guid("273A60CE-7282-4141-9676-1C3040EC1303"), // Purchase department
                    RoleGuid = new Guid("58457E73-DA9F-4F6E-B31B-7F89807E320C"), // Purchase role
                    Creation = DateTime.Now,
                    CreatedBy = "system",
                    LastModified = DateTime.Now,
                    LastModifiedBy = "system"
                },
                new RoleDepartment()
                {
                    DepartmentGuid = new Guid("7E645FD7-25DF-4BAA-898D-59963C4F4D43"), // Logistics department
                    RoleGuid = new Guid("90F17BBE-EDB8-4E0F-8492-B18D130EF058"), // Logistics role
                    Creation = DateTime.Now,
                    CreatedBy = "system",
                    LastModified = DateTime.Now,
                    LastModifiedBy = "system"
                },
                new RoleDepartment()
                {
                    DepartmentGuid = new Guid("2D08DE41-25F6-4369-BACB-DE75F90CF2EA"), // Production department
                    RoleGuid = new Guid("65231084-3178-4259-886C-4698A02C701D"), // Production role
                    Creation = DateTime.Now,
                    CreatedBy = "system",
                    LastModified = DateTime.Now,
                    LastModifiedBy = "system"
                },
            };

            linksDepartmentsRoles.ForEach(ldr => builder.HasData(ldr));
        }
    }
}
