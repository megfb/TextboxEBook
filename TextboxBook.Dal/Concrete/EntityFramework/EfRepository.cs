using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using TextboxBook.Dal.Abstract;
using TextboxBook.Entity.Abstract;

namespace TextboxBook.Dal.Concrete.EntityFramework
{
    public class EfRepository<TEntity, TContext> : IRepositoryBase<TEntity> where TEntity : class, IEntity, new()

        where TContext: EfContext,new()
    {
            public void Add(TEntity entity)
            {
                using (EfContext context = new EfContext())
                {
                    context.Add(entity);
                    context.SaveChanges();
                }
            }

            public void Delete(TEntity entity)
            {
                using (EfContext context = new EfContext())
                {
                    context.Remove(entity);
                    context.SaveChanges();
                }
            }

            public virtual TEntity Get(Expression<Func<TEntity, bool>> filter)
            {
                using (EfContext context = new EfContext())
                {
                    return context.Set<TEntity>().SingleOrDefault(filter);
                }
            }

            public virtual List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
            {
                using (TContext context = new TContext())
                {
                    return filter == null ?
                        context.Set<TEntity>().ToList() :
                        context.Set<TEntity>().Where(filter).ToList();
                }
            }

            public virtual void Update(TEntity entity)
            {
                using (EfContext context = new EfContext())
                {
                    context.Update(entity);
                    context.SaveChanges();
                }
            }
    }
}
