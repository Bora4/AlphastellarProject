using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models;
using DataAccess.Abstract;

namespace WebApplication1.Repositories
{
    public class GenericRepositoryRepo<TEntity, TContext> : IGenericRepository<TEntity> where TEntity : class where TContext : VehicleContext, new()
    {
        public virtual TEntity Add(TEntity entity)
        {
            using TContext context = new();
            var addedEntity = context.Add(entity);
            context.SaveChanges();
            return entity;
        }

        public virtual TEntity Delete(TEntity entity)
        {
            using TContext context = new();
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
            return entity;
        }

        public virtual List<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate = null)
        {
            using TContext context = new();
            return predicate == null
                ? context.Set<TEntity>().ToList()
                : context.Set<TEntity>().Where(predicate).ToList();
        }

        public virtual TEntity GetById(int id)
        {
            using TContext context = new();
            return context.Set<TEntity>().Find(id);
        }

        public virtual TEntity GetOne(Expression<Func<TEntity, bool>> predicate = null)
        {
            using var context = new TContext();
            return predicate == null
                ? context.Set<TEntity>().SingleOrDefault()
                : context.Set<TEntity>().Where(predicate).SingleOrDefault();
        }
        public TEntity Get(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            using TContext context = new();
            IQueryable<TEntity> query = context.Set<TEntity>();
            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            if (includeProperties.Any())
            {
                foreach (var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);
                }
            }
            return query.FirstOrDefault();
        }
        public IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            using TContext context = new();
            IQueryable<TEntity> query = context.Set<TEntity>();
            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            if (includeProperties.Any())
            {
                foreach (var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);
                }
            }
            return query.ToList();
        }
        public int Count(Expression<Func<TEntity, bool>> predicate = null)
        {
            using TContext context = new();
            return (predicate == null ? context.Set<TEntity>().Count() : context.Set<TEntity>().Count(predicate));
        }
        public virtual TEntity Update(TEntity entity)
        {
            using TContext context = new();
            context.Update(entity);
            context.SaveChanges();
            return entity;
        }
    }
}
