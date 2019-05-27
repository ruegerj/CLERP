﻿using CLERP.API.Domain.Models;
using CLERP.API.Infrastructure.Configurations.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CLERP.API.Infrastructure.Configurations
{
    public class CityConfiguration : EntityTypeConfiguration<City>
    {
        public override void Configure(EntityTypeBuilder<City> builder)
        {
            base.Configure(builder);

            builder.ToTable("Cities");
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.PostalCode).IsRequired();

            builder.HasIndex(x => x.CountryGuid);

            // Country n-m City
            builder.HasOne(x => x.Country)
                .WithMany(y => y.Cities)
                .HasForeignKey(x => x.CountryGuid);
        }
    }
}
