using CLERP.API.Domain.Models;
using CLERP.API.Domain.Models.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

//namespace Microsoft.EntityFrameworkCore
namespace CLERP.API.Infrastructure.Contexts
{
    /// <summary>
    /// Extension-Methods for the DbSets from the derived DbContext
    /// </summary>
    public static class DbSetExtensions
    {
        /// <summary>
        /// Custom call to FindAsync on a DbSet
        /// Work-Arround for this issue in ef core: 
        /// https://github.com/aspnet/EntityFrameworkCore/issues/12012
        /// </summary>
        /// <typeparam name="TEntity">Type of the Entity the FindAsync should be executed on</typeparam>
        /// <param name="entities">DbSet from type IEntity, provided by the DbContext</param>
        /// <param name="entityGuid">Guid of the entity to find</param>
        /// <param name="cancellationToken">Optional Cancellation-Token</param>
        /// <returns>If found the entity with the provided Guid, else null</returns>
        public static async Task<TEntity> FindByGuidAsync<TEntity>(this DbSet<TEntity> entities,
            Guid entityGuid,
            CancellationToken cancellationToken = default) where TEntity : EntityBase
        {
            return await entities.FindAsync(keyValues: new object[] { entityGuid }, cancellationToken: cancellationToken);
        }
    }
}
