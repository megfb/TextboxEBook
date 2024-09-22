using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using TextboxBook.Entity.Abstract;

namespace TextboxBook.Dal.Abstract
{
    public interface IRepositoryBase<T> where T:class,IEntity
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
    }
}
