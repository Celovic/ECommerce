using ECommerce.Entities.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Repository.EnityFramework.Abstract
{
    public interface IGenericRepository<TEntity> where TEntity : class, IEntity, new()
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter);
        void Remove(TEntity entity);
        //public IEnumerable<TEntity> TIncluded(string a);


        //void Remove(TEntity entity;
        //void RemoveRange(IEnumerable<TEntity> entity);
        //TEntity Get(Expression<Func<TEntity, bool>> filter = null);
        // void AddRange(IEnumerable<TEntity> entity);
        //void AddRange(IEnumerable<TEntity> entity);
        // IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        /*TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        void Add(TEntity entity);*/
    }
}
