using CLERP.Database.Entities;
using CLERP.Database.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.Database.Configurations
{
    public class AddressConfiguration : EntityTypeConfiguration<Address>
    {
        public override void Configure(EntityTypeBuilder<Address> builder)
        {
            base.Configure(builder);

            builder.ToTable("Addresses");
            builder.Property(x => x.Street).IsRequired();

            builder.HasIndex(x => x.BusinessPartnerGuid);
            builder.HasIndex(x => x.CityGuid);

            // BusinessPartner n-m Address
            builder.HasOne(x => x.BusinessPartner)
                .WithMany(y => y.Addresses)
                .HasForeignKey(x => x.BusinessPartnerGuid);

            // City n-m Address
            builder.HasOne(x => x.City)
                .WithMany(y => y.Addresses)
                .HasForeignKey(x => x.CityGuid);
        }
    }
}
