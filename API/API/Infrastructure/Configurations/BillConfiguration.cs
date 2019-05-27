using CLERP.API.Domain.Models;
using CLERP.API.Domain.Models.Abstract;
using CLERP.API.Infrastructure.Configurations.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;

namespace CLERP.API.Infrastructure.Configurations
{
    public class BillConfiguration : EntityTypeConfiguration<Bill>
    {
        public override void Configure(EntityTypeBuilder<Bill> builder)
        {
            base.Configure(builder);

            builder.ToTable("Bills");
            builder.Property(x => x.State).HasConversion
                (
                    new ValueConverter<BillState, string>(v => v.ToString(), v => (BillState)Enum.Parse(typeof(BillState), v))
                ).IsRequired();
            builder.Property(x => x.TotalPrice)
                .HasColumnType("decimal(18,2)") // specify precision and scale of decimal for Db
                .IsRequired();
            builder.Property(x => x.ValidFrom).IsRequired();
            builder.Property(x => x.AdditionalDeadlineDays).IsRequired();

            builder.HasIndex(x => x.OrderGuid).IsUnique();

            // Order 1:n Bill
            builder.HasOne(x => x.Order)
                .WithMany(y => y.Bills)
                .HasForeignKey(x => x.OrderGuid);

            // Product n:m Bill
            builder.HasMany(x => x.ProductsToPay)
                .WithOne(y => y.Bill)
                .HasForeignKey(y => y.BillGuid);
        }
    }
}
