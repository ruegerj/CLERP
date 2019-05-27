using CLERP.API.Domain.Models;
using CLERP.API.Infrastructure.Configurations.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CLERP.API.Infrastructure.Configurations
{
    public class PartnerLogConfiguration : EntityTypeConfiguration<PartnerLog>
    {
        public override void Configure(EntityTypeBuilder<PartnerLog> builder)
        {
            base.Configure(builder);

            builder.ToTable("Business-Partner-Logs");
            builder.Property(x => x.LogMessage).IsRequired();

            builder.HasIndex(x => x.PartnerGuid);

            // BusinessPartner n-m PartnerLog
            builder.HasOne(x => x.Partner)
                .WithMany(y => y.Logs)
                .HasForeignKey(x => x.PartnerGuid);
        }
    }
}
