using CLERP.API.Domain.Models.Link;
using CLERP.API.Infrastructure.Configurations.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        }
    }
}
