using CLERP.API.Domain.Models;
using CLERP.API.Infrastructure.Configurations.Abstract;
using CLERP.API.Infrastructure.Configurations.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace CLERP.API.Infrastructure.Configurations
{
    public class CompartmentConfiguration : EntityTypeConfiguration<Compartment>
    {
        public override void Configure(EntityTypeBuilder<Compartment> builder)
        {
            base.Configure(builder);

            builder.ToTable("Compartments");
            builder.Property(x => x.Row).IsRequired();
            builder.Property(x => x.Column).IsRequired();

            builder.HasOne(x => x.Shelf)
                .WithMany(y => y.Compartments)
                .HasForeignKey(x => x.ShelfGuid);

            // Seed data

            // Storage House 1
            foreach (var data in ShelfSeedData.ShelvesStorageHouse1Data)
            {
                for (int rowCounter = 0; rowCounter < CompartmentSeedData.StorageHouseRowAmount; rowCounter++)
                {
                    for (int columnCounter = 0; columnCounter < CompartmentSeedData.StorageHouseColumnAmount; columnCounter++)
                    {
                        builder.HasData(new Compartment()
                        {
                            Guid = CompartmentSeedData.ShelfCompartmentsStorageHouse1Guids[data.Value][rowCounter, columnCounter],
                            Column = columnCounter + 1,
                            Row = rowCounter + 1,
                            ShelfGuid = data.Key,
                            Creation = DateTime.Now,
                            CreatedBy = "system",
                            LastModified = DateTime.Now,
                            LastModifiedBy = "system"
                        });
                    }
                }
            }

            // Storage House 2
            foreach (var data in ShelfSeedData.ShelvesStorageHouse2Data)
            {
                for (int rowCounter = 0; rowCounter < CompartmentSeedData.StorageHouseRowAmount; rowCounter++)
                {
                    for (int columnCounter = 0; columnCounter < CompartmentSeedData.StorageHouseColumnAmount; columnCounter++)
                    {
                        builder.HasData(new Compartment()
                        {
                            Guid = CompartmentSeedData.ShelfCompartmentsStorageHouse2Guids[data.Value][rowCounter, columnCounter],
                            Column = columnCounter + 1,
                            Row = rowCounter + 1,
                            ShelfGuid = data.Key,
                            Creation = DateTime.Now,
                            CreatedBy = "system",
                            LastModified = DateTime.Now,
                            LastModifiedBy = "system"
                        });
                    }
                }
            }
        }
    }
}
