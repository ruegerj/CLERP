using CLERP.Database.Entities;
using CLERP.Database.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.Database.Configurations
{
    public class OrderConfiguration : EntityTypeConfiguration<Order>
    {
        public override void Configure(EntityTypeBuilder<Order> builder)
        {
            base.Configure(builder);

            builder.ToTable("Orders");
            builder.Property(x => x.EstimatedPrice)
                .HasColumnType("decimal(18,2)") // specify precision and scale of decimal for Db
                .IsRequired();
            builder.Property(x => x.SendDate).IsRequired();
            builder.Property(x => x.State)
                .HasConversion
                (
                   new ValueConverter<OrderState, string>(v => v.ToString(), v => (OrderState)Enum.Parse(typeof(OrderState), v)) 
                ).IsRequired();

            builder.HasIndex(x => x.BillingAddressGuid);
            builder.HasIndex(x => x.ShippingAddressGuid);
            builder.HasIndex(x => x.SendingPartnerGuid);
            builder.HasIndex(x => x.ReceivingPartnerGuid);

            // Address n-m Order (Shipping-Address)
            builder.HasOne(x => x.ShippingAddress)
                .WithMany(y => y.ShippingOrders)
                .HasForeignKey(x => x.ShippingAddressGuid)
                .OnDelete(DeleteBehavior.Restrict);

            // Address n-m Order (Billing-Address)
            builder.HasOne(x => x.BillingAddress)
                .WithMany(y => y.BillingOrders)
                .HasForeignKey(x => x.BillingAddressGuid)
                .OnDelete(DeleteBehavior.Restrict);

            // Business-Partner n-m Order (Receiving)
            builder.HasOne(x => x.ReceivingPartner)
                .WithMany(y => y.ReceivedOrders)
                .HasForeignKey(x => x.ReceivingPartnerGuid)
                .OnDelete(DeleteBehavior.Restrict);

            // Business-Partner n-m Order (Sending)
            builder.HasOne(x => x.SendingPartner)
                .WithMany(y => y.SendtOrders)
                .HasForeignKey(x => x.SendingPartnerGuid)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
