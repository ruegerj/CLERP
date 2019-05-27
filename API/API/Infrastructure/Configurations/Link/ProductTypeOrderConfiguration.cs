using CLERP.API.Domain.Models.Link;
using CLERP.API.Infrastructure.Configurations.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CLERP.API.Infrastructure.Configurations.Link
{
    public class ProductTypeOrderConfiguration : LinkEntityTypeConfiguration<ProductTypeOrder>
    {
        public override void Configure(EntityTypeBuilder<ProductTypeOrder> builder)
        {
            base.Configure(builder);

            builder.ToTable("Product-Types_Orders");

            // ProductType m:m Order
            builder.HasKey(x => new { x.ProductTypeGuid, x.OrderGuid }).ForSqlServerIsClustered();
            builder.HasOne(x => x.ProductType)
                .WithMany(y => y.Orders)
                .HasForeignKey(x => x.ProductTypeGuid)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Order)
                .WithMany(y => y.ProductTypes)
                .HasForeignKey(x => x.OrderGuid)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
