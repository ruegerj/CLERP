using CLERP.API.Domain.Models;
using CLERP.API.Infrastructure.Configurations.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CLERP.API.Infrastructure.Configurations
{
    public class WarehouseConfiguration : EntityTypeConfiguration<Warehouse>
    {
        public override void Configure(EntityTypeBuilder<Warehouse> builder)
        {
            base.Configure(builder);

            builder.ToTable("Warehouses");
            builder.Property(x => x.Name).IsRequired();

            builder.HasIndex(x => x.AddressGuid);

            // Address 1-n Warehouse 
            builder.HasOne(x => x.Address)
                .WithMany(y => y.Warehouses)
                .HasForeignKey(y => y.AddressGuid);
        }
    }
}
