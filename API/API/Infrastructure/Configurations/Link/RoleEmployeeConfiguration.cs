using CLERP.API.Domain.Models.Link;
using CLERP.API.Infrastructure.Configurations.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CLERP.API.Infrastructure.Configurations.Link
{
    public class RoleEmployeeConfiguration : LinkEntityTypeConfiguration<RoleEmployee>
    {
        public override void Configure(EntityTypeBuilder<RoleEmployee> builder)
        {
            base.Configure(builder);

            builder.ToTable("Roley_Employees");

            // Role m-m Employee
            builder.HasKey(x => new { x.RoleGuid, x.EmployeeGuid }).ForSqlServerIsClustered();
            builder.HasOne(x => x.Role)
                .WithMany(y => y.Employees)
                .HasForeignKey(x => x.RoleGuid);
            builder.HasOne(x => x.Employee)
                .WithMany(y => y.Roles)
                .HasForeignKey(x => x.EmployeeGuid);
        }
    }
}
