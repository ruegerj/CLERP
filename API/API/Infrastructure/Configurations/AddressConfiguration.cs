using CLERP.API.Domain.Models;
using CLERP.API.Infrastructure.Configurations.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace CLERP.API.Infrastructure.Configurations
{
    public class AddressConfiguration : EntityTypeConfiguration<Address>
    {
        public override void Configure(EntityTypeBuilder<Address> builder)
        {
            base.Configure(builder);

            builder.ToTable("Addresses");
            builder.Property(x => x.Street).IsRequired();

            //builder.HasIndex(x => x.BusinessPartnerGuid);
            builder.HasIndex(x => x.CityGuid);

            // BusinessPartner n-m Address
            builder.HasOne(x => x.BusinessPartner)
                .WithMany(y => y.Addresses)
                .HasForeignKey(x => x.BusinessPartnerGuid);

            // City n-m Address
            builder.HasOne(x => x.City)
                .WithMany(y => y.Addresses)
                .HasForeignKey(x => x.CityGuid);

            // Seed data
            builder.HasData(new Address()
            {
                Guid = new Guid("3C3F2E8A-2EC3-45EA-8273-99E76D71190F"),
                CityGuid = new Guid("7AC5C068-2194-40D2-8D78-95F6B8C62F4B"), // 8001 Zürich
                Street = "Lagerstrasse",
                Housenumber = 5,
                Creation = DateTime.Now,
                CreatedBy = "system",
                LastModified = DateTime.Now,
                LastModifiedBy = "system"
            });

            builder.HasData(new Address()
            {
                Guid = new Guid("5DD4E453-19A0-4CEF-ABFD-4CAC78037490"),
                CityGuid = new Guid("7AC5C068-2194-40D2-8D78-95F6B8C62F4B"), // 8001 Zürich
                Street = "Lagerstrasse",
                Housenumber = 7,
                Creation = DateTime.Now,
                CreatedBy = "system",
                LastModified = DateTime.Now,
                LastModifiedBy = "system"
            });
        }
    }
}
