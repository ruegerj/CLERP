using CLERP.Business.Models;
using CLERP.DataAccess.Configurations.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.DataAccess.Configurations
{
    public class CountryConfiguration : EntityTypeConfiguration<Country>
    {
        public override void Configure(EntityTypeBuilder<Country> builder)
        {
            base.Configure(builder);

            builder.ToTable("Countries");
            // Set length of abbrevation to 3
            builder.Property(x => x.Abbreviation)
                .HasConversion // Ensure abbrevations are in capital letters
                (
                    new ValueConverter<string, string>(v => v.ToUpperInvariant(), v => v)
                )
                .HasMaxLength(3)
                .IsFixedLength()
                .IsRequired();
            builder.Property(x => x.Name).IsRequired();
        }
    }
}
