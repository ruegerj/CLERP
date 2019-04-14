using CLERP.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.Database.Configurations
{
    public class ContactLogConfiguration : EntityTypeConfiguration<ContactLog>
    {
        public override void Configure(EntityTypeBuilder<ContactLog> builder)
        {
            base.Configure(builder);

            builder.ToTable("Business-Contact-Logs");
            builder.Property(x => x.LogMessage).IsRequired();

            builder.HasIndex(x => x.ContactGuid);

            // BusinessContact 1:m ContactLog
            builder.HasOne(x => x.Contact)
                .WithMany(y => y.Logs)
                .HasForeignKey(x => x.ContactGuid);
        }
    }
}
