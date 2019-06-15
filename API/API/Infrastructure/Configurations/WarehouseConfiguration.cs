using CLERP.API.Domain.Models;
using CLERP.API.Infrastructure.Configurations.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

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

            // Seed data
            builder.HasData(new Warehouse()
            {
                Guid = new Guid("45B9B2E3-3FD7-4000-950A-781241C33656"),
                AddressGuid = new Guid("3C3F2E8A-2EC3-45EA-8273-99E76D71190F"), // Lagerstrasse 5
                Name = "Storage House 1",
                Creation = DateTime.Now,
                CreatedBy = "system",
                LastModified = DateTime.Now,
                LastModifiedBy = "system"
            });

            builder.HasData(new Warehouse()
            {
                Guid = new Guid("F722D8D7-405A-42FB-BDDA-4C69D648C3AB"),
                AddressGuid = new Guid("5DD4E453-19A0-4CEF-ABFD-4CAC78037490"), // Lagerstrasse 7,
                Name = "Storage House 2",
                Creation = DateTime.Now,
                CreatedBy = "system",
                LastModified = DateTime.Now,
                LastModifiedBy = "system"
            });
        }
    }
}
