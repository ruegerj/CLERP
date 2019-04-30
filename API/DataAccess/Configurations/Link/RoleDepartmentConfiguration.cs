using CLERP.Business.Models.Link;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.DataAccess.Configurations.Link
{
    public class RoleDepartmentConfiguration : IEntityTypeConfiguration<RoleDepartment>
    {
        public void Configure(EntityTypeBuilder<RoleDepartment> builder)
        {
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
