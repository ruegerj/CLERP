using CLERP.API.Domain.Models;
using CLERP.API.Infrastructure.Configurations.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CLERP.API.Infrastructure.Configurations
{
    public class ShelfConfiguration : EntityTypeConfiguration<Shelf>
    {
        public override void Configure(EntityTypeBuilder<Shelf> builder)
        {
            base.Configure(builder);

            builder.ToTable("Shelves");
            builder.Property(x => x.Designation).IsRequired();

            builder.HasIndex(x => x.WarehouseGuid);

            builder.HasOne(x => x.Warehouse)
                .WithMany(y => y.Shelves)
                .HasForeignKey(x => x.WarehouseGuid);
        }
    }
}
