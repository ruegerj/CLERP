using CLERP.Business.Models;
using CLERP.Business.Models.Abstract;
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
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder);

            builder.ToTable("Products");
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.SerialNumber).IsRequired();
            builder.Property(x => x.State)
                .HasConversion
                (
                    new ValueConverter<ProductState, string>(v => v.ToString(), v => (ProductState)Enum.Parse(typeof(ProductState), v))
                ).IsRequired();

            builder.HasIndex(x => x.ParentGuid);
            builder.HasIndex(x => x.CompartmentGuid);
            builder.HasIndex(x => x.TypeGuid);
            builder.HasIndex(x => x.BillGuid);

            // Product (Parent) n-m Product (Children)
            builder.HasOne(x => x.Parent)
                .WithMany(y => y.Children)
                .HasForeignKey(x => x.ParentGuid)
                .OnDelete(DeleteBehavior.Restrict);

            // Compartment n-m Product
            builder.HasOne(x => x.Compartment)
                .WithMany(y => y.Products)
                .HasForeignKey(x => x.CompartmentGuid);

            // ProductType n-m Product
            builder.HasOne(x => x.Type)
                .WithMany(y => y.Products)
                .HasForeignKey(x => x.TypeGuid);
        }
    }
}
