using CLERP.API.Domain.Models;
using CLERP.API.Infrastructure.Configurations.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;

namespace CLERP.API.Infrastructure.Configurations
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

            // Seed data
            builder.HasData(new Country()
            {
                Guid = new Guid("0906D22F-39C2-4619-8C5B-1BA73DB80F64"),
                Abbreviation = "CH",
                Name = "Switzerland",
                Creation = DateTime.Now,
                CreatedBy = "system",
                LastModified = DateTime.Now,
                LastModifiedBy = "system"
            });
        }
    }
}
