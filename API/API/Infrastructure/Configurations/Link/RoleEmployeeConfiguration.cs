using CLERP.API.Domain.Models.Link;
using CLERP.API.Infrastructure.Configurations.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace CLERP.API.Infrastructure.Configurations.Link
{
    public class RoleEmployeeConfiguration : LinkEntityTypeConfiguration<RoleEmployee>
    {
        public override void Configure(EntityTypeBuilder<RoleEmployee> builder)
        {
            base.Configure(builder);

            builder.ToTable("Roles_Employees");

            // Role m-m Employee
            builder.HasKey(x => new { x.RoleGuid, x.EmployeeGuid }).ForSqlServerIsClustered();
            builder.HasOne(x => x.Role)
                .WithMany(y => y.Employees)
                .HasForeignKey(x => x.RoleGuid);
            builder.HasOne(x => x.Employee)
                .WithMany(y => y.Roles)
                .HasForeignKey(x => x.EmployeeGuid);

            var seedsRolesEmployees = new List<RoleEmployee>()
            {
                new RoleEmployee()
                {
                    EmployeeGuid = new Guid("0DFAC9A3-F4B2-47F6-8F91-4E0198E8D6BF"), // admin seed employee
                    RoleGuid = new Guid("324270BA-FC55-41DE-95F2-943FC628C5EE"), // SysAdmin role
                    Creation = DateTime.Now,
                    CreatedBy = "system",
                    LastModified = DateTime.Now,
                    LastModifiedBy = "system"
                }
            };

            seedsRolesEmployees.ForEach(sre => builder.HasData(sre));
        }
    }
}
