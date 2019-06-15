using CLERP.API.Domain.Models;
using CLERP.API.Infrastructure.Configurations.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using CLERP.API.Infrastructure.Configurations.Seed;

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

            // Seed data

            // Storage House 1
            foreach (var data in ShelfSeedData.ShelvesStorageHouse1Data)
            {
                builder.HasData(new Shelf()
                {
                    Guid = data.Key,
                    WarehouseGuid = ShelfSeedData.StorageHouse1Guid,
                    Designation = data.Value,
                    Creation = DateTime.Now,
                    CreatedBy = "system",
                    LastModified = DateTime.Now,
                    LastModifiedBy = "system"
                });
            }

            // Storage House 2
            foreach (var data in ShelfSeedData.ShelvesStorageHouse2Data)
            {
                builder.HasData(new Shelf()
                {
                    Guid = data.Key,
                    WarehouseGuid = ShelfSeedData.StorageHouse2Guid,
                    Designation = data.Value,
                    Creation = DateTime.Now,
                    CreatedBy = "system",
                    LastModified = DateTime.Now,
                    LastModifiedBy = "system"
                });
            }
        }
    }
}
