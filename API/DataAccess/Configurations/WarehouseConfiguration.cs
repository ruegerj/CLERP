using CLERP.Business.Models;
using CLERP.DataAccess.Configurations.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.DataAccess.Configurations
{
    public class WarehouseConfiguration : EntityTypeConfiguration<Warehouse>
    {
        public override void Configure(EntityTypeBuilder<Warehouse> builder)
        {
            base.Configure(builder);

            builder.ToTable("Warehouses");
            builder.Property(x => x.Name).IsRequired();

            builder.HasIndex(x => x.AddressGuid);

            // Address 1-1 Warehouse 
            builder.HasOne(x => x.Address)
                .WithOne(y => y.Warehouse)
                .HasForeignKey<Warehouse>(x => x.AddressGuid);
        }
    }
}
