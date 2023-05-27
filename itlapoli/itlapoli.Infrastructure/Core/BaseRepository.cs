using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using itlapoli.Domian.Repository;
using itlapoli.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.EntityFrameworkCore.Internal;

namespace itlapoli.Infrastructure.Core
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class

    {
        private readonly SchoolContext school;
        private readonly DbSet<TEntity> entities;

        public BaseRepository(SchoolContext school)
        {
            this.school = school;
            this.entities = this.school.Set<TEntity>();
        }
        public virtual bool Exists(Expression<Func<TEntity, bool>> filter)
        {

            //if (this.entities.Where(filter).Count() > 0 )
            //{
            //    return true;
            //}
            //return false;

            //return this.entities.Count(filter) > 0;
            return this.entities.Any(filter);
        }

        public IEnumerable<TEntity> GetEntities()
        {
            throw new NotImplementedException();
        }

        public TEntity GetEntity(int entityid)
        {
            throw new NotImplementedException();
        }

        public void Remove(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Save(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Save(TEntity[] entities)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
