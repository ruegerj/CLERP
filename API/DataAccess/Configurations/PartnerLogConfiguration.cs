using CLERP.Business.Models;
using CLERP.DataAccess.Configurations.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.DataAccess.Configurations
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
