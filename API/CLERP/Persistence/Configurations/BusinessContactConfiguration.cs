using CLERP.Domain.Models;
using CLERP.Persistence.Configurations.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.Persistence.Configurations
{
    public class BusinessContactConfiguration : EntityTypeConfiguration<BusinessContact>
    {
        public override void Configure(EntityTypeBuilder<BusinessContact> builder)
        {
            base.Configure(builder);

            builder.ToTable("Business-Contacts");
            builder.Property(x => x.Firstname).IsRequired();
            builder.Property(x => x.Lastname).IsRequired();
            builder.Property(x => x.Email).IsRequired();

            builder.HasIndex(x => x.BusinessPartnerGuid);

            // BusinessPartner n-m BusinessContact
            builder.HasOne(x => x.BusinessPartner)
                .WithMany(y => y.Contacts)
                .HasForeignKey(x => x.BusinessPartnerGuid);
        }
    }
}
