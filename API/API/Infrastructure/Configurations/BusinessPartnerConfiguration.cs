using CLERP.API.Domain.Models;
using CLERP.API.Infrastructure.Configurations.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CLERP.API.Infrastructure.Configurations
{
    public class BusinessPartnerConfiguration : EntityTypeConfiguration<BusinessPartner>
    {
        public override void Configure(EntityTypeBuilder<BusinessPartner> builder)
        {
            base.Configure(builder);

            builder.ToTable("Business-Partners");
            builder.Property(x => x.Name).IsRequired();
        }
    }
}
