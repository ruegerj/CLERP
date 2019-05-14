using CLERP.API.Domain.Models.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Infrastructure.Configurations.Abstract
{
    /// <summary>
    /// Base class for all EntityTypeConfigurations for an entity which is derived from <see cref="LinkEntityBase"/>
    /// </summary>
    /// <typeparam name="TLinkEntity">Type of the entity which should be configured</typeparam>
    public abstract class LinkEntityTypeConfiguration<TLinkEntity> : IEntityTypeConfiguration<TLinkEntity> where TLinkEntity : LinkEntityBase
    {
        public virtual void Configure(EntityTypeBuilder<TLinkEntity> builder)
        {
            ConfigureSharedAttributes(builder);
        }

        /// <summary>
        /// Configure all properties of <see cref="LinkEntityBase"/>
        /// </summary>
        /// <param name="builder"></param>
        private void ConfigureSharedAttributes(EntityTypeBuilder<TLinkEntity> builder)
        {
            builder.Property(x => x.Creation).ValueGeneratedOnAdd();
            builder.Property(x => x.CreatedBy).IsRequired();
            builder.Property(x => x.LastModified).ValueGeneratedOnUpdate();
            builder.Property(x => x.LastModifiedBy).IsRequired();
        }
    }
}
