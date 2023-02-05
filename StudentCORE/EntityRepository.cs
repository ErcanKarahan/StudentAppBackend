using StudentCORE.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentENTITIES;

namespace StudentCORE
{
    public abstract class EntityRepository<TEntity, TContext> : IEntityRepository<TEntity> where TEntity : BaseEntity, new() where TContext : DbContext, new()
    {


        public bool Any(Expression<Func<TEntity, bool>> exp)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().Any(exp);
            }
        }

        public async Task CreateAsync(TEntity item)
        {
            using (TContext context = new TContext())
            {
                await context.Set<TEntity>().AddAsync(item);

                   context.SaveChanges();
            }
        }

        public async Task CreateRange(List<TEntity> item)
        {
            using (TContext context = new TContext())
            {
                await context.Set<TEntity>().AddRangeAsync(item);
                context.SaveChanges();
            }
        }

        public void DeleteAsync(TEntity item)
        {
            using (TContext context = new TContext())
            {
                context.Set<TEntity>().Remove(item);
                context.SaveChanges();
            }
        }

        public void DeleteRange(List<TEntity> item)
        {
            using (TContext context = new TContext())
            {
                foreach (TEntity element in item)
                {
                    DeleteAsync(element);
                }
                context.SaveChangesAsync();
            }
        }

        public TEntity Find(Guid id)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().Find(id);
            }
        }

        public TEntity FirstOrDefault(Expression<Func<TEntity, bool>> exp)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().FirstOrDefault(exp);
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().FirstOrDefault(filter);
            }
        }

        public List<TEntity> GetAllAsync()
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().ToList();
            }
        }


        public void Remove(Guid id)
        {
            using (TContext context = new TContext())
            {
                var deleted = context.Remove(id);
                deleted.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void UpdateAsync(TEntity item)
        {
            using (TContext context = new TContext())
            {
                var toBeUpdated = context.Entry(item);
                toBeUpdated.State = EntityState.Modified;
                context.SaveChangesAsync();
            }
        }

        public void UpdateRange(List<TEntity> item)
        {
            using (TContext context = new TContext())
            {
                foreach (var element in item)
                {
                    UpdateAsync(element);
                }
                context.SaveChangesAsync();
            }
        }

        public List<TEntity> Where(Expression<Func<TEntity, bool>> exp)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().Where(exp).ToList();
            }

        }


    }
}
 
