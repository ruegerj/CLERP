﻿using CLERP.API.Domain.Models;
using CLERP.API.Infrastructure.Configurations.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CLERP.API.Infrastructure.Configurations
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
