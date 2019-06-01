using CLERP.API.Domain.Models;
using CLERP.API.Infrastructure.Configurations.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
        }
    }
}
