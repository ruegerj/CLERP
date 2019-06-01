using CLERP.API.Domain.Models;
using CLERP.API.Infrastructure.Configurations.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

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

            // seed data
            builder.HasData(new Employee()
            {
                Guid = Guid.NewGuid(),
                Birthday = new DateTime(2001, 5, 27),
                Creation = DateTime.Now,
                CreatedBy = "system",
                Email = "admin@clerp.ch",
                Firstname = "System",
                Lastname = "Administrator",
                PhoneNumber = "+41 79 122 90 72",
                LastModified = DateTime.Now,
                LastModifiedBy = "system",
                Username = "admin",
                Password = "AI1ZmgGoYudgP1w9VOvAIAnobk5IXBU3wC/Pfv/Xyg0Mr9PEgJPW5UBP9ScXzpEiVg=="
            });
        }
    }
}
