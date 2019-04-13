using CLERP.Database.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.Database.Utilities
{
    /// <summary>
    /// Utility class for entity configurations
    /// </summary>
    public static class EntityConfigurationHelper
    {
        public static EntityTypeBuilder<T> ConfigureSharedAttributes<T>(EntityTypeBuilder<T> builder) where T : EntityBase
        {
            builder.HasKey(x => x.Guid);
            builder.Property(x => x.Guid).HasDefaultValueSql("NEWID()");
            builder.Property(x => x.Creation).IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.CreatedBy).IsRequired();
            builder.Property(x => x.LastModified).IsRequired().ValueGeneratedOnUpdate();
            builder.Property(x => x.LastModifiedBy).IsRequired();

            return builder;
        }
    }
}
