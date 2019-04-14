using CLERP.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.Database.Configurations
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
