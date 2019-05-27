using CLERP.API.Domain.Models;
using CLERP.API.Infrastructure.Configurations.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CLERP.API.Infrastructure.Configurations
{
    public class ProductTypeConfigruation : EntityTypeConfiguration<ProductType>
    {
        public override void Configure(EntityTypeBuilder<ProductType> builder)
        {
            base.Configure(builder);

            builder.ToTable("Product-Types");
            builder.Property(x => x.EAN).IsRequired();
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Price)
                .HasColumnType("decimal(18,2)") // specify precision and scale of decimal for Db
                .IsRequired();
        }
    }
}
