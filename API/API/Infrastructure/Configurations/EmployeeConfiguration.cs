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
    public class EmployeeConfiguration : EntityTypeConfiguration<Employee>
    {
        public override void Configure(EntityTypeBuilder<Employee> builder)
        {
            base.Configure(builder);

            builder.ToTable("Employees");
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.Password).IsRequired();
            builder.Property(x => x.Firstname).IsRequired();
            builder.Property(x => x.Lastname).IsRequired();

            builder.HasIndex(x => x.DepartmentGuid);

            // Department 1:m Employee
            builder.HasOne(x => x.Department)
                .WithMany(y => y.Employees)
                .HasForeignKey(x => x.DepartmentGuid);
        }
    }
}
