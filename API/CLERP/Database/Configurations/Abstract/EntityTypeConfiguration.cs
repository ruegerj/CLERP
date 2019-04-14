using CLERP.Database.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.Database.Configurations
{
    /// <summary>
    /// Base class for all EntityTypeConfigurations
    /// </summary>
    /// <typeparam name="TEntity">Type of the entity which should be configured</typeparam>
    public abstract class EntityTypeConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : EntityBase
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            ConfigureSharedAttributes(builder);
        }

        /// <summary>
        /// Configure all properties of <see cref="EntityBase"/>
        /// </summary>
        /// <param name="builder"></param>
        private void ConfigureSharedAttributes(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(x => x.Guid);
            builder.Property(x => x.Guid).HasDefaultValueSql("NEWID()");
            builder.Property(x => x.Creation).IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.CreatedBy).IsRequired();
            builder.Property(x => x.LastModified).IsRequired().ValueGeneratedOnUpdate();
            builder.Property(x => x.LastModifiedBy).IsRequired();
        }
    }
}
