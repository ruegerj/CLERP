using CLERP.API.Domain.Models;
using CLERP.API.Infrastructure.Configurations.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

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

            // Seed data
            builder.HasData(new City()
            {
                Guid = new Guid("7AC5C068-2194-40D2-8D78-95F6B8C62F4B"),
                CountryGuid = new Guid("0906D22F-39C2-4619-8C5B-1BA73DB80F64"), // Switzerland
                Name = "Zürich",
                PostalCode = 8000,
                Creation = DateTime.Now,
                CreatedBy = "system",
                LastModified = DateTime.Now,
                LastModifiedBy = "sytem"
            });
        }
    }
}
