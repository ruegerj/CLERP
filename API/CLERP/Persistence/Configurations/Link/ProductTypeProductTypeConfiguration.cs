using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CLERP.Domain.Models.Link;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.Persistence.Configurations.Link
{
    public class ProductTypeProductTypeConfiguration : IEntityTypeConfiguration<ProductTypeProductType>
    {
        public void Configure(EntityTypeBuilder<ProductTypeProductType> builder)
        {
            builder.ToTable("Product-Types_Product-Types");

            // Parent Product-Type m-m Child Product-Type
            builder.HasKey(x => new { x.ParentGuid, x.ChildGuid }).ForSqlServerIsClustered();
            builder.HasOne(x => x.Parent)
                .WithMany(y => y.Children)
                .HasForeignKey(x => x.ParentGuid)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Child)
                .WithMany(y => y.Parents)
                .HasForeignKey(x => x.ChildGuid)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
