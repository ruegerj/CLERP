using CLERP.Business.Models;
using CLERP.DataAccess.Configurations.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.DataAccess.Configurations
{
    public class DepartmentConfiguration : EntityTypeConfiguration<Department>
    {
        public override void Configure(EntityTypeBuilder<Department> builder)
        {
            base.Configure(builder);

            builder.ToTable("Departments");
            builder.Property(x => x.Title).IsRequired();
        }
    }
}
