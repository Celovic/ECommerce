using ECommerce.Entities.Entities.Abstract;
using ECommerce.Repository.EnityFramework.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Repository.EnityFramework.Concrete
{
    public class GenericRepository<TEntity, TContext> : IGenericRepository<TEntity> where TEntity : class, IEntity, new() where TContext : DbContext, new()
    {
        public async Task Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                await context.SaveChangesAsync();
            }
        }
        public async Task<IEnumerable<TEntity>> GetAll()
        {
            using (var context = new TContext())
            {
                return await context.Set<TEntity>().ToListAsync();
            }
        }
        public async Task<IEnumerable<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new TContext())
            {
                return filter == null
                    ? await context.Set<TEntity>().ToListAsync()
                    : await context.Set<TEntity>().Where(filter).ToListAsync();
            }
        }
        public async Task<TEntity> GetById(int id)
        {
            using (var context = new TContext())
            {
                return await context.Set<TEntity>().FindAsync(id);
            }
        }


        public void Remove(TEntity entity)
        {
            using (var context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        /*public IEnumerable<TEntity> TIncluded(string a)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().Include(a).ToList();
            }
        }*/
        /*readonly ECommerceDbContext _context;
        DbSet<TEntity> _object;
        public GenericRepository()
        {
            _object = _context.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            _object.Add(entity);
            _context.SaveChanges();
        }
        public IEnumerable<TEntity> TList()
        {
            return _object.ToList();
        }*/
    }
}
