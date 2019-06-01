﻿using CLERP.API.Domain.Models;
using CLERP.API.Infrastructure.Configurations.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CLERP.API.Infrastructure.Configurations
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
