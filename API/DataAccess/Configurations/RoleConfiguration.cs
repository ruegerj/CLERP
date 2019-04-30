using CLERP.Business.Models;
using CLERP.Business.Models.Abstract;
using CLERP.DataAccess.Configurations.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.DataAccess.Configurations
{
    public class RoleConfiguration : EntityTypeConfiguration<Role>
    {
        public override void Configure(EntityTypeBuilder<Role> builder)
        {
            base.Configure(builder);

            builder.ToTable("Roles");
            builder.Property(x => x.Type)
                .HasConversion
                (
                    v => v.ToString(),
                    v => (RoleType)Enum.Parse(typeof(RoleType), v)
                ).IsRequired();
        }
    }
}
