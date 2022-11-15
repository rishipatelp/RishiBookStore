using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace RishiBooks.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);                                              //Retrieve a category from the database by id.

        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null                         //useful for foreign key reference
            );

        T getFirstOrDefault(
            Expression<Func<T, bool>> filter = null,
            string includeProperties = null
            );

        void Add(T entity);                 //to add an entity
        void Remove(int id);                //remove an object
        void Remove(T entity);              //another way to remove object
        void RemoveRange(IEnumerable<T> entity);    //remove all the entity

    }
}
