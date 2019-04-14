using CLERP.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.Database.Configurations
{
    public class CompartmentConfiguration : EntityTypeConfiguration<Compartment>
    {
        public override void Configure(EntityTypeBuilder<Compartment> builder)
        {
            base.Configure(builder);

            builder.ToTable("Compartments");
            builder.Property(x => x.Row).IsRequired();
            builder.Property(x => x.Column).IsRequired();
        }
    }
}
